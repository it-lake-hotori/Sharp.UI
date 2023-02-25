﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class PolyLineSegmentExtension
    {
        public static T Points<T>(this T self,
            IList<Microsoft.Maui.Graphics.Point> points)
            where T : Microsoft.Maui.Controls.Shapes.PolyLineSegment
        {
            foreach (var item in points)
                self.Points.Add(item);
            return self;
        }

        public static T Points<T>(this T self,
            params Microsoft.Maui.Graphics.Point[] points)
            where T : Microsoft.Maui.Controls.Shapes.PolyLineSegment
        {
            foreach (var item in points)
                self.Points.Add(item);
            return self;
        }
        
        public static T Points<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.PointCollection>, BindingBuilder<Microsoft.Maui.Controls.PointCollection>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.PolyLineSegment
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.PointCollection>(self, Microsoft.Maui.Controls.Shapes.PolyLineSegment.PointsProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
