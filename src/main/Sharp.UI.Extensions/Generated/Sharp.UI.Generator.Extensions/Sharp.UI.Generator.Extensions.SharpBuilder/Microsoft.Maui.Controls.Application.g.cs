﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class ApplicationExtension
    {
        public static T MainPage<T>(this T self,
            Microsoft.Maui.Controls.Page? mainPage)
            where T : Microsoft.Maui.Controls.Application
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property MainPage");
            self.MainPage = mainPage;
            return self;
        }
        
        public static T MainPage<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Page?>, ValueBuilder<Microsoft.Maui.Controls.Page?>> buildValue)
            where T : Microsoft.Maui.Controls.Application
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property MainPage");
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Page?>());
            if (builder.ValueIsSet()) self.MainPage = builder.GetValue();
            return self;
        }
        
        public static T Resources<T>(this T self,
            Microsoft.Maui.Controls.ResourceDictionary resources)
            where T : Microsoft.Maui.Controls.Application
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Resources");
            self.Resources = resources;
            return self;
        }
        
        public static T Resources<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ResourceDictionary>, ValueBuilder<Microsoft.Maui.Controls.ResourceDictionary>> buildValue)
            where T : Microsoft.Maui.Controls.Application
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Resources");
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.ResourceDictionary>());
            if (builder.ValueIsSet()) self.Resources = builder.GetValue();
            return self;
        }
        
        public static T UserAppTheme<T>(this T self,
            Microsoft.Maui.ApplicationModel.AppTheme userAppTheme)
            where T : Microsoft.Maui.Controls.Application
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property UserAppTheme");
            self.UserAppTheme = userAppTheme;
            return self;
        }
        
        public static T UserAppTheme<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.ApplicationModel.AppTheme>, ValueBuilder<Microsoft.Maui.ApplicationModel.AppTheme>> buildValue)
            where T : Microsoft.Maui.Controls.Application
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property UserAppTheme");
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.ApplicationModel.AppTheme>());
            if (builder.ValueIsSet()) self.UserAppTheme = builder.GetValue();
            return self;
        }
        
        public static T OnRequestedThemeChanged<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.AppThemeChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.Application
        {
            self.RequestedThemeChanged += handler;
            return self;
        }
        
        public static T OnRequestedThemeChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Application
        {
            self.RequestedThemeChanged += (o, arg) => action(self);
            return self;
        }
        
        public static T OnModalPopped<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ModalPoppedEventArgs>? handler)
            where T : Microsoft.Maui.Controls.Application
        {
            self.ModalPopped += handler;
            return self;
        }
        
        public static T OnModalPopped<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Application
        {
            self.ModalPopped += (o, arg) => action(self);
            return self;
        }
        
        public static T OnModalPopping<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ModalPoppingEventArgs>? handler)
            where T : Microsoft.Maui.Controls.Application
        {
            self.ModalPopping += handler;
            return self;
        }
        
        public static T OnModalPopping<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Application
        {
            self.ModalPopping += (o, arg) => action(self);
            return self;
        }
        
        public static T OnModalPushed<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ModalPushedEventArgs>? handler)
            where T : Microsoft.Maui.Controls.Application
        {
            self.ModalPushed += handler;
            return self;
        }
        
        public static T OnModalPushed<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Application
        {
            self.ModalPushed += (o, arg) => action(self);
            return self;
        }
        
        public static T OnModalPushing<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ModalPushingEventArgs>? handler)
            where T : Microsoft.Maui.Controls.Application
        {
            self.ModalPushing += handler;
            return self;
        }
        
        public static T OnModalPushing<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Application
        {
            self.ModalPushing += (o, arg) => action(self);
            return self;
        }
        
        public static T OnPageAppearing<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.Page>? handler)
            where T : Microsoft.Maui.Controls.Application
        {
            self.PageAppearing += handler;
            return self;
        }
        
        public static T OnPageAppearing<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Application
        {
            self.PageAppearing += (o, arg) => action(self);
            return self;
        }
        
        public static T OnPageDisappearing<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.Page>? handler)
            where T : Microsoft.Maui.Controls.Application
        {
            self.PageDisappearing += handler;
            return self;
        }
        
        public static T OnPageDisappearing<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Application
        {
            self.PageDisappearing += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore