﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ArcSegmentExtension
    {
        public static T Point<T>(this T obj,
            Microsoft.Maui.Graphics.Point point)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty, point);
            return obj;
        }
        
        public static T Point<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty, builder.GetValue());
            return obj;
        }
        
        public static T Point<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(obj, Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Size<T>(this T obj,
            Microsoft.Maui.Graphics.Size size)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty, size);
            return obj;
        }
        
        public static T Size<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Size>, ValueBuilder<Microsoft.Maui.Graphics.Size>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Size>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty, builder.GetValue());
            return obj;
        }
        
        public static T Size<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Size>, BindingBuilder<Microsoft.Maui.Graphics.Size>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Size>(obj, Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RotationAngle<T>(this T obj,
            double rotationAngle)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty, rotationAngle);
            return obj;
        }
        
        public static T RotationAngle<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty, builder.GetValue());
            return obj;
        }
        
        public static T RotationAngle<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T SweepDirection<T>(this T obj,
            Microsoft.Maui.Controls.SweepDirection sweepDirection)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty, sweepDirection);
            return obj;
        }
        
        public static T SweepDirection<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.SweepDirection>, ValueBuilder<Microsoft.Maui.Controls.SweepDirection>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.SweepDirection>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty, builder.GetValue());
            return obj;
        }
        
        public static T SweepDirection<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.SweepDirection>, BindingBuilder<Microsoft.Maui.Controls.SweepDirection>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.SweepDirection>(obj, Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsLargeArc<T>(this T obj,
            bool isLargeArc)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty, isLargeArc);
            return obj;
        }
        
        public static T IsLargeArc<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsLargeArc<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.Shapes.ArcSegment
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
