﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class RowDefinition : Sharp.UI.IRowDefinition, ISealedMauiWrapper, IWrappedBindableObject
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.RowDefinition MauiObject { get => (Microsoft.Maui.Controls.RowDefinition)_maui_RawObject; set => _maui_RawObject = value; }

        // ----- constructors -----

        protected RowDefinition(Microsoft.Maui.Controls.RowDefinition rowDefinition)
        {
            MauiObject = rowDefinition;
        }

        public RowDefinition()
        {
            MauiObject = new Microsoft.Maui.Controls.RowDefinition();
        }

        public RowDefinition(out RowDefinition rowDefinition) : this()
        {
            rowDefinition = this;
        }

        public RowDefinition(Action<RowDefinition> configure) : this()
        {
            configure(this);
        }

        public RowDefinition(out RowDefinition rowDefinition, Action<RowDefinition> configure) : this()
        {
            rowDefinition = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator RowDefinition(Microsoft.Maui.Controls.RowDefinition mauiObject) => new RowDefinition(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.RowDefinition(RowDefinition obj) => obj.MauiObject;

        // ----- bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty HeightProperty => Microsoft.Maui.Controls.RowDefinition.HeightProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public Microsoft.Maui.GridLength Height { get => MauiObject.Height; set => MauiObject.Height = value; }
        public event System.EventHandler SizeChanged { add => MauiObject.SizeChanged += value; remove => MauiObject.SizeChanged -= value; }
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

#pragma warning restore CS8669
