﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.CheckBox</c> class.
    /// </summary>
    public partial class CheckBox : Microsoft.Maui.Controls.CheckBox, Sharp.UI.ICheckBox, IMauiWrapper
    {
        // ----- maui object -----

        public Sharp.UI.CheckBox MauiObject { get => this; }

        // ----- constructors -----

        public CheckBox() { }

        public CheckBox(out CheckBox checkBox) 
        {
            checkBox = this;
        }

        public CheckBox(System.Action<CheckBox> configure) 
        {
            configure(this);
        }

        public CheckBox(out CheckBox checkBox, System.Action<CheckBox> configure) 
        {
            checkBox = this;
            configure(this);
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
