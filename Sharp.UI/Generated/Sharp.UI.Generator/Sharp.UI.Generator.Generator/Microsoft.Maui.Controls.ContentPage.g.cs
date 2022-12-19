﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class ContentPageGeneratedExtension
    {
        public static T Content<T>(this T obj,
            Microsoft.Maui.Controls.View? content)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            if (content != null) mauiObject.Content = (Microsoft.Maui.Controls.View)content;
            return obj;
        }
        
        public static T Content<T>(this T obj,
            Microsoft.Maui.Controls.View? content,
            System.Func<BindableDef<Microsoft.Maui.Controls.View>, BindableDef<Microsoft.Maui.Controls.View>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);         
            if (content != null) mauiObject.Content = (Microsoft.Maui.Controls.View)content;
            var def = definition(new BindableDef<Microsoft.Maui.Controls.View>(mauiObject, Microsoft.Maui.Controls.ContentPage.ContentProperty));
            if (def.ValueIsSet()) mauiObject.Content = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T Content<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.View>, BindableDef<Microsoft.Maui.Controls.View>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.View>(mauiObject, Microsoft.Maui.Controls.ContentPage.ContentProperty));
            if (def.ValueIsSet()) mauiObject.Content = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T ShellPresentationMode<T>(this T obj,
            Microsoft.Maui.Controls.PresentationMode? presentationMode)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            if (presentationMode != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.PresentationModeProperty, (Microsoft.Maui.Controls.PresentationMode)presentationMode);
            return obj;
        }
        
        public static T ShellPresentationMode<T>(this T obj,
            Microsoft.Maui.Controls.PresentationMode? presentationMode,
            System.Func<BindableDef<Microsoft.Maui.Controls.PresentationMode>, BindableDef<Microsoft.Maui.Controls.PresentationMode>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);         
            if (presentationMode != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.PresentationModeProperty, (Microsoft.Maui.Controls.PresentationMode)presentationMode);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.PresentationMode>(mauiObject, Microsoft.Maui.Controls.Shell.PresentationModeProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.PresentationModeProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellPresentationMode<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.PresentationMode>, BindableDef<Microsoft.Maui.Controls.PresentationMode>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.PresentationMode>(mauiObject, Microsoft.Maui.Controls.Shell.PresentationModeProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.PresentationModeProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellBackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? backgroundColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            if (backgroundColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.BackgroundColorProperty, (Microsoft.Maui.Graphics.Color)backgroundColor);
            return obj;
        }
        
        public static T ShellBackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? backgroundColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);         
            if (backgroundColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.BackgroundColorProperty, (Microsoft.Maui.Graphics.Color)backgroundColor);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.BackgroundColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.BackgroundColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellBackgroundColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.BackgroundColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.BackgroundColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellForegroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? foregroundColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            if (foregroundColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ForegroundColorProperty, (Microsoft.Maui.Graphics.Color)foregroundColor);
            return obj;
        }
        
        public static T ShellForegroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? foregroundColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);         
            if (foregroundColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ForegroundColorProperty, (Microsoft.Maui.Graphics.Color)foregroundColor);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.ForegroundColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ForegroundColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellForegroundColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.ForegroundColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.ForegroundColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellTitleColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? titleColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            if (titleColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleColorProperty, (Microsoft.Maui.Graphics.Color)titleColor);
            return obj;
        }
        
        public static T ShellTitleColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? titleColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);         
            if (titleColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleColorProperty, (Microsoft.Maui.Graphics.Color)titleColor);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.TitleColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellTitleColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.TitleColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellDisabledColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? disabledColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            if (disabledColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.DisabledColorProperty, (Microsoft.Maui.Graphics.Color)disabledColor);
            return obj;
        }
        
        public static T ShellDisabledColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? disabledColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);         
            if (disabledColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.DisabledColorProperty, (Microsoft.Maui.Graphics.Color)disabledColor);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.DisabledColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.DisabledColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellDisabledColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.DisabledColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.DisabledColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellUnselectedColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? unselectedColor)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            if (unselectedColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.UnselectedColorProperty, (Microsoft.Maui.Graphics.Color)unselectedColor);
            return obj;
        }
        
        public static T ShellUnselectedColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color? unselectedColor,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);         
            if (unselectedColor != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.UnselectedColorProperty, (Microsoft.Maui.Graphics.Color)unselectedColor);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.UnselectedColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.UnselectedColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellUnselectedColor<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Graphics.Color>, BindableDef<Microsoft.Maui.Graphics.Color>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.Shell.UnselectedColorProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.UnselectedColorProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellNavBarHasShadow<T>(this T obj,
            bool? navBarHasShadow)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            if (navBarHasShadow != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty, (bool)navBarHasShadow);
            return obj;
        }
        
        public static T ShellNavBarHasShadow<T>(this T obj,
            bool? navBarHasShadow,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);         
            if (navBarHasShadow != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty, (bool)navBarHasShadow);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellNavBarHasShadow<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarHasShadowProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellNavBarIsVisible<T>(this T obj,
            bool? navBarIsVisible)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            if (navBarIsVisible != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty, (bool)navBarIsVisible);
            return obj;
        }
        
        public static T ShellNavBarIsVisible<T>(this T obj,
            bool? navBarIsVisible,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);         
            if (navBarIsVisible != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty, (bool)navBarIsVisible);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellNavBarIsVisible<T>(this T obj,
            System.Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.NavBarIsVisibleProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellTitleView<T>(this T obj,
            Microsoft.Maui.Controls.View? titleView)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            if (titleView != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, (Microsoft.Maui.Controls.View)titleView);
            return obj;
        }
        
        public static T ShellTitleView<T>(this T obj,
            Microsoft.Maui.Controls.View? titleView,
            System.Func<BindableDef<Microsoft.Maui.Controls.View>, BindableDef<Microsoft.Maui.Controls.View>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);         
            if (titleView != null) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, (Microsoft.Maui.Controls.View)titleView);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.View>(mauiObject, Microsoft.Maui.Controls.Shell.TitleViewProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
        public static T ShellTitleView<T>(this T obj,
            System.Func<BindableDef<Microsoft.Maui.Controls.View>, BindableDef<Microsoft.Maui.Controls.View>> definition)
            where T : Sharp.UI.IContentPage
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.ContentPage>(obj);
            var def = definition(new BindableDef<Microsoft.Maui.Controls.View>(mauiObject, Microsoft.Maui.Controls.Shell.TitleViewProperty));
            if (def.ValueIsSet()) mauiObject.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, def.GetValue());
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669