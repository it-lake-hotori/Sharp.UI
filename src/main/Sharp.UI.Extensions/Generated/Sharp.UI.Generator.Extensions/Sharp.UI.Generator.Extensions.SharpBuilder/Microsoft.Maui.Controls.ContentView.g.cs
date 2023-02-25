﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class ContentViewExtension
    {
        public static T Content<T>(this T self,
            Microsoft.Maui.Controls.View content)
            where T : Microsoft.Maui.Controls.ContentView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ContentView.ContentProperty, content);
            return self;
        }
        
        public static T Content<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.View>, ValueBuilder<Microsoft.Maui.Controls.View>> buildValue)
            where T : Microsoft.Maui.Controls.ContentView
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.View>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ContentView.ContentProperty, builder.GetValue());
            return self;
        }
        
        public static T Content<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.View>, BindingBuilder<Microsoft.Maui.Controls.View>> buildBinding)
            where T : Microsoft.Maui.Controls.ContentView
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.View>(self, Microsoft.Maui.Controls.ContentView.ContentProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore