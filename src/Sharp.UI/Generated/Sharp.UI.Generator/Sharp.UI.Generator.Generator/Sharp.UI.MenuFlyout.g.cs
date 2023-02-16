﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.MenuFlyout</c> class.
    /// </summary>
    public partial class MenuFlyout : Microsoft.Maui.Controls.MenuFlyout, Sharp.UI.IMenuFlyout, IMauiWrapper, IList<Microsoft.Maui.IMenuElement>
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

        public void Add(Func<IEnumerable<Microsoft.Maui.IMenuElement>> builder)
        {
            var items = builder();
            foreach (var item in items)
                base.Add(item);
        }

        public void Add(Action<IList<Microsoft.Maui.IMenuElement>> builder)
        {
            List<Microsoft.Maui.IMenuElement> items = new List<Microsoft.Maui.IMenuElement>();
            builder(items);
            foreach (var item in items)
                base.Add(item);
        }

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
