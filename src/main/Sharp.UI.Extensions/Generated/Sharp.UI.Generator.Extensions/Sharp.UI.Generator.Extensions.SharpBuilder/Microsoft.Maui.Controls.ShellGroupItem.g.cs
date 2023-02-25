﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ShellGroupItemExtension
    {
        public static T FlyoutDisplayOptions<T>(this T self,
            Microsoft.Maui.Controls.FlyoutDisplayOptions flyoutDisplayOptions)
            where T : Microsoft.Maui.Controls.ShellGroupItem
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ShellGroupItem.FlyoutDisplayOptionsProperty, flyoutDisplayOptions);
            return self;
        }
        
        public static T FlyoutDisplayOptions<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.FlyoutDisplayOptions>, ValueBuilder<Microsoft.Maui.Controls.FlyoutDisplayOptions>> buildValue)
            where T : Microsoft.Maui.Controls.ShellGroupItem
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.FlyoutDisplayOptions>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ShellGroupItem.FlyoutDisplayOptionsProperty, builder.GetValue());
            return self;
        }
        
        public static T FlyoutDisplayOptions<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.FlyoutDisplayOptions>, BindingBuilder<Microsoft.Maui.Controls.FlyoutDisplayOptions>> buildBinding)
            where T : Microsoft.Maui.Controls.ShellGroupItem
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.FlyoutDisplayOptions>(self, Microsoft.Maui.Controls.ShellGroupItem.FlyoutDisplayOptionsProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
