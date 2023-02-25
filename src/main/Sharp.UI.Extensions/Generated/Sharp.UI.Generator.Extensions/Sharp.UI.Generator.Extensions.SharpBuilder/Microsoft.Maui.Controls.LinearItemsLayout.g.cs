﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class LinearItemsLayoutExtension
    {
        public static T ItemSpacing<T>(this T self,
            double itemSpacing)
            where T : Microsoft.Maui.Controls.LinearItemsLayout
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.LinearItemsLayout.ItemSpacingProperty, itemSpacing);
            return self;
        }
        
        public static T ItemSpacing<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.LinearItemsLayout
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.LinearItemsLayout.ItemSpacingProperty, builder.GetValue());
            return self;
        }
        
        public static T ItemSpacing<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.LinearItemsLayout
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.LinearItemsLayout.ItemSpacingProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
