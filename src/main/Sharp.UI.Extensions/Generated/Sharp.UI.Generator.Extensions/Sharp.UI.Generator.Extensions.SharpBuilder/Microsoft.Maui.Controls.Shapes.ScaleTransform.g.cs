﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class ScaleTransformExtension
    {
        public static T ScaleX<T>(this T self,
            double scaleX)
            where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleXProperty, scaleX);
            return self;
        }
        
        public static T ScaleX<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleXProperty, builder.GetValue());
            return self;
        }
        
        public static T ScaleX<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleXProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T ScaleY<T>(this T self,
            double scaleY)
            where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleYProperty, scaleY);
            return self;
        }
        
        public static T ScaleY<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleYProperty, builder.GetValue());
            return self;
        }
        
        public static T ScaleY<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.ScaleTransform.ScaleYProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T CenterX<T>(this T self,
            double centerX)
            where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterXProperty, centerX);
            return self;
        }
        
        public static T CenterX<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterXProperty, builder.GetValue());
            return self;
        }
        
        public static T CenterX<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterXProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T CenterY<T>(this T self,
            double centerY)
            where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterYProperty, centerY);
            return self;
        }
        
        public static T CenterY<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterYProperty, builder.GetValue());
            return self;
        }
        
        public static T CenterY<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.ScaleTransform
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.ScaleTransform.CenterYProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
