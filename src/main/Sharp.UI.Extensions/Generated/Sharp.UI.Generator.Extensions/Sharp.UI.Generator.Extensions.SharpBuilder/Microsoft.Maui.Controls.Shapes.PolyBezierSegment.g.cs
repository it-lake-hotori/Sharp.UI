﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class PolyBezierSegmentExtension
    {
        public static Microsoft.Maui.Controls.Shapes.PolyBezierSegment Points(this Microsoft.Maui.Controls.Shapes.PolyBezierSegment self,
            IList<Microsoft.Maui.Graphics.Point> points)
        {
            foreach (var item in points)
                self.Points.Add(item);
            return self;
        }

        public static Microsoft.Maui.Controls.Shapes.PolyBezierSegment Points(this Microsoft.Maui.Controls.Shapes.PolyBezierSegment self,
            params Microsoft.Maui.Graphics.Point[] points)
        {
            foreach (var item in points)
                self.Points.Add(item);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PolyBezierSegment Points(this Microsoft.Maui.Controls.Shapes.PolyBezierSegment self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.PointCollection>, BindingBuilder<Microsoft.Maui.Controls.PointCollection>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.PointCollection>(self, Microsoft.Maui.Controls.Shapes.PolyBezierSegment.PointsProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore