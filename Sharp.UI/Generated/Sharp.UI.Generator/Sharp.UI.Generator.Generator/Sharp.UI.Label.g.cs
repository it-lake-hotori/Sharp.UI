﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.Label</c> class.
    /// </summary>
    public partial class Label : Microsoft.Maui.Controls.Label, Sharp.UI.ILabel, IMauiWrapper, IEnumerable
    {
        // ----- maui object -----

        public Sharp.UI.Label MauiObject { get => this; }

        // ----- constructors -----

        public Label() { }

        public Label(out Label label) 
        {
            label = this;
        }

        public Label(System.Action<Label> configure) 
        {
            configure(this);
        }

        public Label(out Label label, System.Action<Label> configure) 
        {
            label = this;
            configure(this);
        }

        public Label(string text) 
        {  
            this.Text = text;
        }

        public Label(string text, out Label label) 
        {  
            this.Text = text;;
            label = this;
        }

        public Label(string text, System.Action<Label> configure) 
        {  
            this.Text = text;
            configure(this);
        }

        public Label(string text, out Label label, System.Action<Label> configure) 
        {  
            this.Text = text;
            label = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Text; }

        public void Add(string text) => this.Text = text;

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
