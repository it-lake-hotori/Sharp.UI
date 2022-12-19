﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.TimePicker</c> class.
    /// </summary>
    public partial class TimePicker : Microsoft.Maui.Controls.TimePicker, Sharp.UI.ITimePicker, IMauiWrapper
    {
        // ----- maui object -----

        public Sharp.UI.TimePicker MauiObject { get => this; }

        // ----- constructors -----

        public TimePicker() { }

        public TimePicker(out TimePicker timePicker) 
        {
            timePicker = this;
        }

        public TimePicker(System.Action<TimePicker> configure) 
        {
            configure(this);
        }

        public TimePicker(out TimePicker timePicker, System.Action<TimePicker> configure) 
        {
            timePicker = this;
            configure(this);
        }

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