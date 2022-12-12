﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class AbsoluteLayout : Microsoft.Maui.Controls.AbsoluteLayout, Sharp.UI.IAbsoluteLayout, IWrappedBindableObject
    {
        // ----- constructors -----

        public AbsoluteLayout() { }

        public AbsoluteLayout(out AbsoluteLayout absoluteLayout) 
        {
            absoluteLayout = this;
        }

        public AbsoluteLayout(Action<AbsoluteLayout> configure) 
        {
            configure(this);
        }

        public AbsoluteLayout(out AbsoluteLayout absoluteLayout, Action<AbsoluteLayout> configure) 
        {
            absoluteLayout = this;
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
