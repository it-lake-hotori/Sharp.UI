﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class PolylineExtension
    {
        public static Microsoft.Maui.Controls.Shapes.Polyline Points(this Microsoft.Maui.Controls.Shapes.Polyline self,
            IList<Microsoft.Maui.Graphics.Point> points)
        {
            foreach (var item in points)
                self.Points.Add(item);
            return self;
        }

        public static Microsoft.Maui.Controls.Shapes.Polyline Points(this Microsoft.Maui.Controls.Shapes.Polyline self,
            params Microsoft.Maui.Graphics.Point[] points)
        {
            foreach (var item in points)
                self.Points.Add(item);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Polyline Points(this Microsoft.Maui.Controls.Shapes.Polyline self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.PointCollection>, BindingBuilder<Microsoft.Maui.Controls.PointCollection>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.PointCollection>(self, Microsoft.Maui.Controls.Shapes.Polyline.PointsProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Polyline FillRule(this Microsoft.Maui.Controls.Shapes.Polyline self,
            Microsoft.Maui.Controls.Shapes.FillRule fillRule)
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.Polyline.FillRuleProperty, fillRule);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Polyline FillRule(this Microsoft.Maui.Controls.Shapes.Polyline self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Shapes.FillRule>, ValueBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Shapes.FillRule>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.Polyline.FillRuleProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.Polyline FillRule(this Microsoft.Maui.Controls.Shapes.Polyline self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.FillRule>, BindingBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.FillRule>(self, Microsoft.Maui.Controls.Shapes.Polyline.FillRuleProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
