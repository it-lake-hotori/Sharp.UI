﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class inheriting from the <c>Microsoft.Maui.Controls.DataTrigger</c> class.
    /// </summary>
    public partial class DataTrigger : Microsoft.Maui.Controls.DataTrigger, Sharp.UI.IDataTrigger, IMauiWrapper, IList<Microsoft.Maui.Controls.Setter>
    {
        // ----- maui object -----

        public Sharp.UI.DataTrigger MauiObject { get => this; }

        // ----- constructors -----

        public DataTrigger(System.Type type, out DataTrigger dataTrigger) : this(type)
        {
            dataTrigger = this;
        }

        public DataTrigger(System.Type type, System.Action<DataTrigger> configure) : this(type)
        {
            configure(this);
        }

        public DataTrigger(System.Type type, out DataTrigger dataTrigger, System.Action<DataTrigger> configure) : this(type)
        {
            dataTrigger = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.Setters.Count;
        public Microsoft.Maui.Controls.Setter this[int index] { get => this.Setters[index]; set => this.Setters[index] = value; }
        public bool IsReadOnly => false;
        public void Add(Microsoft.Maui.Controls.Setter item) => this.Setters.Add(item);
        public void Clear() => this.Setters.Clear();
        public bool Contains(Microsoft.Maui.Controls.Setter item) => this.Setters.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.Setter[] array, int arrayIndex) => this.Setters.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.Setter> GetEnumerator() => this.Setters.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.Setter item) => this.Setters.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.Setter item) => this.Setters.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.Setter item) => this.Setters.Remove(item);
        public void RemoveAt(int index) => this.Setters.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Setters.GetEnumerator();

        // ----- properties / events -----

        public new object Value { get => base.Value; set => base.Value = MauiWrapper.Value<object>(value); }
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
