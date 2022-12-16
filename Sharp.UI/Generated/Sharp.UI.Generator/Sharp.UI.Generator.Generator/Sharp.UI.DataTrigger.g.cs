﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class wrapping the sealed <c>Microsoft.Maui.Controls.DataTrigger</c> class.
    /// Use the <value>MauiObject</value> property to get the raw Maui object.
    /// </summary>
    public partial class DataTrigger : Sharp.UI.IDataTrigger, IMauiWrapper, ISealedMauiWrapper, IList<Microsoft.Maui.Controls.Setter>
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.DataTrigger MauiObject { get => (Microsoft.Maui.Controls.DataTrigger)_maui_RawObject; protected set => _maui_RawObject = value; }

        // ----- constructors -----

        public DataTrigger(Microsoft.Maui.Controls.DataTrigger dataTrigger)
        {
            MauiObject = dataTrigger;
        }

        // ----- operators -----

        public static implicit operator DataTrigger(Microsoft.Maui.Controls.DataTrigger mauiObject) => new DataTrigger(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.DataTrigger(DataTrigger obj) => obj.MauiObject;

        // ----- collection container -----

        public int Count => this.MauiObject.Setters.Count;
        public Microsoft.Maui.Controls.Setter this[int index] { get => this.MauiObject.Setters[index]; set => this.MauiObject.Setters[index] = value; }
        public bool IsReadOnly => false;
        public void Add(Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.Add(item);
        public void Clear() => this.MauiObject.Setters.Clear();
        public bool Contains(Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.Setter[] array, int arrayIndex) => this.MauiObject.Setters.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.Setter> GetEnumerator() => this.MauiObject.Setters.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.Setter item) => this.MauiObject.Setters.Remove(item);
        public void RemoveAt(int index) => this.MauiObject.Setters.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.MauiObject.Setters.GetEnumerator();

        // ----- sealed bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public Microsoft.Maui.Controls.BindingBase Binding { get => MauiObject.Binding; set => MauiObject.Binding = value; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter> Setters { get => MauiObject.Setters; }
        public object Value { get => MauiObject.Value; set => MauiObject.Value = MauiWrapper.Value<object>(value); }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction> EnterActions { get => MauiObject.EnterActions; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction> ExitActions { get => MauiObject.ExitActions; }
        public bool IsSealed { get => MauiObject.IsSealed; }
        public System.Type TargetType { get => MauiObject.TargetType; }
        public Microsoft.Maui.Dispatching.IDispatcher Dispatcher { get => MauiObject.Dispatcher; }
        public object BindingContext { get => MauiObject.BindingContext; set => MauiObject.BindingContext = MauiWrapper.Value<object>(value); }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add => MauiObject.PropertyChanged += value; remove => MauiObject.PropertyChanged -= value; }
        public event Microsoft.Maui.Controls.PropertyChangingEventHandler PropertyChanging { add => MauiObject.PropertyChanging += value; remove => MauiObject.PropertyChanging -= value; }
        public event System.EventHandler BindingContextChanged { add => MauiObject.BindingContextChanged += value; remove => MauiObject.BindingContextChanged -= value; }

        // ----- set value method -----

        public void SetValue(Microsoft.Maui.Controls.BindableProperty property, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            MauiObject.SetValue(property, mauiValue);
        }

        public void SetValue(Microsoft.Maui.Controls.BindablePropertyKey propertyKey, object value)
        {
            var mauiValue = MauiWrapper.Value<object>(value);
            MauiObject.SetValue(propertyKey, mauiValue);
        }
    }
}

#pragma warning restore CS8669
