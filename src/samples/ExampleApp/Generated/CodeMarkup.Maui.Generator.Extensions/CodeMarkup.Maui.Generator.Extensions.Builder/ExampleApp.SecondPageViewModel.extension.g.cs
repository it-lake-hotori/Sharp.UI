﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace ExampleApp
{
    using CodeMarkup.Maui.Internal;
    using CodeMarkup.Maui;
    
    public static partial class SecondPageViewModelExtension
    {
        public static T Title<T>(this T self,
            string title)
            where T : ExampleApp.SecondPageViewModel
        {
            self.SetValueOrAddSetter(ExampleApp.SecondPageViewModel.TitleProperty, title);
            return self;
        }
        
        public static T Title<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : ExampleApp.SecondPageViewModel
        {
            var context = new PropertyContext<string>(self, ExampleApp.SecondPageViewModel.TitleProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Author<T>(this T self,
            string author)
            where T : ExampleApp.SecondPageViewModel
        {
            self.SetValueOrAddSetter(ExampleApp.SecondPageViewModel.AuthorProperty, author);
            return self;
        }
        
        public static T Author<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
            where T : ExampleApp.SecondPageViewModel
        {
            var context = new PropertyContext<string>(self, ExampleApp.SecondPageViewModel.AuthorProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore