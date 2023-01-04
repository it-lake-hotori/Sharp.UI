﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class DataTemplateGeneratedSharpObjectExtension
    {
        public static T LoadTemplate<T>(this T obj,
            System.Func<object> loadTemplate)
            where T : Sharp.UI.IDataTemplate
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.DataTemplate>(obj);
            mauiObject.LoadTemplate = (System.Func<object>)loadTemplate;
            return obj;
        }
        
        public static T LoadTemplate<T>(this T obj,
            System.Func<ValueBuilder<System.Func<object>>, ValueBuilder<System.Func<object>>> buildValue)
            where T : Sharp.UI.IDataTemplate
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.DataTemplate>(obj);
            var builder = buildValue(new ValueBuilder<System.Func<object>>());
            if (builder.ValueIsSet()) mauiObject.LoadTemplate = builder.GetValue();
            return obj;
        }
        
        public static T LoadTemplate<T>(this T obj,
            System.Func<LazyValueBuilder<System.Func<object>>, LazyValueBuilder<System.Func<object>>> buildValue)
            where T : Sharp.UI.IDataTemplate
        {
            var mauiObject = MauiWrapper.Value<Sharp.UI.DataTemplate>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Func<object>>());
            if (builder.ValueIsSet()) mauiObject.LoadTemplate = builder.GetValue();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669