﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class TabbedPage : Microsoft.Maui.Controls.TabbedPage, Sharp.UI.ITabbedPage, IList<Microsoft.Maui.Controls.Page>, IWrappedBindableObject
    {
        // ----- constructors -----

        public TabbedPage() { }

        public TabbedPage(out TabbedPage tabbedPage) 
        {
            tabbedPage = this;
        }

        public TabbedPage(Action<TabbedPage> configure) 
        {
            configure(this);
        }

        public TabbedPage(out TabbedPage tabbedPage, Action<TabbedPage> configure) 
        {
            tabbedPage = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.Children.Count;
        public Microsoft.Maui.Controls.Page this[int index] { get => this.Children[index]; set => this.Children[index] = value; }
        public bool IsReadOnly => false;
        public void Add(Microsoft.Maui.Controls.Page item) => this.Children.Add(item);
        public void Clear() => this.Children.Clear();
        public bool Contains(Microsoft.Maui.Controls.Page item) => this.Children.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.Page[] array, int arrayIndex) => this.Children.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.Page> GetEnumerator() => this.Children.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.Page item) => this.Children.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.Page item) => this.Children.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.Page item) => this.Children.Remove(item);
        public void RemoveAt(int index) => this.Children.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Children.GetEnumerator();

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
