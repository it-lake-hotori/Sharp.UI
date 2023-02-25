﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ShapeExtension
    {
        public static T Fill<T>(this T self,
            Microsoft.Maui.Controls.Brush fill)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.FillProperty, fill);
            return self;
        }
        
        public static T Fill<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Brush>, ValueBuilder<Microsoft.Maui.Controls.Brush>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Brush>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.FillProperty, builder.GetValue());
            return self;
        }
        
        public static T Fill<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Brush>, BindingBuilder<Microsoft.Maui.Controls.Brush>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Brush>(self, Microsoft.Maui.Controls.Shapes.Shape.FillProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Stroke<T>(this T self,
            Microsoft.Maui.Controls.Brush stroke)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.StrokeProperty, stroke);
            return self;
        }
        
        public static T Stroke<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Brush>, ValueBuilder<Microsoft.Maui.Controls.Brush>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Brush>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.StrokeProperty, builder.GetValue());
            return self;
        }
        
        public static T Stroke<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Brush>, BindingBuilder<Microsoft.Maui.Controls.Brush>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Brush>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T StrokeThickness<T>(this T self,
            double strokeThickness)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty, strokeThickness);
            return self;
        }
        
        public static T StrokeThickness<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty, builder.GetValue());
            return self;
        }
        
        public static T StrokeThickness<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateStrokeThicknessTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            double fromValue = self.StrokeThickness;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.StrokeThickness = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateStrokeThicknessTo", transform, callback, length, easing);
        }
        
        public static T StrokeDashArray<T>(this T self,
            IList<double> strokeDashArray)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            foreach (var item in strokeDashArray)
                self.StrokeDashArray.Add(item);
            return self;
        }

        public static T StrokeDashArray<T>(this T self,
            params double[] strokeDashArray)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            foreach (var item in strokeDashArray)
                self.StrokeDashArray.Add(item);
            return self;
        }
        
        public static T StrokeDashArray<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DoubleCollection>, BindingBuilder<Microsoft.Maui.Controls.DoubleCollection>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.DoubleCollection>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeDashArrayProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T StrokeDashOffset<T>(this T self,
            double strokeDashOffset)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty, strokeDashOffset);
            return self;
        }
        
        public static T StrokeDashOffset<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty, builder.GetValue());
            return self;
        }
        
        public static T StrokeDashOffset<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateStrokeDashOffsetTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            double fromValue = self.StrokeDashOffset;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.StrokeDashOffset = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateStrokeDashOffsetTo", transform, callback, length, easing);
        }
        
        public static T StrokeLineCap<T>(this T self,
            Microsoft.Maui.Controls.Shapes.PenLineCap strokeLineCap)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.StrokeLineCapProperty, strokeLineCap);
            return self;
        }
        
        public static T StrokeLineCap<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>, ValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.StrokeLineCapProperty, builder.GetValue());
            return self;
        }
        
        public static T StrokeLineCap<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>, BindingBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeLineCapProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T StrokeLineJoin<T>(this T self,
            Microsoft.Maui.Controls.Shapes.PenLineJoin strokeLineJoin)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.StrokeLineJoinProperty, strokeLineJoin);
            return self;
        }
        
        public static T StrokeLineJoin<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>, ValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.StrokeLineJoinProperty, builder.GetValue());
            return self;
        }
        
        public static T StrokeLineJoin<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>, BindingBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeLineJoinProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T StrokeMiterLimit<T>(this T self,
            double strokeMiterLimit)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty, strokeMiterLimit);
            return self;
        }
        
        public static T StrokeMiterLimit<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty, builder.GetValue());
            return self;
        }
        
        public static T StrokeMiterLimit<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateStrokeMiterLimitTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            double fromValue = self.StrokeMiterLimit;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.StrokeMiterLimit = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateStrokeMiterLimitTo", transform, callback, length, easing);
        }
        
        public static T Aspect<T>(this T self,
            Microsoft.Maui.Controls.Stretch aspect)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.AspectProperty, aspect);
            return self;
        }
        
        public static T Aspect<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Stretch>, ValueBuilder<Microsoft.Maui.Controls.Stretch>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Stretch>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.Shape.AspectProperty, builder.GetValue());
            return self;
        }
        
        public static T Aspect<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Stretch>, BindingBuilder<Microsoft.Maui.Controls.Stretch>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.Shape
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Stretch>(self, Microsoft.Maui.Controls.Shapes.Shape.AspectProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
