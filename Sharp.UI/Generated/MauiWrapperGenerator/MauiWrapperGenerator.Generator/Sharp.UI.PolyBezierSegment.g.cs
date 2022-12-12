﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class PolyBezierSegment : Sharp.UI.IPolyBezierSegment, ISealedMauiWrapper, IWrappedBindableObject
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.Shapes.PolyBezierSegment MauiObject { get => (Microsoft.Maui.Controls.Shapes.PolyBezierSegment)_maui_RawObject; set => _maui_RawObject = value; }

        // ----- constructors -----

        protected PolyBezierSegment(Microsoft.Maui.Controls.Shapes.PolyBezierSegment polyBezierSegment)
        {
            MauiObject = polyBezierSegment;
        }

        public PolyBezierSegment()
        {
            MauiObject = new Microsoft.Maui.Controls.Shapes.PolyBezierSegment();
        }

        public PolyBezierSegment(out PolyBezierSegment polyBezierSegment) : this()
        {
            polyBezierSegment = this;
        }

        public PolyBezierSegment(Action<PolyBezierSegment> configure) : this()
        {
            configure(this);
        }

        public PolyBezierSegment(out PolyBezierSegment polyBezierSegment, Action<PolyBezierSegment> configure) : this()
        {
            polyBezierSegment = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator PolyBezierSegment(Microsoft.Maui.Controls.Shapes.PolyBezierSegment mauiObject) => new PolyBezierSegment(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.Shapes.PolyBezierSegment(PolyBezierSegment obj) => obj.MauiObject;

        // ----- bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty PointsProperty => Microsoft.Maui.Controls.Shapes.PolyBezierSegment.PointsProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public Microsoft.Maui.Controls.PointCollection Points { get => MauiObject.Points; set => MauiObject.Points = value; }
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
