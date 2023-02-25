﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class TranslateTransformExtension
    {
        public static T X<T>(this T self,
            double x)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.TranslateTransform.XProperty, x);
            return self;
        }
        
        public static T X<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.TranslateTransform.XProperty, builder.GetValue());
            return self;
        }
        
        public static T X<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.TranslateTransform.XProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Y<T>(this T self,
            double y)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.TranslateTransform.YProperty, y);
            return self;
        }
        
        public static T Y<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.TranslateTransform.YProperty, builder.GetValue());
            return self;
        }
        
        public static T Y<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.TranslateTransform.YProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
