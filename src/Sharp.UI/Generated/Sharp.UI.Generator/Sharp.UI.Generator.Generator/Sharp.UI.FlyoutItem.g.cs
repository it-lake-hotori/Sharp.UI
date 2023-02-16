﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.FlyoutItem</c> class.
    /// </summary>
    public partial class FlyoutItem : Microsoft.Maui.Controls.FlyoutItem, Sharp.UI.IFlyoutItem, IMauiWrapper, IList<Microsoft.Maui.Controls.ShellSection>
    {
        // ----- constructors -----

        public FlyoutItem() { }

        public FlyoutItem(out FlyoutItem flyoutItem) 
        {
            flyoutItem = this;
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public FlyoutItem(System.Action<FlyoutItem> configure) 
        {
            configure(this);
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public FlyoutItem(out FlyoutItem flyoutItem, System.Action<FlyoutItem> configure) 
        {
            flyoutItem = this;
            configure(this);
        }

        public FlyoutItem(Microsoft.Maui.Controls.FlyoutDisplayOptions displayOptions, out FlyoutItem flyoutItem) : this(displayOptions)
        {
            flyoutItem = this;
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public FlyoutItem(Microsoft.Maui.Controls.FlyoutDisplayOptions displayOptions, System.Action<FlyoutItem> configure) : this(displayOptions)
        {
            configure(this);
        }

        [Obsolete("This constructor is deprecated, use e=>e.FluentMethod(), inside curly braces.")]
        public FlyoutItem(Microsoft.Maui.Controls.FlyoutDisplayOptions displayOptions, out FlyoutItem flyoutItem, System.Action<FlyoutItem> configure) : this(displayOptions)
        {
            flyoutItem = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.Items.Count;
        public Microsoft.Maui.Controls.ShellSection this[int index] { get => this.Items[index]; set => this.Items[index] = value; }
        public bool IsReadOnly => false;
        public void Clear() => this.Items.Clear();
        public bool Contains(Microsoft.Maui.Controls.ShellSection item) => this.Items.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.ShellSection[] array, int arrayIndex) => this.Items.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.ShellSection> GetEnumerator() => this.Items.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.ShellSection item) => this.Items.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.ShellSection item) => this.Items.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.ShellSection item) => this.Items.Remove(item);
        public void RemoveAt(int index) => this.Items.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Items.GetEnumerator();

        public void Add(Func<Sharp.UI.FlyoutItem, Sharp.UI.FlyoutItem> configure) { configure(this); }

        public void Add(Microsoft.Maui.Controls.ShellSection shellSection) => this.Items.Add(shellSection);

        public void Add(Func<IEnumerable<Microsoft.Maui.Controls.ShellSection>> builder)
        {
            var items = builder();
            foreach (var item in items)
                this.Items.Add(item);
        }

        public void Add(Action<IList<Microsoft.Maui.Controls.ShellSection>> builder)
        {
            List<Microsoft.Maui.Controls.ShellSection> items = new List<Microsoft.Maui.Controls.ShellSection>();
            builder(items);
            foreach (var item in items)
                this.Items.Add(item);
        }

        // ----- properties / events -----

        public new Sharp.UI.Style Style { get => new Sharp.UI.Style(base.Style); set => base.Style = value.MauiObject; }
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
