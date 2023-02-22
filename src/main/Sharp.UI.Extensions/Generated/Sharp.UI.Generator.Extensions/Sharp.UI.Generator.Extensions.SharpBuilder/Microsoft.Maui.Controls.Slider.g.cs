﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class SliderExtension
    {
        public static T MinimumTrackColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color minimumTrackColor)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.MinimumTrackColorProperty, minimumTrackColor);
            return obj;
        }
        
        public static T MinimumTrackColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.MinimumTrackColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T MinimumTrackColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.Slider.MinimumTrackColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateMinimumTrackColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Slider
        {
            Microsoft.Maui.Graphics.Color fromValue = self.MinimumTrackColor;
            if (fromValue == null) throw new NullReferenceException($"{nameof(self.MinimumTrackColor)} is null, can not animate from null value");
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.MinimumTrackColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateMinimumTrackColorTo", transform, callback, length, easing);
        }
        
        public static T MaximumTrackColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color maximumTrackColor)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.MaximumTrackColorProperty, maximumTrackColor);
            return obj;
        }
        
        public static T MaximumTrackColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.MaximumTrackColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T MaximumTrackColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.Slider.MaximumTrackColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateMaximumTrackColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Slider
        {
            Microsoft.Maui.Graphics.Color fromValue = self.MaximumTrackColor;
            if (fromValue == null) throw new NullReferenceException($"{nameof(self.MaximumTrackColor)} is null, can not animate from null value");
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.MaximumTrackColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateMaximumTrackColorTo", transform, callback, length, easing);
        }
        
        public static T ThumbColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color thumbColor)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.ThumbColorProperty, thumbColor);
            return obj;
        }
        
        public static T ThumbColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.ThumbColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T ThumbColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.Slider.ThumbColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateThumbColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Slider
        {
            Microsoft.Maui.Graphics.Color fromValue = self.ThumbColor;
            if (fromValue == null) throw new NullReferenceException($"{nameof(self.ThumbColor)} is null, can not animate from null value");
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.ThumbColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateThumbColorTo", transform, callback, length, easing);
        }
        
        public static T ThumbImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource thumbImageSource)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.ThumbImageSourceProperty, thumbImageSource);
            return obj;
        }
        
        public static T ThumbImageSource<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buidValue)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.ThumbImageSourceProperty, builder.GetValue());
            return obj;
        }
        
        public static T ThumbImageSource<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buidBinding)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(obj, Microsoft.Maui.Controls.Slider.ThumbImageSourceProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T DragStartedCommand<T>(this T obj,
            System.Windows.Input.ICommand dragStartedCommand)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.DragStartedCommandProperty, dragStartedCommand);
            return obj;
        }
        
        public static T DragStartedCommand<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.DragStartedCommandProperty, builder.GetValue());
            return obj;
        }
        
        public static T DragStartedCommand<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.Slider.DragStartedCommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T DragCompletedCommand<T>(this T obj,
            System.Windows.Input.ICommand dragCompletedCommand)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.DragCompletedCommandProperty, dragCompletedCommand);
            return obj;
        }
        
        public static T DragCompletedCommand<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.DragCompletedCommandProperty, builder.GetValue());
            return obj;
        }
        
        public static T DragCompletedCommand<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.Slider.DragCompletedCommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            double maximum)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.MaximumProperty, maximum);
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.MaximumProperty, builder.GetValue());
            return obj;
        }
        
        public static T Maximum<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Slider.MaximumProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateMaximumTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Slider
        {
            double fromValue = self.Maximum;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.Maximum = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateMaximumTo", transform, callback, length, easing);
        }
        
        public static T Minimum<T>(this T obj,
            double minimum)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.MinimumProperty, minimum);
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.MinimumProperty, builder.GetValue());
            return obj;
        }
        
        public static T Minimum<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Slider.MinimumProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateMinimumTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Slider
        {
            double fromValue = self.Minimum;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.Minimum = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateMinimumTo", transform, callback, length, easing);
        }
        
        public static T Value<T>(this T obj,
            double value)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.ValueProperty, value);
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.Slider.ValueProperty, builder.GetValue());
            return obj;
        }
        
        public static T Value<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.Slider
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.Slider.ValueProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateValueTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Slider
        {
            double fromValue = self.Value;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.Value = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateValueTo", transform, callback, length, easing);
        }
        
        public static T OnValueChanged<T>(this T obj, System.EventHandler<Microsoft.Maui.Controls.ValueChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.ValueChanged += handler;
            return obj;
        }
        
        public static T OnValueChanged<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.ValueChanged += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDragStarted<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.DragStarted += handler;
            return obj;
        }
        
        public static T OnDragStarted<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.DragStarted += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnDragCompleted<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.DragCompleted += handler;
            return obj;
        }
        
        public static T OnDragCompleted<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Slider
        {
            obj.DragCompleted += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
