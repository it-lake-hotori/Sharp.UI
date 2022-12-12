﻿//
// <auto-generated>
//

#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class VisualStateGroup : Sharp.UI.IVisualStateGroup, ISealedMauiWrapper, IList<Microsoft.Maui.Controls.VisualState>
    {
        // ----- maui object -----

        public object _maui_RawObject { get; set; }

        public Microsoft.Maui.Controls.VisualStateGroup MauiObject { get => (Microsoft.Maui.Controls.VisualStateGroup)_maui_RawObject; set => _maui_RawObject = value; }

        // ----- constructors -----

        protected VisualStateGroup(Microsoft.Maui.Controls.VisualStateGroup visualStateGroup)
        {
            MauiObject = visualStateGroup;
        }

        public VisualStateGroup()
        {
            MauiObject = new Microsoft.Maui.Controls.VisualStateGroup();
        }

        public VisualStateGroup(out VisualStateGroup visualStateGroup) : this()
        {
            visualStateGroup = this;
        }

        public VisualStateGroup(Action<VisualStateGroup> configure) : this()
        {
            configure(this);
        }

        public VisualStateGroup(out VisualStateGroup visualStateGroup, Action<VisualStateGroup> configure) : this()
        {
            visualStateGroup = this;
            configure(this);
        }

        // ----- operators -----

        public static implicit operator VisualStateGroup(Microsoft.Maui.Controls.VisualStateGroup mauiObject) => new VisualStateGroup(mauiObject);
        public static implicit operator Microsoft.Maui.Controls.VisualStateGroup(VisualStateGroup obj) => obj.MauiObject;

        // ----- collection container -----

        public int Count => this.MauiObject.States.Count;
        public Microsoft.Maui.Controls.VisualState this[int index] { get => this.MauiObject.States[index]; set => this.MauiObject.States[index] = value; }
        public bool IsReadOnly => false;
        public void Add(Microsoft.Maui.Controls.VisualState item) => this.MauiObject.States.Add(item);
        public void Clear() => this.MauiObject.States.Clear();
        public bool Contains(Microsoft.Maui.Controls.VisualState item) => this.MauiObject.States.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.VisualState[] array, int arrayIndex) => this.MauiObject.States.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.VisualState> GetEnumerator() => this.MauiObject.States.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.VisualState item) => this.MauiObject.States.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.VisualState item) => this.MauiObject.States.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.VisualState item) => this.MauiObject.States.Remove(item);
        public void RemoveAt(int index) => this.MauiObject.States.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.MauiObject.States.GetEnumerator();

        // ----- bindable properties -----


        // ----- properties / events -----

        public System.Type TargetType { get => MauiObject.TargetType; set => MauiObject.TargetType = value; }
        public string Name { get => MauiObject.Name; set => MauiObject.Name = value; }
        public System.Collections.Generic.IList<Microsoft.Maui.Controls.VisualState> States { get => MauiObject.States; }
        public Microsoft.Maui.Controls.VisualState CurrentState { get => MauiObject.CurrentState; }
    }
}

#pragma warning restore CS8669
