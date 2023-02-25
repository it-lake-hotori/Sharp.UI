﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class RoundRectangleExtension
    {
        public static Microsoft.Maui.Controls.Shapes.RoundRectangle CornerRadius(this Microsoft.Maui.Controls.Shapes.RoundRectangle self,
            Microsoft.Maui.CornerRadius cornerRadius)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, cornerRadius);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.RoundRectangle CornerRadius(this Microsoft.Maui.Controls.Shapes.RoundRectangle self,
            System.Func<ValueBuilder<Microsoft.Maui.CornerRadius>, ValueBuilder<Microsoft.Maui.CornerRadius>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.CornerRadius>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.RoundRectangle CornerRadius(this Microsoft.Maui.Controls.Shapes.RoundRectangle self,
            System.Func<BindingBuilder<Microsoft.Maui.CornerRadius>, BindingBuilder<Microsoft.Maui.CornerRadius>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.CornerRadius>(self, Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore