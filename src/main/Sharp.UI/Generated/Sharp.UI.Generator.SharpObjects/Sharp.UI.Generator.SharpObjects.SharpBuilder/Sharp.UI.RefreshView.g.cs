﻿//
// <auto-generated>
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace Sharp.UI
{
	using Sharp.UI;

    public partial class RefreshView : IEnumerable
	{

        // ----- constructors -----

        public RefreshView() { }

        public RefreshView(out RefreshView refreshView) 
        {
            refreshView = this;
        }

        public RefreshView(System.Func<RefreshView, RefreshView> configure) 
        {
            configure(this);
        }

        public RefreshView(out RefreshView refreshView, System.Func<RefreshView, RefreshView> configure) 
        {
            refreshView = this;
            configure(this);
        }

        // ----- single item container -----

        IEnumerator IEnumerable.GetEnumerator() { yield return this.Content; }
        public void Add(Microsoft.Maui.Controls.View content) => this.Content = content;

    }
}

#nullable restore
