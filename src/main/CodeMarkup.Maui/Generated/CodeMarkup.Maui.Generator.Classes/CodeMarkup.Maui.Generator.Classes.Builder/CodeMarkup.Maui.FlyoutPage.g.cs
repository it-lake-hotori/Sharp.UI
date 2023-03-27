﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Classes.Builder
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace CodeMarkup.Maui
{
	using CodeMarkup.Maui;

    public partial class FlyoutPage : IEnumerable
	{

        // ----- constructors -----

        public FlyoutPage() { }

        public FlyoutPage(out FlyoutPage flyoutPage) 
        {
            flyoutPage = this;
        }

        public FlyoutPage(System.Func<FlyoutPage, FlyoutPage> configure) 
        {
            configure(this);
        }

        public FlyoutPage(out FlyoutPage flyoutPage, System.Func<FlyoutPage, FlyoutPage> configure) 
        {
            flyoutPage = this;
            configure(this);
        }

        // ----- single item container -----

        IEnumerator IEnumerable.GetEnumerator() { yield return this.Detail; }
        public void Add(Microsoft.Maui.Controls.Page detail) => this.Detail = detail;

    }
}

#nullable restore