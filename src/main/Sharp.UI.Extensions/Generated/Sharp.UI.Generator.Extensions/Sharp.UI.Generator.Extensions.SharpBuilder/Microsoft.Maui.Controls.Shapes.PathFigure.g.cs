﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class PathFigureExtension
    {
        public static Microsoft.Maui.Controls.Shapes.PathFigure Segments(this Microsoft.Maui.Controls.Shapes.PathFigure self,
            IList<Microsoft.Maui.Controls.Shapes.PathSegment> segments)
        {
            foreach (var item in segments)
                self.Segments.Add(item);
            return self;
        }

        public static Microsoft.Maui.Controls.Shapes.PathFigure Segments(this Microsoft.Maui.Controls.Shapes.PathFigure self,
            params Microsoft.Maui.Controls.Shapes.PathSegment[] segments)
        {
            foreach (var item in segments)
                self.Segments.Add(item);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathFigure Segments(this Microsoft.Maui.Controls.Shapes.PathFigure self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.PathSegmentCollection>, BindingBuilder<Microsoft.Maui.Controls.Shapes.PathSegmentCollection>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.PathSegmentCollection>(self, Microsoft.Maui.Controls.Shapes.PathFigure.SegmentsProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathFigure StartPoint(this Microsoft.Maui.Controls.Shapes.PathFigure self,
            Microsoft.Maui.Graphics.Point startPoint)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.PathFigure.StartPointProperty, startPoint);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathFigure StartPoint(this Microsoft.Maui.Controls.Shapes.PathFigure self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Point>, ValueBuilder<Microsoft.Maui.Graphics.Point>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Point>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.PathFigure.StartPointProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathFigure StartPoint(this Microsoft.Maui.Controls.Shapes.PathFigure self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Point>, BindingBuilder<Microsoft.Maui.Graphics.Point>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.Shapes.PathFigure.StartPointProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathFigure IsClosed(this Microsoft.Maui.Controls.Shapes.PathFigure self,
            bool isClosed)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.PathFigure.IsClosedProperty, isClosed);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathFigure IsClosed(this Microsoft.Maui.Controls.Shapes.PathFigure self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.PathFigure.IsClosedProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathFigure IsClosed(this Microsoft.Maui.Controls.Shapes.PathFigure self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.Shapes.PathFigure.IsClosedProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathFigure IsFilled(this Microsoft.Maui.Controls.Shapes.PathFigure self,
            bool isFilled)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.PathFigure.IsFilledProperty, isFilled);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathFigure IsFilled(this Microsoft.Maui.Controls.Shapes.PathFigure self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.PathFigure.IsFilledProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathFigure IsFilled(this Microsoft.Maui.Controls.Shapes.PathFigure self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.Shapes.PathFigure.IsFilledProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
