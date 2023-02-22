﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ImageButtonExtension
    {
        public static T BorderColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color borderColor)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.BorderColorProperty, borderColor);
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.BorderColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T BorderColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.ImageButton.BorderColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateBorderColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            Microsoft.Maui.Graphics.Color fromValue = self.BorderColor;
            if (fromValue == null) throw new NullReferenceException($"{nameof(self.BorderColor)} is null, can not animate from null value");
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.BorderColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateBorderColorTo", transform, callback, length, easing);
        }
        
        public static T CornerRadius<T>(this T obj,
            int cornerRadius)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.CornerRadiusProperty, cornerRadius);
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buidValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.CornerRadiusProperty, builder.GetValue());
            return obj;
        }
        
        public static T CornerRadius<T>(this T obj,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buidBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidBinding(new BindingBuilder<int>(obj, Microsoft.Maui.Controls.ImageButton.CornerRadiusProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            double borderWidth)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.BorderWidthProperty, borderWidth);
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buidValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.BorderWidthProperty, builder.GetValue());
            return obj;
        }
        
        public static T BorderWidth<T>(this T obj,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buidBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidBinding(new BindingBuilder<double>(obj, Microsoft.Maui.Controls.ImageButton.BorderWidthProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static Task<bool> AnimateBorderWidthTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            double fromValue = self.BorderWidth;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.BorderWidth = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateBorderWidthTo", transform, callback, length, easing);
        }
        
        public static T Aspect<T>(this T obj,
            Microsoft.Maui.Aspect aspect)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.AspectProperty, aspect);
            return obj;
        }
        
        public static T Aspect<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Aspect>, ValueBuilder<Microsoft.Maui.Aspect>> buidValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Aspect>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.AspectProperty, builder.GetValue());
            return obj;
        }
        
        public static T Aspect<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Aspect>, BindingBuilder<Microsoft.Maui.Aspect>> buidBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Aspect>(obj, Microsoft.Maui.Controls.ImageButton.AspectProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsOpaque<T>(this T obj,
            bool isOpaque)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.IsOpaqueProperty, isOpaque);
            return obj;
        }
        
        public static T IsOpaque<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.IsOpaqueProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsOpaque<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.ImageButton.IsOpaqueProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.CommandProperty, command);
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buidValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.CommandProperty, builder.GetValue());
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buidBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidBinding(new BindingBuilder<System.Windows.Input.ICommand>(obj, Microsoft.Maui.Controls.ImageButton.CommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object commandParameter)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.CommandParameterProperty, commandParameter);
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buidValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.CommandParameterProperty, builder.GetValue());
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buidBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidBinding(new BindingBuilder<object>(obj, Microsoft.Maui.Controls.ImageButton.CommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Source<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource source)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.SourceProperty, source);
            return obj;
        }
        
        public static T Source<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buidValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.SourceProperty, builder.GetValue());
            return obj;
        }
        
        public static T Source<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buidBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(obj, Microsoft.Maui.Controls.ImageButton.SourceProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.PaddingProperty, padding);
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Thickness>, ValueBuilder<Microsoft.Maui.Thickness>> buidValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Thickness>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ImageButton.PaddingProperty, builder.GetValue());
            return obj;
        }
        
        public static T Padding<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Thickness>, BindingBuilder<Microsoft.Maui.Thickness>> buidBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Thickness>(obj, Microsoft.Maui.Controls.ImageButton.PaddingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnClicked<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.Clicked += handler;
            return obj;
        }
        
        public static T OnClicked<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.Clicked += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnPressed<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.Pressed += handler;
            return obj;
        }
        
        public static T OnPressed<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.Pressed += (o, arg) => action(obj);
            return obj;
        }
        
        public static T OnReleased<T>(this T obj, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.Released += handler;
            return obj;
        }
        
        public static T OnReleased<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            obj.Released += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
