﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{  
    /// <summary>
    /// A <c>Sharp.UI</c> class wrapping the sealed <c>Microsoft.Maui.Controls.TableSection</c> class.
    /// Use the <value>MauiObject</value> property to get the raw Maui object.
    /// </summary>
    public partial class TableSection : Sharp.UI.ITableSection, IMauiWrapper, ISealedMauiWrapper, IList<Microsoft.Maui.Controls.Cell>
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.TableSection MauiObject { get => (Microsoft.Maui.Controls.TableSection)_maui_RawObject; protected set => _maui_RawObject = value; }

        // ----- constructors -----

        public TableSection(Microsoft.Maui.Controls.TableSection tableSection)
        {
            MauiObject = tableSection;
        }

        public TableSection()
        {
            MauiObject = new Microsoft.Maui.Controls.TableSection();
        }

        // ----- operators -----

        public static implicit operator TableSection(Microsoft.Maui.Controls.TableSection mauiObject) => new TableSection(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.TableSection(TableSection obj) => obj.MauiObject;

        // ----- collection container -----

        public int Count => this.MauiObject.Count;
        public Microsoft.Maui.Controls.Cell this[int index] { get => this.MauiObject[index]; set => this.MauiObject[index] = value; }
        public bool IsReadOnly => false;
        public void Clear() => this.MauiObject.Clear();
        public bool Contains(Microsoft.Maui.Controls.Cell item) => this.MauiObject.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.Cell[] array, int arrayIndex) => this.MauiObject.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.Cell> GetEnumerator() => this.MauiObject.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.Cell item) => this.MauiObject.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.Cell item) => this.MauiObject.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.Cell item) => this.MauiObject.Remove(item);
        public void RemoveAt(int index) => this.MauiObject.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.MauiObject.GetEnumerator();

        public void Add(Func<Sharp.UI.TableSection, Sharp.UI.TableSection> configure) { configure(this); }

        public void Add(Microsoft.Maui.Controls.Cell cell) => this.MauiObject.Add(cell);

        public void Add(Func<IEnumerable<Microsoft.Maui.Controls.Cell>> builder)
        {
            var items = builder();
            foreach (var item in items)
                this.MauiObject.Add(item);
        }

        public void Add(Action<IList<Microsoft.Maui.Controls.Cell>> builder)
        {
            List<Microsoft.Maui.Controls.Cell> items = new List<Microsoft.Maui.Controls.Cell>();
            builder(items);
            foreach (var item in items)
                this.MauiObject.Add(item);
        }

        // ----- sealed bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty TitleProperty => Microsoft.Maui.Controls.TableSectionBase.TitleProperty;
        public static Microsoft.Maui.Controls.BindableProperty TextColorProperty => Microsoft.Maui.Controls.TableSectionBase.TextColorProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public string Title { get => MauiObject.Title; set => MauiObject.Title = value; }
        public Microsoft.Maui.Graphics.Color TextColor { get => MauiObject.TextColor; set => MauiObject.TextColor = value; }
        public Microsoft.Maui.Dispatching.IDispatcher Dispatcher { get => MauiObject.Dispatcher; }
        public object BindingContext { get => MauiObject.BindingContext; set => MauiObject.BindingContext = MauiWrapper.Value<object>(value); }
        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged { add => MauiObject.CollectionChanged += value; remove => MauiObject.CollectionChanged -= value; }
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
