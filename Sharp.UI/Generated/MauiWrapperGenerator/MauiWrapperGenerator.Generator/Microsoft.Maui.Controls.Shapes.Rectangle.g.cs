﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class IRectangleGeneratedExtension
    {
        public static T RadiusX<T>(this T obj,
            double? radiusX)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            if (radiusX != null) mauiObject.RadiusX = (double)radiusX;
            return obj;
        }
        
        public static T RadiusX<T>(this T obj,
            double? radiusX,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            if (radiusX != null) mauiObject.RadiusX = (double)radiusX;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty));
            if (def.ValueIsSet()) mauiObject.RadiusX = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RadiusX<T>(this T obj,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusXProperty));
            if (def.ValueIsSet()) mauiObject.RadiusX = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RadiusY<T>(this T obj,
            double? radiusY)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            if (radiusY != null) mauiObject.RadiusY = (double)radiusY;
            return obj;
        }
        
        public static T RadiusY<T>(this T obj,
            double? radiusY,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            if (radiusY != null) mauiObject.RadiusY = (double)radiusY;
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty));
            if (def.ValueIsSet()) mauiObject.RadiusY = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T RadiusY<T>(this T obj,
            Func<BindableDef<double>, BindableDef<double>> definition)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            var def = definition(new BindableDef<double>(mauiObject, Microsoft.Maui.Controls.Shapes.Rectangle.RadiusYProperty));
            if (def.ValueIsSet()) mauiObject.RadiusY = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string>? @class)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            if (@class != null) mauiObject.@class = (System.Collections.Generic.IList<string>)@class;
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string>? @class,
            Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            if (@class != null) mauiObject.@class = (System.Collections.Generic.IList<string>)@class;
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.@class = def.GetValue();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            Func<ValueDef<System.Collections.Generic.IList<string>>, ValueDef<System.Collections.Generic.IList<string>>> definition)
            where T : Sharp.UI.IRectangle
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.Shapes.Rectangle>(obj);
            var def = definition(new ValueDef<System.Collections.Generic.IList<string>>());
            if (def.ValueIsSet()) mauiObject.@class = def.GetValue();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
