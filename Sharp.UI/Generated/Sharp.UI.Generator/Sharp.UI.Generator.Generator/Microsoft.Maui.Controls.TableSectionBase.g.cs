﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ITableSectionBaseGeneratedExtension
    {
        public static T Title<T>(this T obj,
            string? title)
            where T : Sharp.UI.ITableSectionBase
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.TableSectionBase>(obj);
            if (title != null) mauiObject.Title = (string)title;
            return obj;
        }
        
        public static T Title<T>(this T obj,
            string? title,
            Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ITableSectionBase
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.TableSectionBase>(obj);
            if (title != null) mauiObject.Title = (string)title;
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.TableSectionBase.TitleProperty));
            if (def.ValueIsSet()) mauiObject.Title = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Title<T>(this T obj,
            Func<BindableDef<string>, BindableDef<string>> definition)
            where T : Sharp.UI.ITableSectionBase
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.TableSectionBase>(obj);
            var def = definition(new BindableDef<string>(mauiObject, Microsoft.Maui.Controls.TableSectionBase.TitleProperty));
            if (def.ValueIsSet()) mauiObject.Title = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? textColor)
            where T : Sharp.UI.ITableSectionBase
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.TableSectionBase>(obj);
            if (textColor != null) mauiObject.TextColor = (Microsoft.Maui.Graphics.Color)textColor;
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? textColor,
            Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ITableSectionBase
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.TableSectionBase>(obj);
            if (textColor != null) mauiObject.TextColor = (Microsoft.Maui.Graphics.Color)textColor;
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TableSectionBase.TextColorProperty));
            if (def.ValueIsSet()) mauiObject.TextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T TextColor<T>(this T obj,
            Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.ITableSectionBase
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.TableSectionBase>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.TableSectionBase.TextColorProperty));
            if (def.ValueIsSet()) mauiObject.TextColor = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669