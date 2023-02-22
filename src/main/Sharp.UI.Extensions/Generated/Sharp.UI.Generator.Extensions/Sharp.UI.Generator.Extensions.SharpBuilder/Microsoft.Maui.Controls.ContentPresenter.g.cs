﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ContentPresenterExtension
    {
        public static T Content<T>(this T obj,
            Microsoft.Maui.Controls.View content)
            where T : Microsoft.Maui.Controls.ContentPresenter
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.ContentPresenter.ContentProperty, content);
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.View>, ValueBuilder<Microsoft.Maui.Controls.View>> buidValue)
            where T : Microsoft.Maui.Controls.ContentPresenter
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Controls.View>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.ContentPresenter.ContentProperty, builder.GetValue());
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.View>, BindingBuilder<Microsoft.Maui.Controls.View>> buidBinding)
            where T : Microsoft.Maui.Controls.ContentPresenter
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.View>(obj, Microsoft.Maui.Controls.ContentPresenter.ContentProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
