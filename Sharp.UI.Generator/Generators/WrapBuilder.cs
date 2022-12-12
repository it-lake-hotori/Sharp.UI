﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Sharp.UI.Generator;

public class WrapBuilder
{
    GeneratorExecutionContext context;
    List<string> interfaceNameList = new List<string>();

    Dictionary<string, INamedTypeSymbol> mauiTypes = new Dictionary<string, INamedTypeSymbol>();

    public WrapBuilder(GeneratorExecutionContext context)
    {
        this.context = context;
    }

    //------------- helpers -----------------

    public static string GetTypeName(INamedTypeSymbol type)
    {
        var tail = type.IsGenericType ? $"{type.TypeArguments.FirstOrDefault().Name}" : "";
        var prefix = type.ContainingNamespace.ToDisplayString().Contains("Compatibility") ? "Compatibility" : "";
        return $"{prefix}{type.Name}{tail}";
    }

    public static string GetInterfaceName(INamedTypeSymbol type)
    {
        return $"I{GetTypeName(type)}";
    }

    public static string CamelCase(string str)
    {
        var camelCaseName = $"{str.Substring(0, 1).ToLower()}{str.Substring(1)}";
        camelCaseName = camelCaseName.Equals("class") ? "@class" : camelCaseName;
        camelCaseName = camelCaseName.Equals("switch") ? "@switch" : camelCaseName;
        camelCaseName = camelCaseName.Equals("event") ? "@event" : camelCaseName;
        return camelCaseName;
    }

    public static bool IsGenericIList(INamedTypeSymbol symbol, out string typeName)
    {
        if (symbol.Name.Equals("IList") && symbol.IsGenericType)
        {
            typeName = symbol.TypeArguments.First().ToDisplayString();
            return true;
        }

        var type = symbol;
        do
        {
            foreach (var inter in type.Interfaces)
                if (inter.Name.Equals("IList") && inter.IsGenericType)
                {
                    typeName = inter.TypeArguments.First().ToDisplayString();
                    return true;
                }

            type = type.BaseType;
        }
        while (type != null && !type.Name.Equals("Object"));

        typeName = null;
        return false;
    }

    public static AttributeData GetMauiWrapperAttributeData(INamedTypeSymbol symbol)
    {
        var attributes = symbol.GetAttributes();
        return attributes.FirstOrDefault(e => e.AttributeClass.Name.Contains("MauiWrapper"));
    }

    public static AttributeData GetAttachedInterfacesAttributeData(INamedTypeSymbol symbol)
    {
        var attributes = symbol.GetAttributes();
        return attributes.FirstOrDefault(e => e.AttributeClass.Name.Contains("AttachedInterfaces"));
    }

    public static INamedTypeSymbol GetMauiType(AttributeData wrapperAttribute)
    {
        if (wrapperAttribute != null)
            return (INamedTypeSymbol)wrapperAttribute.ConstructorArguments[0].Value;
        else
            return null;
    }

    public static INamedTypeSymbol GetBaseType(INamedTypeSymbol symbol)
    {
        return GetMauiType(GetMauiWrapperAttributeData(symbol));
    }

    //------------- generate -----------------

    List<INamedTypeSymbol> doneExtensions;

    public void Generate()
	{
        doneExtensions = new List<INamedTypeSymbol>();

        var wrappedSymbols = context.Compilation.GetSymbolsWithName((s) => true, filter: SymbolFilter.Type)
            .Where(e => !e.IsStatic && e.GetAttributes().FirstOrDefault(e => e.AttributeClass.Name.Contains("MauiWrapper")) != null);

        var wrappedStaticSymbols = context.Compilation.GetSymbolsWithName((s) => true, filter: SymbolFilter.Type)
            .Where(e => e.IsStatic && e.GetAttributes().FirstOrDefault(e => e.AttributeClass.Name.Contains("MauiWrapper")) != null);
        
        GenerateExtensions(wrappedStaticSymbols);

        GenerateSymbols(wrappedSymbols);
        GenerateExtensions(wrappedSymbols);
        GenerateInterfaces(wrappedSymbols);
    }

    //------------- generate symbols -----------------

    void GenerateSymbols(IEnumerable<ISymbol> symbols)
    {
        foreach (var symbol in symbols)
        {
            var typeSymbol = (INamedTypeSymbol)symbol;
            var wrapperAttribute = GetMauiWrapperAttributeData(typeSymbol);
            var mauiType = GetMauiType(wrapperAttribute);
            this.GenerateSymbol(typeSymbol, wrapperAttribute);
        }
    }

    void GenerateSymbol(INamedTypeSymbol symbol, AttributeData wrapperAttribute)
    {
        var builder = new StringBuilder();
        builder.AppendLine("//");
        builder.AppendLine("// <auto-generated>");
        builder.AppendLine("//");
        builder.AppendLine();
        builder.AppendLine("#pragma warning disable CS8669");
        builder.AppendLine();

        new MauiClassBuilder(symbol, wrapperAttribute, builder).Build();

        builder.AppendLine();
        builder.AppendLine();
        builder.AppendLine("#pragma warning restore CS8669");

        var tail = symbol.IsGenericType ? $".{symbol.TypeArguments.FirstOrDefault().Name}" : "";

        context.AddSource($"{symbol.ContainingNamespace}.{symbol.Name}{tail}.g.cs", builder.ToString());
    }

    //------------- generate extensions -----------------

    void GenerateExtensions(IEnumerable<ISymbol> symbols)
    {

        foreach (var symbol in symbols)
        {
            this.GenerateExtension((INamedTypeSymbol)symbol, isWrappedSymbol: true);

            var baseType = GetBaseType((INamedTypeSymbol)symbol);
            if (baseType != null)
                doneExtensions.Add(baseType);
            else
                doneExtensions.Add((INamedTypeSymbol)symbol);
        }

        foreach (var symbol in symbols)
        {
            var baseType = GetBaseType((INamedTypeSymbol)symbol);
            if (baseType != null)
            {
                var type = baseType.BaseType;
                while (!type.Name.Equals("Object"))
                {
                    if (!doneExtensions.Contains(type))
                    {
                        this.GenerateExtension(type, isWrappedSymbol: false);
                        doneExtensions.Add(type);
                    }
                    type = type.BaseType;
                }
            }
        }
    }

    void GenerateExtension(INamedTypeSymbol symbol, bool isWrappedSymbol)
    {
        var builder = new StringBuilder();
        builder.AppendLine("//");
        builder.AppendLine("// <auto-generated>");
        builder.AppendLine("//");
        builder.AppendLine();
        builder.AppendLine("#pragma warning disable CS8669");
        builder.AppendLine();

        var extBuilder = new MauiExtensionBuilder(symbol, builder, isWrappedSymbol);
        extBuilder.Build();

        if (extBuilder.IsMethodsGenerated)
        {
            builder.AppendLine();
            builder.AppendLine();
            builder.AppendLine("#pragma warning restore CS8669");

            var wrapperAttribute = GetMauiWrapperAttributeData(symbol);
            var type = GetBaseType(symbol);
            if (type == null) type = symbol;

            var tail = type.IsGenericType ? $".{type.TypeArguments.FirstOrDefault().Name}" : "";
            var extension = wrapperAttribute != null && wrapperAttribute.ConstructorArguments[0].Value == null ? ".extension" : "";
            context.AddSource($"{type.ContainingNamespace}.{type.Name}{tail}{extension}.g.cs", builder.ToString());
        }
    }

    //-------------- generate interfaces ----------------

    void GenerateInterfaces(IEnumerable<ISymbol> symbols)
    {
        var builder = new StringBuilder();
        builder.AppendLine("//");
        builder.AppendLine("// <auto-generated>");
        builder.AppendLine("//");
        builder.AppendLine();
        builder.AppendLine("namespace Sharp.UI;");
        builder.AppendLine();
        builder.AppendLine();

        foreach (var symbol in symbols)
        {
            var wrapperAttribute = GetMauiWrapperAttributeData((INamedTypeSymbol)symbol);
            var typeValue = wrapperAttribute.ConstructorArguments[0].Value;
            if (typeValue != null)
            {
                var mauiType = GetMauiType(wrapperAttribute);
                var type = mauiType;
                while (!type.Name.Equals("Object"))
                {
                    var interfaceName = GetInterfaceName(type);
                    if (!interfaceNameList.Contains(interfaceName))
                    {
                        AddInterface(builder, type);
                        interfaceNameList.Add(interfaceName);
                    }
                    type = type.BaseType;
                }
            }
        }

        if (interfaceNameList.Count() > 0)
            context.AddSource($"Interfaces.g.cs", builder.ToString());
    }

    void AddInterface(StringBuilder builder, INamedTypeSymbol type)
    {
        var parentInterfaceName = GetInterfaceName(type.BaseType);
        var parentString = parentInterfaceName.Equals("IObject") ? "" : $" : {parentInterfaceName}";
        builder.AppendLine($@"public partial interface {GetInterfaceName(type)}{parentString} {{ }}");
    }
}