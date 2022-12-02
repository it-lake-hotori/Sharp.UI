﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class OrientationStateTrigger : Sharp.UI.IOrientationStateTrigger, ISealedMauiWrapper, IWrappedBindableObject
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.OrientationStateTrigger MauiObject { get => (Microsoft.Maui.Controls.OrientationStateTrigger)_maui_RawObject; set => _maui_RawObject = value; }

        // ----- constructors -----
        

        internal OrientationStateTrigger(Microsoft.Maui.Controls.OrientationStateTrigger orientationStateTrigger)
        {
            MauiObject = orientationStateTrigger;
        }

        public OrientationStateTrigger()
        {
            MauiObject = new Microsoft.Maui.Controls.OrientationStateTrigger();
        }

        // ----- operators -----

        public static implicit operator OrientationStateTrigger(Microsoft.Maui.Controls.OrientationStateTrigger mauiObject) => new OrientationStateTrigger(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.OrientationStateTrigger(OrientationStateTrigger obj) => obj.MauiObject;

        // ----- bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty OrientationProperty => Microsoft.Maui.Controls.OrientationStateTrigger.OrientationProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public Microsoft.Maui.Devices.DisplayOrientation Orientation { get => MauiObject.Orientation; set => MauiObject.Orientation = value; }
        public bool IsActive { get => MauiObject.IsActive; }
        public bool IsAttached { get => MauiObject.IsAttached; }
        public event System.EventHandler IsActiveChanged { add => MauiObject.IsActiveChanged += value; remove => MauiObject.IsActiveChanged -= value; }
        public Microsoft.Maui.Dispatching.IDispatcher Dispatcher { get => MauiObject.Dispatcher; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add => MauiObject.PropertyChanged += value; remove => MauiObject.PropertyChanged -= value; }
        public event Microsoft.Maui.Controls.PropertyChangingEventHandler PropertyChanging { add => MauiObject.PropertyChanging += value; remove => MauiObject.PropertyChanging -= value; }
        public event System.EventHandler BindingContextChanged { add => MauiObject.BindingContextChanged += value; remove => MauiObject.BindingContextChanged -= value; }
        // ----- binding context -----

        public object BindingContext
        {
            get => MauiObject.BindingContext;
            set
            {
                var mauiObject = MauiWrapper.GetObject<object>(value);
                MauiObject.BindingContext = mauiObject;
            }
        }
        

    }
}

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669