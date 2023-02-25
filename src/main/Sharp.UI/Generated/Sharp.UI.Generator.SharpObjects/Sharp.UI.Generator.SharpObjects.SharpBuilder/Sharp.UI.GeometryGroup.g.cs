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

    public partial class GeometryGroup : IList<Microsoft.Maui.Controls.Shapes.Geometry>
	{

        // ----- constructors -----

        public GeometryGroup() { }

        public GeometryGroup(out GeometryGroup geometryGroup) 
        {
            geometryGroup = this;
        }

        public GeometryGroup(System.Action<GeometryGroup> configure) 
        {
            configure(this);
        }

        public GeometryGroup(out GeometryGroup geometryGroup, System.Action<GeometryGroup> configure) 
        {
            geometryGroup = this;
            configure(this);
        }

        // ----- collection container -----

        public int Count => this.Children.Count;
        public Microsoft.Maui.Controls.Shapes.Geometry this[int index] { get => this.Children[index]; set => this.Children[index] = value; }
        public bool IsReadOnly => false;
        public void Clear() => this.Children.Clear();
        public bool Contains(Microsoft.Maui.Controls.Shapes.Geometry item) => this.Children.Contains(item);
        public void CopyTo(Microsoft.Maui.Controls.Shapes.Geometry[] array, int arrayIndex) => this.Children.CopyTo(array, arrayIndex);
        public IEnumerator<Microsoft.Maui.Controls.Shapes.Geometry> GetEnumerator() => this.Children.GetEnumerator();
        public int IndexOf(Microsoft.Maui.Controls.Shapes.Geometry item) => this.Children.IndexOf(item);
        public void Insert(int index, Microsoft.Maui.Controls.Shapes.Geometry item) => this.Children.Insert(index, item);
        public bool Remove(Microsoft.Maui.Controls.Shapes.Geometry item) => this.Children.Remove(item);
        public void RemoveAt(int index) => this.Children.RemoveAt(index);
        IEnumerator IEnumerable.GetEnumerator() => this.Children.GetEnumerator();
        public void Add(Microsoft.Maui.Controls.Shapes.Geometry item) => this.Children.Add(item);

    }
}

#nullable restore
