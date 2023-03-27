﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class PickerExtension
    {
        public static T FontAttributes<T>(this T self,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.FontAttributesProperty, fontAttributes);
            return self;
        }
        
        public static T FontAttributes<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.FontAttributes>, IPropertyBuilder<Microsoft.Maui.Controls.FontAttributes>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<Microsoft.Maui.Controls.FontAttributes>(self, Microsoft.Maui.Controls.Picker.FontAttributesProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            string fontFamily)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.FontFamilyProperty, fontFamily);
            return self;
        }
        
        public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.Picker.FontFamilyProperty);
            configure(context).Build();
            return self;
        }
        
        public static T FontSize<T>(this T self,
            double fontSize)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.FontSizeProperty, fontSize);
            return self;
        }
        
        public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Picker.FontSizeProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Picker
        {
            double fromValue = self.FontSize;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.FontSize = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Picker.FontAutoScalingEnabledProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Items<T>(this T self,
            IList<string> items)
            where T : Microsoft.Maui.Controls.Picker
        {
            foreach (var item in items)
                self.Items.Add(item);
            return self;
        }

        public static T Items<T>(this T self,
            params string[] items)
            where T : Microsoft.Maui.Controls.Picker
        {
            foreach (var item in items)
                self.Items.Add(item);
            return self;
        }
        
        public static T ItemsSource<T>(this T self,
            System.Collections.IList itemsSource)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.ItemsSourceProperty, itemsSource);
            return self;
        }
        
        public static T ItemsSource<T>(this T self, Func<PropertyContext<System.Collections.IList>, IPropertyBuilder<System.Collections.IList>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<System.Collections.IList>(self, Microsoft.Maui.Controls.Picker.ItemsSourceProperty);
            configure(context).Build();
            return self;
        }
        
        public static T SelectedIndex<T>(this T self,
            int selectedIndex)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.SelectedIndexProperty, selectedIndex);
            return self;
        }
        
        public static T SelectedIndex<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.Picker.SelectedIndexProperty);
            configure(context).Build();
            return self;
        }
        
        public static T SelectedItem<T>(this T self,
            object selectedItem)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.SelectedItemProperty, selectedItem);
            return self;
        }
        
        public static T SelectedItem<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.Picker.SelectedItemProperty);
            configure(context).Build();
            return self;
        }
        
        public static T TextColor<T>(this T self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.TextColorProperty, textColor);
            return self;
        }
        
        public static T TextColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Picker.TextColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateTextColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Picker
        {
            Microsoft.Maui.Graphics.Color fromValue = self.TextColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.TextColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
        }
        
        public static T CharacterSpacing<T>(this T self,
            double characterSpacing)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.CharacterSpacingProperty, characterSpacing);
            return self;
        }
        
        public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Picker.CharacterSpacingProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Picker
        {
            double fromValue = self.CharacterSpacing;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.CharacterSpacing = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
        }
        
        public static T Title<T>(this T self,
            string title)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.TitleProperty, title);
            return self;
        }
        
        public static T Title<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.Picker.TitleProperty);
            configure(context).Build();
            return self;
        }
        
        public static T TitleColor<T>(this T self,
            Microsoft.Maui.Graphics.Color titleColor)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.TitleColorProperty, titleColor);
            return self;
        }
        
        public static T TitleColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Picker.TitleColorProperty);
            configure(context).Build();
            return self;
        }
        
        public static Task<bool> AnimateTitleColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Picker
        {
            Microsoft.Maui.Graphics.Color fromValue = self.TitleColor;
            var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
            var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.TitleColor = actValue; };
            return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateTitleColorTo", transform, callback, length, easing);
        }
        
        public static T HorizontalTextAlignment<T>(this T self,
            Microsoft.Maui.TextAlignment horizontalTextAlignment)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, horizontalTextAlignment);
            return self;
        }
        
        public static T HorizontalTextAlignment<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextAlignment>, IPropertyBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<Microsoft.Maui.TextAlignment>(self, Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static T VerticalTextAlignment<T>(this T self,
            Microsoft.Maui.TextAlignment verticalTextAlignment)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, verticalTextAlignment);
            return self;
        }
        
        public static T VerticalTextAlignment<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextAlignment>, IPropertyBuilder<Microsoft.Maui.TextAlignment>> configure)
            where T : Microsoft.Maui.Controls.Picker
        {
            var context = new PropertyContext<Microsoft.Maui.TextAlignment>(self, Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty);
            configure(context).Build();
            return self;
        }
        
        public static T ItemDisplayBinding<T>(this T self,
            Microsoft.Maui.Controls.BindingBase itemDisplayBinding)
            where T : Microsoft.Maui.Controls.Picker
        {
            if (FluentStyling.Setters != null) throw new ArgumentException("Fluent styling not available for property ItemDisplayBinding");
            self.ItemDisplayBinding = itemDisplayBinding;
            return self;
        }
        
        public static T OnSelectedIndexChanged<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SelectedIndexChanged += handler;
            return self;
        }
        
        public static T OnSelectedIndexChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SelectedIndexChanged += (o, arg) => action(self);
            return self;
        }
        

        public static T TextCenterHorizontal<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextCenterVertical<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextCenter<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.Center);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextTop<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextBottom<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker, Microsoft.Maui.ITextAlignment
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextTopStart<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextBottomStart<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextTopEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextBottomEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextStart<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.Picker
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Picker.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        
    }
}

#pragma warning restore CS8601
#nullable restore