﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class TemplatedPageExtension
    {
        public static T ControlTemplate<T>(this T self,
            Microsoft.Maui.Controls.ControlTemplate controlTemplate)
            where T : Microsoft.Maui.Controls.TemplatedPage
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.TemplatedPage.ControlTemplateProperty, controlTemplate);
            return self;
        }
        
        public static T ControlTemplate<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ControlTemplate>, ValueBuilder<Microsoft.Maui.Controls.ControlTemplate>> buildValue)
            where T : Microsoft.Maui.Controls.TemplatedPage
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.ControlTemplate>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.TemplatedPage.ControlTemplateProperty, builder.GetValue());
            return self;
        }
        
        public static T ControlTemplate<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ControlTemplate>, BindingBuilder<Microsoft.Maui.Controls.ControlTemplate>> buildBinding)
            where T : Microsoft.Maui.Controls.TemplatedPage
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.ControlTemplate>(self, Microsoft.Maui.Controls.TemplatedPage.ControlTemplateProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
