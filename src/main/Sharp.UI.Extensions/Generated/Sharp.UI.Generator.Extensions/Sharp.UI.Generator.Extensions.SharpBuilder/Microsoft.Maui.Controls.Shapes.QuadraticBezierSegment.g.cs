﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class QuadraticBezierSegmentExtension
    {
        public static T Point1<T>(this T self,
            Microsoft.Maui.Graphics.Point point1)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point1Property, point1);
            return self;
        }
        
        public static T Point1<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point1Property, builder.GetValue());
            return self;
        }
        
        public static T Point1<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point1Property));
            builder.BindProperty();
            return self;
        }
        
        public static T Point2<T>(this T self,
            Microsoft.Maui.Graphics.Point point2)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point2Property, point2);
            return self;
        }
        
        public static T Point2<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point2Property, builder.GetValue());
            return self;
        }
        
        public static T Point2<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point2Property));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
