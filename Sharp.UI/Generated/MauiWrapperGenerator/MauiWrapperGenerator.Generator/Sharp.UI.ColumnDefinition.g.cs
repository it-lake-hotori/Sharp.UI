﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class ColumnDefinition : Sharp.UI.IColumnDefinition, ISealedMauiWrapper, IWrappedBindableObject
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.ColumnDefinition MauiObject { get => (Microsoft.Maui.Controls.ColumnDefinition)_maui_RawObject; set => _maui_RawObject = value; }

        // ----- constructors -----
        

        internal ColumnDefinition(Microsoft.Maui.Controls.ColumnDefinition columnDefinition)
        {
            MauiObject = columnDefinition;
        }

        public ColumnDefinition()
        {
            MauiObject = new Microsoft.Maui.Controls.ColumnDefinition();
        }

        // ----- operators -----

        public static implicit operator ColumnDefinition(Microsoft.Maui.Controls.ColumnDefinition mauiObject) => new ColumnDefinition(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.ColumnDefinition(ColumnDefinition obj) => obj.MauiObject;

        // ----- bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty WidthProperty => Microsoft.Maui.Controls.ColumnDefinition.WidthProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public Microsoft.Maui.GridLength Width { get => MauiObject.Width; set => MauiObject.Width = value; }
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

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669
