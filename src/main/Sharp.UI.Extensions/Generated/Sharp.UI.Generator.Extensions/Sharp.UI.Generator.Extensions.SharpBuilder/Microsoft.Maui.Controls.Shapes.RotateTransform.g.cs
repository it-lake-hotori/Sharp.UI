﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class RotateTransformExtension
    {
        public static T Angle<T>(this T self,
            double angle)
            where T : Microsoft.Maui.Controls.Shapes.RotateTransform
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.RotateTransform.AngleProperty, angle);
            return self;
        }
        
        public static T Angle<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.RotateTransform
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.RotateTransform.AngleProperty, builder.GetValue());
            return self;
        }
        
        public static T Angle<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.RotateTransform
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.RotateTransform.AngleProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T CenterX<T>(this T self,
            double centerX)
            where T : Microsoft.Maui.Controls.Shapes.RotateTransform
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.RotateTransform.CenterXProperty, centerX);
            return self;
        }
        
        public static T CenterX<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.RotateTransform
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.RotateTransform.CenterXProperty, builder.GetValue());
            return self;
        }
        
        public static T CenterX<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.RotateTransform
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.RotateTransform.CenterXProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T CenterY<T>(this T self,
            double centerY)
            where T : Microsoft.Maui.Controls.Shapes.RotateTransform
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.RotateTransform.CenterYProperty, centerY);
            return self;
        }
        
        public static T CenterY<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.RotateTransform
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.RotateTransform.CenterYProperty, builder.GetValue());
            return self;
        }
        
        public static T CenterY<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.RotateTransform
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.RotateTransform.CenterYProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore