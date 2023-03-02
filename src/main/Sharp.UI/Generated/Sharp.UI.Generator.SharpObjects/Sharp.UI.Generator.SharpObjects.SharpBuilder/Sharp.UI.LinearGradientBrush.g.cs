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

    public partial class LinearGradientBrush : IList<Microsoft.Maui.Controls.GradientStop>
	{

        // ----- constructors -----

        public LinearGradientBrush() { }

        public LinearGradientBrush(out LinearGradientBrush linearGradientBrush) 
        {
            linearGradientBrush = this;
        }

        public LinearGradientBrush(System.Func<LinearGradientBrush, LinearGradientBrush> configure) 
        {
            configure(this);
        }

        public LinearGradientBrush(out LinearGradientBrush linearGradientBrush, System.Func<LinearGradientBrush, LinearGradientBrush> configure) 
        {
            linearGradientBrush = this;
            configure(this);
        }

        public LinearGradientBrush(Microsoft.Maui.Graphics.Point startPoint, Microsoft.Maui.Graphics.Point endPoint, out LinearGradientBrush linearGradientBrush) : this(startPoint, endPoint)
        {
            linearGradientBrush = this;
        }

        public LinearGradientBrush(Microsoft.Maui.Graphics.Point startPoint, Microsoft.Maui.Graphics.Point endPoint, System.Func<LinearGradientBrush, LinearGradientBrush> configure) : this(startPoint, endPoint)
        {
            configure(this);
        }

        public LinearGradientBrush(Microsoft.Maui.Graphics.Point startPoint, Microsoft.Maui.Graphics.Point endPoint, out LinearGradientBrush linearGradientBrush, System.Func<LinearGradientBrush, LinearGradientBrush> configure) : this(startPoint, endPoint)
        {
            linearGradientBrush = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.GradientStops.Count;
        public Microsoft.Maui.Controls.GradientStop this[int index] { get => this.GradientStops[index]; set => this.GradientStops[index] = value; }
        public bool IsReadOnly => false;
        public void Clear() => this.GradientStops.Clear();
        public bool Contains(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.GradientStop[] array, int arrayIndex) => this.GradientStops.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.GradientStop> GetEnumerator() => this.GradientStops.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Remove(item);
        public void RemoveAt(int index) => this.GradientStops.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.GradientStops.GetEnumerator();
        public void Add(Microsoft.Maui.Controls.GradientStop item) => this.GradientStops.Add(item);

    }
}

#nullable restore
