﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class RectangleExtension
    {
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusX(this Microsoft.Maui.Controls.Shapes.Rectangle self,
            double radiusX)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty, radiusX);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusX(this Microsoft.Maui.Controls.Shapes.Rectangle self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusX(this Microsoft.Maui.Controls.Shapes.Rectangle self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateRadiusXTo(this Microsoft.Maui.Controls.Shapes.Rectangle self, double value, uint length = 250, Easing? easing = null)
        {
            double fromValue = self.RadiusX;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.RadiusX = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateRadiusXTo", transform, callback, length, easing);
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusY(this Microsoft.Maui.Controls.Shapes.Rectangle self,
            double radiusY)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty, radiusY);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusY(this Microsoft.Maui.Controls.Shapes.Rectangle self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Rectangle RadiusY(this Microsoft.Maui.Controls.Shapes.Rectangle self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateRadiusYTo(this Microsoft.Maui.Controls.Shapes.Rectangle self, double value, uint length = 250, Easing? easing = null)
        {
            double fromValue = self.RadiusY;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.RadiusY = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateRadiusYTo", transform, callback, length, easing);
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore