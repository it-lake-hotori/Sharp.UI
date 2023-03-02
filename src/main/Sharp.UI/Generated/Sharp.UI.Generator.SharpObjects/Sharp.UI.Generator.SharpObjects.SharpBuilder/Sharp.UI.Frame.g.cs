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

    public partial class Frame : IEnumerable
	{

        // ----- constructors -----

        public Frame() { }

        public Frame(out Frame frame) 
        {
            frame = this;
        }

        public Frame(System.Func<Frame, Frame> configure) 
        {
            configure(this);
        }

        public Frame(out Frame frame, System.Func<Frame, Frame> configure) 
        {
            frame = this;
            configure(this);
        }

        // ----- single item container -----

        IEnumerator IEnumerable.GetEnumerator() { yield return this.Content; }
        public void Add(Microsoft.Maui.Controls.View content) => this.Content = content;

    }
}

#nullable restore
