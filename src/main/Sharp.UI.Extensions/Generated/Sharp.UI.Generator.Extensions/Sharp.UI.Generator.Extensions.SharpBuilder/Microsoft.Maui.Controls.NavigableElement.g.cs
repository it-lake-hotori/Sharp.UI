﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class NavigableElementExtension
    {
        public static T Style<T>(this T self,
            Microsoft.Maui.Controls.Style style)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.NavigableElement.StyleProperty, style);
            return self;
        }
        
        public static T Style<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Style>, ValueBuilder<Microsoft.Maui.Controls.Style>> buildValue)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Style>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.NavigableElement.StyleProperty, builder.GetValue());
            return self;
        }
        
        public static T Style<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Style>, BindingBuilder<Microsoft.Maui.Controls.Style>> buildBinding)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Style>(self, Microsoft.Maui.Controls.NavigableElement.StyleProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T StyleClass<T>(this T self,
            IList<string> styleClass)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            foreach (var item in styleClass)
                self.StyleClass.Add(item);
            return self;
        }

        public static T StyleClass<T>(this T self,
            params string[] styleClass)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            foreach (var item in styleClass)
                self.StyleClass.Add(item);
            return self;
        }
        
        public static T @class<T>(this T self,
            IList<string> @class)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            foreach (var item in @class)
                self.@class.Add(item);
            return self;
        }

        public static T @class<T>(this T self,
            params string[] @class)
            where T : Microsoft.Maui.Controls.NavigableElement
        {
            foreach (var item in @class)
                self.@class.Add(item);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore