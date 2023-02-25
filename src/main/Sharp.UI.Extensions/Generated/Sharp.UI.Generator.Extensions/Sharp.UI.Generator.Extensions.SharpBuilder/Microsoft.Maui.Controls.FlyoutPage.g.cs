﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class FlyoutPageExtension
    {
        public static T Detail<T>(this T self,
            Microsoft.Maui.Controls.Page detail)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Detail");
            self.Detail = detail;
            return self;
        }
        
        public static T Detail<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Page>, ValueBuilder<Microsoft.Maui.Controls.Page>> buildValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Detail");
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Page>());
            if (builder.ValueIsSet()) self.Detail = builder.GetValue();
            return self;
        }
        
        public static T IsGestureEnabled<T>(this T self,
            bool isGestureEnabled)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlyoutPage.IsGestureEnabledProperty, isGestureEnabled);
            return self;
        }
        
        public static T IsGestureEnabled<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlyoutPage.IsGestureEnabledProperty, builder.GetValue());
            return self;
        }
        
        public static T IsGestureEnabled<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.FlyoutPage.IsGestureEnabledProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T IsPresented<T>(this T self,
            bool isPresented)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlyoutPage.IsPresentedProperty, isPresented);
            return self;
        }
        
        public static T IsPresented<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlyoutPage.IsPresentedProperty, builder.GetValue());
            return self;
        }
        
        public static T IsPresented<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.FlyoutPage.IsPresentedProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Flyout<T>(this T self,
            Microsoft.Maui.Controls.Page flyout)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Flyout");
            self.Flyout = flyout;
            return self;
        }
        
        public static T Flyout<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Page>, ValueBuilder<Microsoft.Maui.Controls.Page>> buildValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Flyout");
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Page>());
            if (builder.ValueIsSet()) self.Flyout = builder.GetValue();
            return self;
        }
        
        public static T FlyoutLayoutBehavior<T>(this T self,
            Microsoft.Maui.Controls.FlyoutLayoutBehavior flyoutLayoutBehavior)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlyoutPage.FlyoutLayoutBehaviorProperty, flyoutLayoutBehavior);
            return self;
        }
        
        public static T FlyoutLayoutBehavior<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>, ValueBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>> buildValue)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlyoutPage.FlyoutLayoutBehaviorProperty, builder.GetValue());
            return self;
        }
        
        public static T FlyoutLayoutBehavior<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>, BindingBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>> buildBinding)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.FlyoutLayoutBehavior>(self, Microsoft.Maui.Controls.FlyoutPage.FlyoutLayoutBehaviorProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T OnIsPresentedChanged<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            self.IsPresentedChanged += handler;
            return self;
        }
        
        public static T OnIsPresentedChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            self.IsPresentedChanged += (o, arg) => action(self);
            return self;
        }
        
        public static T OnBackButtonPressed<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.BackButtonPressedEventArgs> handler)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            self.BackButtonPressed += handler;
            return self;
        }
        
        public static T OnBackButtonPressed<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.FlyoutPage
        {
            self.BackButtonPressed += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore