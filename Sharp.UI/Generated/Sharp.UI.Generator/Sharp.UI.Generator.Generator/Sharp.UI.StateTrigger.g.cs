﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class wrapping the sealed <c>Microsoft.Maui.Controls.StateTrigger</c> class.
    /// Use the <value>MauiObject</value> property to get the raw Maui object.
    /// </summary>
    public partial class StateTrigger : Sharp.UI.IStateTrigger, IMauiWrapper, ISealedMauiWrapper
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.StateTrigger MauiObject { get => (Microsoft.Maui.Controls.StateTrigger)_maui_RawObject; protected set => _maui_RawObject = value; }

        // ----- constructors -----

        public StateTrigger(Microsoft.Maui.Controls.StateTrigger stateTrigger)
        {
            MauiObject = stateTrigger;
        }

        public StateTrigger()
        {
            MauiObject = new Microsoft.Maui.Controls.StateTrigger();
        }

        public StateTrigger(out StateTrigger stateTrigger) : this()
        {
            stateTrigger = this;
        }

        public StateTrigger(System.Action<StateTrigger> configure) : this()
        {
            configure(this);
        }

        public StateTrigger(out StateTrigger stateTrigger, System.Action<StateTrigger> configure) : this()
        {
            stateTrigger = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator StateTrigger(Microsoft.Maui.Controls.StateTrigger mauiObject) => new StateTrigger(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.StateTrigger(StateTrigger obj) => obj.MauiObject;

        // ----- sealed bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty IsActiveProperty => Microsoft.Maui.Controls.StateTrigger.IsActiveProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public bool IsActive { get => MauiObject.IsActive; set => MauiObject.IsActive = value; }
        public bool IsAttached { get => MauiObject.IsAttached; }
        public Microsoft.Maui.Dispatching.IDispatcher Dispatcher { get => MauiObject.Dispatcher; }
        public object BindingContext { get => MauiObject.BindingContext; set => MauiObject.BindingContext = MauiWrapper.Value<object>(value); }
        public event System.EventHandler IsActiveChanged { add => MauiObject.IsActiveChanged += value; remove => MauiObject.IsActiveChanged -= value; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add => MauiObject.PropertyChanged += value; remove => MauiObject.PropertyChanged -= value; }
        public event Microsoft.Maui.Controls.PropertyChangingEventHandler PropertyChanging { add => MauiObject.PropertyChanging += value; remove => MauiObject.PropertyChanging -= value; }
        public event System.EventHandler BindingContextChanged { add => MauiObject.BindingContextChanged += value; remove => MauiObject.BindingContextChanged -= value; }

        // ----- set value method -----

        public void SetValue(Microsoft.Maui.Controls.BindableProperty property, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            MauiObject.SetValue(property, mauiValue);
        }

        public void SetValue(Microsoft.Maui.Controls.BindablePropertyKey propertyKey, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            MauiObject.SetValue(propertyKey, mauiValue);
        }
    }
}

#pragma warning restore CS8669