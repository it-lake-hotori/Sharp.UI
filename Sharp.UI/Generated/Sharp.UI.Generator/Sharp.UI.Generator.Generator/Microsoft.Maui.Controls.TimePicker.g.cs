﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class TimePickerGeneratedExtension
    {
        public static T Format<T>(this T obj,
            string? format)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            if (format != null) mauiObject.Format = (string)format;
            return obj;
        }
        
        public static T Format<T>(this T obj,
            string? format,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);         
            if (format != null) mauiObject.Format = (string)format;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.TimePicker.FormatProperty));
            if (def.ValueIsSet()) mauiObject.Format = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Format<T>(this T obj,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.TimePicker.FormatProperty));
            if (def.ValueIsSet()) mauiObject.Format = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? textColor)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            if (textColor != null) mauiObject.TextColor = (Microsoft.Maui.Graphics.Color)textColor;
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? textColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);         
            if (textColor != null) mauiObject.TextColor = (Microsoft.Maui.Graphics.Color)textColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TimePicker.TextColorProperty));
            if (def.ValueIsSet()) mauiObject.TextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TimePicker.TextColorProperty));
            if (def.ValueIsSet()) mauiObject.TextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            double? characterSpacing)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            if (characterSpacing != null) mauiObject.CharacterSpacing = (double)characterSpacing;
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            double? characterSpacing,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);         
            if (characterSpacing != null) mauiObject.CharacterSpacing = (double)characterSpacing;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.TimePicker.CharacterSpacingProperty));
            if (def.ValueIsSet()) mauiObject.CharacterSpacing = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T CharacterSpacing<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.TimePicker.CharacterSpacingProperty));
            if (def.ValueIsSet()) mauiObject.CharacterSpacing = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Time<T>(this T obj,
            System.TimeSpan? time)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            if (time != null) mauiObject.Time = (System.TimeSpan)time;
            return obj;
        }
        
        public static T Time<T>(this T obj,
            System.TimeSpan? time,
            System.Func<BindableDef<System.TimeSpan>, BindableDef<System.TimeSpan>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);         
            if (time != null) mauiObject.Time = (System.TimeSpan)time;
            var def = definition(new BindableDef<System.TimeSpan>(mauiObject, Microsoft.Maui.Controls.TimePicker.TimeProperty));
            if (def.ValueIsSet()) mauiObject.Time = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Time<T>(this T obj,
            System.Func<BindableDef<System.TimeSpan>, BindableDef<System.TimeSpan>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            var def = definition(new BindableDef<System.TimeSpan>(mauiObject, Microsoft.Maui.Controls.TimePicker.TimeProperty));
            if (def.ValueIsSet()) mauiObject.Time = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            Microsoft.Maui.Controls.FontAttributes? fontAttributes,
            System.Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);         
            if (fontAttributes != null) mauiObject.FontAttributes = (Microsoft.Maui.Controls.FontAttributes)fontAttributes;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.TimePicker.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAttributes<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.FontAttributes>, BindableDef<Microsoft.Maui.Controls.FontAttributes>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.FontAttributes>(mauiObject, Microsoft.Maui.Controls.TimePicker.FontAttributesProperty));
            if (def.ValueIsSet()) mauiObject.FontAttributes = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            string? fontFamily,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);         
            if (fontFamily != null) mauiObject.FontFamily = (string)fontFamily;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.TimePicker.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontFamily<T>(this T obj,
            System.Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.TimePicker.FontFamilyProperty));
            if (def.ValueIsSet()) mauiObject.FontFamily = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            double? fontSize,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);         
            if (fontSize != null) mauiObject.FontSize = (double)fontSize;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.TimePicker.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontSize<T>(this T obj,
            System.Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.TimePicker.FontSizeProperty));
            if (def.ValueIsSet()) mauiObject.FontSize = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            bool? fontAutoScalingEnabled,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);         
            if (fontAutoScalingEnabled != null) mauiObject.FontAutoScalingEnabled = (bool)fontAutoScalingEnabled;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.TimePicker.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T FontAutoScalingEnabled<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.ITimePicker
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TimePicker>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.TimePicker.FontAutoScalingEnabledProperty));
            if (def.ValueIsSet()) mauiObject.FontAutoScalingEnabled = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669