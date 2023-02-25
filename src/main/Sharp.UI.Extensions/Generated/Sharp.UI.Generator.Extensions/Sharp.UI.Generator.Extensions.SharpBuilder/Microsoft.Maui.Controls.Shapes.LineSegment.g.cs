﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class LineSegmentExtension
    {
        public static T Point<T>(this T self,
            Microsoft.Maui.Graphics.Point point)
            where T : Microsoft.Maui.Controls.Shapes.LineSegment
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty, point);
            return self;
        }
        
        public static T Point<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.LineSegment
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty, builder.GetValue());
            return self;
        }
        
        public static T Point<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.LineSegment
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
