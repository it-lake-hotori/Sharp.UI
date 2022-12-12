﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class PanGestureRecognizer : Microsoft.Maui.Controls.PanGestureRecognizer, Sharp.UI.IPanGestureRecognizer, IWrappedBindableObject
    {
        // ----- constructors -----

        public PanGestureRecognizer() { }

        public PanGestureRecognizer(out PanGestureRecognizer panGestureRecognizer) 
        {
            panGestureRecognizer = this;
        }

        public PanGestureRecognizer(Action<PanGestureRecognizer> configure) 
        {
            configure(this);
        }

        public PanGestureRecognizer(out PanGestureRecognizer panGestureRecognizer, Action<PanGestureRecognizer> configure) 
        {
            panGestureRecognizer = this;
            configure(this);
        }

        // ----- binding context -----

        public new object BindingContext
        {
            get => base.BindingContext;
            set
            {
                var mauiObject = MauiWrapper.GetObject<object>(value);
                base.BindingContext = mauiObject;
            }
        }
        

    }
}

#pragma warning restore CS8669
