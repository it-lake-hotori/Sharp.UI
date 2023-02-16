﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.MenuFlyout</c> class.
    /// </summary>
    public partial class MenuFlyout : Microsoft.Maui.Controls.MenuFlyout, Sharp.UI.IMenuFlyout, IMauiWrapper
    {
        // ----- constructors -----

        public MenuFlyout() { }

        public MenuFlyout(out MenuFlyout menuFlyout) 
        {
            menuFlyout = this;
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public MenuFlyout(System.Action<MenuFlyout> configure) 
        {
            configure(this);
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public MenuFlyout(out MenuFlyout menuFlyout, System.Action<MenuFlyout> configure) 
        {
            menuFlyout = this;
            configure(this);
        }

        public void Add(Func<Sharp.UI.MenuFlyout, Sharp.UI.MenuFlyout> configure) { configure(this); }

        // ----- properties / events -----

        public new object BindingContext { get => base.BindingContext; set => base.BindingContext = MauiWrapper.Value<object>(value); }

        // ----- set value method -----

        public new void SetValue(Microsoft.Maui.Controls.BindableProperty property, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(property, mauiValue);
        }

        public new void SetValue(Microsoft.Maui.Controls.BindablePropertyKey propertyKey, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(propertyKey, mauiValue);
        }
    }
}

#pragma warning restore CS8669
