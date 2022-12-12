﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class Geometry : Microsoft.Maui.Controls.Shapes.Geometry, Sharp.UI.IGeometry, IWrappedBindableObject
    {
        // ----- constructors -----

        public Geometry() { }

        public Geometry(out Geometry geometry) 
        {
            geometry = this;
        }

        public Geometry(Action<Geometry> configure) 
        {
            configure(this);
        }

        public Geometry(out Geometry geometry, Action<Geometry> configure) 
        {
            geometry = this;
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