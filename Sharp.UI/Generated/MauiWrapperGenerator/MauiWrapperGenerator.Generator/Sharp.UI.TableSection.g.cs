﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class TableSection : Sharp.UI.ITableSection, ISealedMauiWrapper, IList<Microsoft.Maui.Controls.Cell>, IWrappedBindableObject
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.TableSection MauiObject { get => (Microsoft.Maui.Controls.TableSection)_maui_RawObject; set => _maui_RawObject = value; }

        // ----- constructors -----
        

        internal TableSection(Microsoft.Maui.Controls.TableSection tableSection)
        {
            MauiObject = tableSection;
        }

        public TableSection()
        {
            MauiObject = new Microsoft.Maui.Controls.TableSection();
        }


        public TableSection(out TableSection tableSection) : this()
        {
            tableSection = this;
        }

        public TableSection(Action<TableSection> configure) : this()
        {
            configure(this);
        }

        public TableSection(out TableSection tableSection, Action<TableSection> configure) : this()
        {
            tableSection = this;
            configure(this);
        }

        public TableSection(string title) : this()
        {  
            this.Title = title;
        }

        public TableSection(string title, out TableSection tableSection) : this()
        {  
            this.Title = title;;
            tableSection = this;
        }

        public TableSection(string title, Action<TableSection> configure) : this()
        {  
            this.Title = title;
            configure(this);
        }

        public TableSection(string title, out TableSection tableSection, Action<TableSection> configure) : this()
        {  
            this.Title = title;
            tableSection = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator TableSection(Microsoft.Maui.Controls.TableSection mauiObject) => new TableSection(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.TableSection(TableSection obj) => obj.MauiObject;

        // ----- collection container -----

        public int Count => this.MauiObject.Count;
        public Microsoft.Maui.Controls.Cell this[int index] { get => this.MauiObject[index]; set => this.MauiObject[index] = value; }
        public bool IsReadOnly => false;
        public void Add(Microsoft.Maui.Controls.Cell item) => this.MauiObject.Add(item);
        public void Clear() => this.MauiObject.Clear();
        public bool Contains(Microsoft.Maui.Controls.Cell item) => this.MauiObject.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.Cell[] array, int arrayIndex) => this.MauiObject.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.Cell> GetEnumerator() => this.MauiObject.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.Cell item) => this.MauiObject.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.Cell item) => this.MauiObject.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.Cell item) => this.MauiObject.Remove(item);
        public void RemoveAt(int index) => this.MauiObject.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.MauiObject.GetEnumerator();

        // ----- bindable properties -----

        public static Microsoft.Maui.Controls.BindableProperty TitleProperty => Microsoft.Maui.Controls.TableSectionBase.TitleProperty;
        public static Microsoft.Maui.Controls.BindableProperty TextColorProperty => Microsoft.Maui.Controls.TableSectionBase.TextColorProperty;
        public static Microsoft.Maui.Controls.BindableProperty BindingContextProperty => Microsoft.Maui.Controls.BindableObject.BindingContextProperty;

        // ----- properties / events -----

        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged { add => MauiObject.CollectionChanged += value; remove => MauiObject.CollectionChanged -= value; }
        public string Title { get => MauiObject.Title; set => MauiObject.Title = value; }
        public Microsoft.Maui.Graphics.Color TextColor { get => MauiObject.TextColor; set => MauiObject.TextColor = value; }
        public Microsoft.Maui.Dispatching.IDispatcher Dispatcher { get => MauiObject.Dispatcher; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add => MauiObject.PropertyChanged += value; remove => MauiObject.PropertyChanged -= value; }
        public event Microsoft.Maui.Controls.PropertyChangingEventHandler PropertyChanging { add => MauiObject.PropertyChanging += value; remove => MauiObject.PropertyChanging -= value; }
        public event System.EventHandler BindingContextChanged { add => MauiObject.BindingContextChanged += value; remove => MauiObject.BindingContextChanged -= value; }
        // ----- binding context -----

        public object BindingContext
        {
            get => MauiObject.BindingContext;
            set
            {
                var mauiObject = MauiWrapper.GetObject<object>(value);
                MauiObject.BindingContext = mauiObject;
            }
        }
        

    }
}

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669
