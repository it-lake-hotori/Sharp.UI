﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class SpanExtension
    {
        public static T Style<T>(this T self,
            Microsoft.Maui.Controls.Style style)
            where T : Microsoft.Maui.Controls.Span
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.StyleProperty, style);
            return self;
        }
        
        public static T Style<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Style>, ValueBuilder<Microsoft.Maui.Controls.Style>> buildValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Style>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.StyleProperty, builder.GetValue());
            return self;
        }
        
        public static T Style<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Style>, BindingBuilder<Microsoft.Maui.Controls.Style>> buildBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Style>(self, Microsoft.Maui.Controls.Span.StyleProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T BackgroundColor<T>(this T self,
            Microsoft.Maui.Graphics.Color backgroundColor)
            where T : Microsoft.Maui.Controls.Span
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.BackgroundColorProperty, backgroundColor);
            return self;
        }
        
        public static T BackgroundColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.BackgroundColorProperty, builder.GetValue());
            return self;
        }
        
        public static T BackgroundColor<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Span.BackgroundColorProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T TextColor<T>(this T self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.Span
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.TextColorProperty, textColor);
            return self;
        }
        
        public static T TextColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.TextColorProperty, builder.GetValue());
            return self;
        }
        
        public static T TextColor<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Span.TextColorProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T CharacterSpacing<T>(this T self,
            double characterSpacing)
            where T : Microsoft.Maui.Controls.Span
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.CharacterSpacingProperty, characterSpacing);
            return self;
        }
        
        public static T CharacterSpacing<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.CharacterSpacingProperty, builder.GetValue());
            return self;
        }
        
        public static T CharacterSpacing<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Span.CharacterSpacingProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T TextTransform<T>(this T self,
            Microsoft.Maui.TextTransform textTransform)
            where T : Microsoft.Maui.Controls.Span
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.TextTransformProperty, textTransform);
            return self;
        }
        
        public static T TextTransform<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.TextTransform>, ValueBuilder<Microsoft.Maui.TextTransform>> buildValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.TextTransform>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.TextTransformProperty, builder.GetValue());
            return self;
        }
        
        public static T TextTransform<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.TextTransform>, BindingBuilder<Microsoft.Maui.TextTransform>> buildBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.TextTransform>(self, Microsoft.Maui.Controls.Span.TextTransformProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Text<T>(this T self,
            string text)
            where T : Microsoft.Maui.Controls.Span
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.TextProperty, text);
            return self;
        }
        
        public static T Text<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.TextProperty, builder.GetValue());
            return self;
        }
        
        public static T Text<T>(this T self,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.Span.TextProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T FontAttributes<T>(this T self,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.Span
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.FontAttributesProperty, fontAttributes);
            return self;
        }
        
        public static T FontAttributes<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.FontAttributes>, ValueBuilder<Microsoft.Maui.Controls.FontAttributes>> buildValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.FontAttributes>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.FontAttributesProperty, builder.GetValue());
            return self;
        }
        
        public static T FontAttributes<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.FontAttributes>, BindingBuilder<Microsoft.Maui.Controls.FontAttributes>> buildBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.FontAttributes>(self, Microsoft.Maui.Controls.Span.FontAttributesProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            string fontFamily)
            where T : Microsoft.Maui.Controls.Span
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.FontFamilyProperty, fontFamily);
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.FontFamilyProperty, builder.GetValue());
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.Span.FontFamilyProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T FontSize<T>(this T self,
            double fontSize)
            where T : Microsoft.Maui.Controls.Span
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.FontSizeProperty, fontSize);
            return self;
        }
        
        public static T FontSize<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.FontSizeProperty, builder.GetValue());
            return self;
        }
        
        public static T FontSize<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Span.FontSizeProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.Span
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.FontAutoScalingEnabledProperty, builder.GetValue());
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.Span.FontAutoScalingEnabledProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T TextDecorations<T>(this T self,
            Microsoft.Maui.TextDecorations textDecorations)
            where T : Microsoft.Maui.Controls.Span
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.TextDecorationsProperty, textDecorations);
            return self;
        }
        
        public static T TextDecorations<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.TextDecorations>, ValueBuilder<Microsoft.Maui.TextDecorations>> buildValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.TextDecorations>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.TextDecorationsProperty, builder.GetValue());
            return self;
        }
        
        public static T TextDecorations<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.TextDecorations>, BindingBuilder<Microsoft.Maui.TextDecorations>> buildBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.TextDecorations>(self, Microsoft.Maui.Controls.Span.TextDecorationsProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T LineHeight<T>(this T self,
            double lineHeight)
            where T : Microsoft.Maui.Controls.Span
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.LineHeightProperty, lineHeight);
            return self;
        }
        
        public static T LineHeight<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Span.LineHeightProperty, builder.GetValue());
            return self;
        }
        
        public static T LineHeight<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Span
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Span.LineHeightProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore