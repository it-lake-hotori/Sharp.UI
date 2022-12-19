﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ColumnDefinitionGeneratedExtension
    {
        public static T Width<T>(this T obj,
            Microsoft.Maui.GridLength? width)
            where T : Sharp.UI.IColumnDefinition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ColumnDefinition>(obj);
            if (width != null) mauiObject.Width = (Microsoft.Maui.GridLength)width;
            return obj;
        }
        
        public static T Width<T>(this T obj,
            Microsoft.Maui.GridLength? width,
            System.Func<BindableDef<Microsoft.Maui.GridLength>, BindableDef<Microsoft.Maui.GridLength>> definition)
            where T : Sharp.UI.IColumnDefinition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ColumnDefinition>(obj);         
            if (width != null) mauiObject.Width = (Microsoft.Maui.GridLength)width;
            var def = definition(new BindableDef<Microsoft.Maui.GridLength>(mauiObject, Microsoft.Maui.Controls.ColumnDefinition.WidthProperty));
            if (def.ValueIsSet()) mauiObject.Width = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Width<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.GridLength>, BindableDef<Microsoft.Maui.GridLength>> definition)
            where T : Sharp.UI.IColumnDefinition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ColumnDefinition>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.GridLength>(mauiObject, Microsoft.Maui.Controls.ColumnDefinition.WidthProperty));
            if (def.ValueIsSet()) mauiObject.Width = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T OnSizeChanged<T>(this T obj, System.EventHandler handler)
            where T : Sharp.UI.IColumnDefinition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ColumnDefinition>(obj);
            mauiObject.SizeChanged += handler;
            return obj;
        }
        
        public static T OnSizeChanged<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IColumnDefinition
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ColumnDefinition>(obj);
            mauiObject.SizeChanged += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669