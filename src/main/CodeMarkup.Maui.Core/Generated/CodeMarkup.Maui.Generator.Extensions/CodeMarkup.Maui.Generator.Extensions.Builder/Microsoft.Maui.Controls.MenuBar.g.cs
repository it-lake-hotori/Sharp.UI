﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class MenuBarExtension
    {
        public static T IsEnabled<T>(this T self,
            bool isEnabled)
            where T : Microsoft.Maui.Controls.MenuBar
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuBar.IsEnabledProperty, isEnabled);
            return self;
        }
        
        public static T IsEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.MenuBar
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.MenuBar.IsEnabledProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore