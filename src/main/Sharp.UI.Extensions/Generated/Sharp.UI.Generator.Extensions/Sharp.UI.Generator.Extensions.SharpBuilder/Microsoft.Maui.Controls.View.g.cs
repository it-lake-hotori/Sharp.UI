﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ViewExtension
    {
        public static T GestureRecognizers<T>(this T self,
            IList<Microsoft.Maui.Controls.IGestureRecognizer> gestureRecognizers)
            where T : Microsoft.Maui.Controls.View
        {
            foreach (var item in gestureRecognizers)
                self.GestureRecognizers.Add(item);
            return self;
        }

        public static T GestureRecognizers<T>(this T self,
            params Microsoft.Maui.Controls.IGestureRecognizer[] gestureRecognizers)
            where T : Microsoft.Maui.Controls.View
        {
            foreach (var item in gestureRecognizers)
                self.GestureRecognizers.Add(item);
            return self;
        }
        
        public static T HorizontalOptions<T>(this T self,
            Microsoft.Maui.Controls.LayoutOptions horizontalOptions)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, horizontalOptions);
            return self;
        }
        
        public static T HorizontalOptions<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.LayoutOptions>, ValueBuilder<Microsoft.Maui.Controls.LayoutOptions>> buildValue)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.LayoutOptions>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.View.HorizontalOptionsProperty, builder.GetValue());
            return self;
        }
        
        public static T HorizontalOptions<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.LayoutOptions>, BindingBuilder<Microsoft.Maui.Controls.LayoutOptions>> buildBinding)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.LayoutOptions>(self, Microsoft.Maui.Controls.View.HorizontalOptionsProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Margin<T>(this T self,
            Microsoft.Maui.Thickness margin)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.View.MarginProperty, margin);
            return self;
        }
        
        public static T Margin<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Thickness>, ValueBuilder<Microsoft.Maui.Thickness>> buildValue)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Thickness>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.View.MarginProperty, builder.GetValue());
            return self;
        }
        
        public static T Margin<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Thickness>, BindingBuilder<Microsoft.Maui.Thickness>> buildBinding)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Thickness>(self, Microsoft.Maui.Controls.View.MarginProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T VerticalOptions<T>(this T self,
            Microsoft.Maui.Controls.LayoutOptions verticalOptions)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.View.VerticalOptionsProperty, verticalOptions);
            return self;
        }
        
        public static T VerticalOptions<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.LayoutOptions>, ValueBuilder<Microsoft.Maui.Controls.LayoutOptions>> buildValue)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.LayoutOptions>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.View.VerticalOptionsProperty, builder.GetValue());
            return self;
        }
        
        public static T VerticalOptions<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.LayoutOptions>, BindingBuilder<Microsoft.Maui.Controls.LayoutOptions>> buildBinding)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.LayoutOptions>(self, Microsoft.Maui.Controls.View.VerticalOptionsProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
