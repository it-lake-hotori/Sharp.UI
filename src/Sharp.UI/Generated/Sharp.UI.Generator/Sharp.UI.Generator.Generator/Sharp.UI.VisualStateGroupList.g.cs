﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.VisualStateGroupList</c> class.
    /// </summary>
    public partial class VisualStateGroupList : Microsoft.Maui.Controls.VisualStateGroupList, Sharp.UI.IVisualStateGroupList, IMauiWrapper, IList<Microsoft.Maui.Controls.VisualStateGroup>
    {
        // ----- constructors -----

        public VisualStateGroupList() { }

        public VisualStateGroupList(out VisualStateGroupList visualStateGroupList) 
        {
            visualStateGroupList = this;
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public VisualStateGroupList(System.Action<VisualStateGroupList> configure) 
        {
            configure(this);
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public VisualStateGroupList(out VisualStateGroupList visualStateGroupList, System.Action<VisualStateGroupList> configure) 
        {
            visualStateGroupList = this;
            configure(this);
        }

        public void Add(Func<Sharp.UI.VisualStateGroupList, Sharp.UI.VisualStateGroupList> configure) { configure(this); }

        public void Add(Func<IEnumerable<Microsoft.Maui.Controls.VisualStateGroup>> builder)
        {
            var items = builder();
            foreach (var item in items)
                base.Add(item);
        }

        public void Add(Action<IList<Microsoft.Maui.Controls.VisualStateGroup>> builder)
        {
            List<Microsoft.Maui.Controls.VisualStateGroup> items = new List<Microsoft.Maui.Controls.VisualStateGroup>();
            builder(items);
            foreach (var item in items)
                base.Add(item);
        }

        // ----- properties / events -----


    }
}

#pragma warning restore CS8669
