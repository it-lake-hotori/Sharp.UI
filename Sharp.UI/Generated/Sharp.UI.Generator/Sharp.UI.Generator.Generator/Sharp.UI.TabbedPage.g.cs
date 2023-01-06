﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.TabbedPage</c> class.
    /// </summary>
    public partial class TabbedPage : Microsoft.Maui.Controls.TabbedPage, Sharp.UI.ITabbedPage, IMauiWrapper, IList<Microsoft.Maui.Controls.Page>
    {
        // ----- maui object -----

        public Sharp.UI.TabbedPage MauiObject { get => this; }

        // ----- constructors -----

        public TabbedPage() { }

        public TabbedPage(out TabbedPage tabbedPage) 
        {
            tabbedPage = this;
        }

        public TabbedPage(System.Action<TabbedPage> configure) 
        {
            configure(this);
        }

        public TabbedPage(out TabbedPage tabbedPage, System.Action<TabbedPage> configure) 
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

        // ----- properties / events -----

        public new object SelectedItem { get => base.SelectedItem; set => base.SelectedItem = MauiWrapper.Value<object>(value); }
        public new object BindingContext { get => base.BindingContext; set => base.BindingContext = MauiWrapper.Value<object>(value); }

        // ----- set value method -----

        public new void SetValue(Microsoft.Maui.Controls.BindableProperty property, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(property, mauiValue);
        }

        public new void SetValue(Microsoft.Maui.Controls.BindablePropertyKey propertyKey, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            ((Microsoft.Maui.Controls.BindableObject)this).SetValue(propertyKey, mauiValue);
        }
    }
}

#pragma warning restore CS8669
