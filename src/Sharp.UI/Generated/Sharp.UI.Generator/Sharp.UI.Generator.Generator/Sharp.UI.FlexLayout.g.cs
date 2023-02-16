﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.FlexLayout</c> class.
    /// </summary>
    public partial class FlexLayout : Microsoft.Maui.Controls.FlexLayout, Sharp.UI.IFlexLayout, IMauiWrapper
    {
        // ----- constructors -----

        public FlexLayout() { }

        public FlexLayout(out FlexLayout flexLayout) 
        {
            flexLayout = this;
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public FlexLayout(System.Action<FlexLayout> configure) 
        {
            configure(this);
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public FlexLayout(out FlexLayout flexLayout, System.Action<FlexLayout> configure) 
        {
            flexLayout = this;
            configure(this);
        }

        public void Add(Func<Sharp.UI.FlexLayout, Sharp.UI.FlexLayout> configure) { configure(this); }

        // ----- properties / events -----

        public new Sharp.UI.Style Style { get => new Sharp.UI.Style(base.Style); set => base.Style = value.MauiObject; }
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
