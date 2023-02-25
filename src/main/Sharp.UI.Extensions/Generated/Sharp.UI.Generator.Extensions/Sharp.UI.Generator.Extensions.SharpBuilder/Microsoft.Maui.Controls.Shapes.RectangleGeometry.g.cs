﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class RectangleGeometryExtension
    {
        public static T Rect<T>(this T self,
            Microsoft.Maui.Graphics.Rect rect)
            where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.RectangleGeometry.RectProperty, rect);
            return self;
        }
        
        public static T Rect<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Rect>, ValueBuilder<Microsoft.Maui.Graphics.Rect>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Rect>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.Shapes.RectangleGeometry.RectProperty, builder.GetValue());
            return self;
        }
        
        public static T Rect<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Rect>, BindingBuilder<Microsoft.Maui.Graphics.Rect>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Rect>(self, Microsoft.Maui.Controls.Shapes.RectangleGeometry.RectProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
