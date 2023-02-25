﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class BindingExtension
    {
        public static Microsoft.Maui.Controls.Binding Converter(this Microsoft.Maui.Controls.Binding self,
            Microsoft.Maui.Controls.IValueConverter converter)
        {
            self.Converter = converter;
            return self;
        }
        
        public static Microsoft.Maui.Controls.Binding Converter(this Microsoft.Maui.Controls.Binding self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.IValueConverter>, ValueBuilder<Microsoft.Maui.Controls.IValueConverter>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.IValueConverter>());
            if (builder.ValueIsSet()) self.Converter = builder.GetValue();
            return self;
        }
        
        public static Microsoft.Maui.Controls.Binding ConverterParameter(this Microsoft.Maui.Controls.Binding self,
            object converterParameter)
        {
            self.ConverterParameter = converterParameter;
            return self;
        }
        
        public static Microsoft.Maui.Controls.Binding ConverterParameter(this Microsoft.Maui.Controls.Binding self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.ConverterParameter = builder.GetValue();
            return self;
        }
        
        public static Microsoft.Maui.Controls.Binding Path(this Microsoft.Maui.Controls.Binding self,
            string path)
        {
            self.Path = path;
            return self;
        }
        
        public static Microsoft.Maui.Controls.Binding Path(this Microsoft.Maui.Controls.Binding self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.Path = builder.GetValue();
            return self;
        }
        
        public static Microsoft.Maui.Controls.Binding Source(this Microsoft.Maui.Controls.Binding self,
            object source)
        {
            self.Source = source;
            return self;
        }
        
        public static Microsoft.Maui.Controls.Binding Source(this Microsoft.Maui.Controls.Binding self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.Source = builder.GetValue();
            return self;
        }
        
        public static Microsoft.Maui.Controls.Binding UpdateSourceEventName(this Microsoft.Maui.Controls.Binding self,
            string updateSourceEventName)
        {
            self.UpdateSourceEventName = updateSourceEventName;
            return self;
        }
        
        public static Microsoft.Maui.Controls.Binding UpdateSourceEventName(this Microsoft.Maui.Controls.Binding self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.UpdateSourceEventName = builder.GetValue();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore