﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class DatePickerExtension
    {
        public static T Date<T>(this T self,
            System.DateTime date)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DatePicker.DateProperty, date);
            return self;
        }
        
        public static T Date<T>(this T self, Func<PropertyContext<System.DateTime>, IPropertyBuilder<System.DateTime>> configure)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            var context = new PropertyContext<System.DateTime>(self, Microsoft.Maui.Controls.DatePicker.DateProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Format<T>(this T self,
            string format)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DatePicker.FormatProperty, format);
            return self;
        }
        
        public static T Format<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.DatePicker.FormatProperty);
            configure(context).Build();
            return self;
        }
        
        public static T MaximumDate<T>(this T self,
            System.DateTime maximumDate)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DatePicker.MaximumDateProperty, maximumDate);
            return self;
        }
        
        public static T MaximumDate<T>(this T self, Func<PropertyContext<System.DateTime>, IPropertyBuilder<System.DateTime>> configure)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            var context = new PropertyContext<System.DateTime>(self, Microsoft.Maui.Controls.DatePicker.MaximumDateProperty);
            configure(context).Build();
            return self;
        }
        
        public static T MinimumDate<T>(this T self,
            System.DateTime minimumDate)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DatePicker.MinimumDateProperty, minimumDate);
            return self;
        }
        
        public static T MinimumDate<T>(this T self, Func<PropertyContext<System.DateTime>, IPropertyBuilder<System.DateTime>> configure)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            var context = new PropertyContext<System.DateTime>(self, Microsoft.Maui.Controls.DatePicker.MinimumDateProperty);
            configure(context).Build();
            return self;
        }
        
        public static T TextColor<T>(this T self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DatePicker.TextColorProperty, textColor);
            return self;
        }
        
        public static T TextColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.DatePicker.TextColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateTextColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            Microsoft.Maui.Graphics.Color fromValue = self.TextColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.TextColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
        }
        
        public static T CharacterSpacing<T>(this T self,
            double characterSpacing)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DatePicker.CharacterSpacingProperty, characterSpacing);
            return self;
        }
        
        public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.DatePicker.CharacterSpacingProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            double fromValue = self.CharacterSpacing;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.CharacterSpacing = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
        }
        
        public static T FontAttributes<T>(this T self,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DatePicker.FontAttributesProperty, fontAttributes);
            return self;
        }
        
        public static T FontAttributes<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.FontAttributes>, IPropertyBuilder<Microsoft.Maui.Controls.FontAttributes>> configure)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.FontAttributes>(self, Microsoft.Maui.Controls.DatePicker.FontAttributesProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            string fontFamily)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DatePicker.FontFamilyProperty, fontFamily);
            return self;
        }
        
        public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.DatePicker.FontFamilyProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontSize<T>(this T self,
            double fontSize)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DatePicker.FontSizeProperty, fontSize);
            return self;
        }
        
        public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.DatePicker.FontSizeProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            double fromValue = self.FontSize;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.FontSize = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DatePicker.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.DatePicker.FontAutoScalingEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static T OnDateSelected<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.DateChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            self.DateSelected += handler;
            return self;
        }
        
        public static T OnDateSelected<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DatePicker
        {
            self.DateSelected += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore