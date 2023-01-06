﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.Picker</c> class.
    /// </summary>
    public partial class Picker : Microsoft.Maui.Controls.Picker, Sharp.UI.IPicker, IMauiWrapper
    {
        // ----- maui object -----

        public Sharp.UI.Picker MauiObject { get => this; }

        // ----- constructors -----

        public Picker() { }

        public Picker(out Picker picker) 
        {
            picker = this;
        }

        public Picker(System.Action<Picker> configure) 
        {
            configure(this);
        }

        public Picker(out Picker picker, System.Action<Picker> configure) 
        {
            picker = this;
            configure(this);
        }

        public Picker(string title, out Picker picker) : this(title)
        {
            picker = this;
        }

        public Picker(string title, System.Action<Picker> configure) : this(title)
        {
            configure(this);
        }

        public Picker(string title, out Picker picker, System.Action<Picker> configure) : this(title)
        {
            picker = this;
            configure(this);
        }

        // ----- properties / events -----

        public new object SelectedItem { get => base.SelectedItem; set => base.SelectedItem = MauiWrapper.Value<object>(value); }
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
