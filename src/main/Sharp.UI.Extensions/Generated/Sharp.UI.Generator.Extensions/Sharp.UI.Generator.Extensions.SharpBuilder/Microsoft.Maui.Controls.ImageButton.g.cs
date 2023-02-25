﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class ImageButtonExtension
    {
        public static T BorderColor<T>(this T self,
            Microsoft.Maui.Graphics.Color borderColor)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.BorderColorProperty, borderColor);
            return self;
        }
        
        public static T BorderColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.BorderColorProperty, builder.GetValue());
            return self;
        }
        
        public static T BorderColor<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.ImageButton.BorderColorProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateBorderColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            Microsoft.Maui.Graphics.Color fromValue = self.BorderColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.BorderColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateBorderColorTo", transform, callback, length, easing);
        }
        
        public static T CornerRadius<T>(this T self,
            int cornerRadius)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.CornerRadiusProperty, cornerRadius);
            return self;
        }
        
        public static T CornerRadius<T>(this T self,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.CornerRadiusProperty, builder.GetValue());
            return self;
        }
        
        public static T CornerRadius<T>(this T self,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildBinding(new BindingBuilder<int>(self, Microsoft.Maui.Controls.ImageButton.CornerRadiusProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T BorderWidth<T>(this T self,
            double borderWidth)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.BorderWidthProperty, borderWidth);
            return self;
        }
        
        public static T BorderWidth<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.BorderWidthProperty, builder.GetValue());
            return self;
        }
        
        public static T BorderWidth<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.ImageButton.BorderWidthProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateBorderWidthTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            double fromValue = self.BorderWidth;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.BorderWidth = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateBorderWidthTo", transform, callback, length, easing);
        }
        
        public static T Aspect<T>(this T self,
            Microsoft.Maui.Aspect aspect)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.AspectProperty, aspect);
            return self;
        }
        
        public static T Aspect<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Aspect>, ValueBuilder<Microsoft.Maui.Aspect>> buildValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Aspect>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.AspectProperty, builder.GetValue());
            return self;
        }
        
        public static T Aspect<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Aspect>, BindingBuilder<Microsoft.Maui.Aspect>> buildBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Aspect>(self, Microsoft.Maui.Controls.ImageButton.AspectProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T IsOpaque<T>(this T self,
            bool isOpaque)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.IsOpaqueProperty, isOpaque);
            return self;
        }
        
        public static T IsOpaque<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.IsOpaqueProperty, builder.GetValue());
            return self;
        }
        
        public static T IsOpaque<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.ImageButton.IsOpaqueProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Command<T>(this T self,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.CommandProperty, command);
            return self;
        }
        
        public static T Command<T>(this T self,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.CommandProperty, builder.GetValue());
            return self;
        }
        
        public static T Command<T>(this T self,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.ImageButton.CommandProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T CommandParameter<T>(this T self,
            object commandParameter)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.CommandParameterProperty, commandParameter);
            return self;
        }
        
        public static T CommandParameter<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.CommandParameterProperty, builder.GetValue());
            return self;
        }
        
        public static T CommandParameter<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.ImageButton.CommandParameterProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Source<T>(this T self,
            Microsoft.Maui.Controls.ImageSource source)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.SourceProperty, source);
            return self;
        }
        
        public static T Source<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buildValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.SourceProperty, builder.GetValue());
            return self;
        }
        
        public static T Source<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buildBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(self, Microsoft.Maui.Controls.ImageButton.SourceProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Padding<T>(this T self,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.PaddingProperty, padding);
            return self;
        }
        
        public static T Padding<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Thickness>, ValueBuilder<Microsoft.Maui.Thickness>> buildValue)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Thickness>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ImageButton.PaddingProperty, builder.GetValue());
            return self;
        }
        
        public static T Padding<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Thickness>, BindingBuilder<Microsoft.Maui.Thickness>> buildBinding)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Thickness>(self, Microsoft.Maui.Controls.ImageButton.PaddingProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T OnClicked<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.Clicked += handler;
            return self;
        }
        
        public static T OnClicked<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.Clicked += (o, arg) => action(self);
            return self;
        }
        
        public static T OnPressed<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.Pressed += handler;
            return self;
        }
        
        public static T OnPressed<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.Pressed += (o, arg) => action(self);
            return self;
        }
        
        public static T OnReleased<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.Released += handler;
            return self;
        }
        
        public static T OnReleased<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ImageButton
        {
            self.Released += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore