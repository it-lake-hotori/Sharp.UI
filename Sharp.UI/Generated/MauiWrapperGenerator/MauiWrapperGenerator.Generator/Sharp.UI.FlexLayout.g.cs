﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class FlexLayout : Microsoft.Maui.Controls.FlexLayout, Sharp.UI.IFlexLayout, IList<Microsoft.Maui.IView>, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public FlexLayout() { }


        public FlexLayout(out FlexLayout flexLayout) 
        {
            flexLayout = this;
        }

        public FlexLayout(Action<FlexLayout> configure) 
        {
            configure(this);
        }

        public FlexLayout(out FlexLayout flexLayout, Action<FlexLayout> configure) 
        {
            flexLayout = this;
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

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669
