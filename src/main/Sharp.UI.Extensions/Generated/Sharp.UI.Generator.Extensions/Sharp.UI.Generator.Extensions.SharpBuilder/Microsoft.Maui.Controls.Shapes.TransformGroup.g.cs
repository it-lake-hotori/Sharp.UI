﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class TransformGroupExtension
    {
        public static Microsoft.Maui.Controls.Shapes.TransformGroup Children(this Microsoft.Maui.Controls.Shapes.TransformGroup obj,
            IList<Microsoft.Maui.Controls.Shapes.Transform> children)
        {
            foreach (var item in children)
                obj.Children.Add(item);
            return obj;
        }

        public static Microsoft.Maui.Controls.Shapes.TransformGroup Children(this Microsoft.Maui.Controls.Shapes.TransformGroup obj,
            params Microsoft.Maui.Controls.Shapes.Transform[] children)
        {
            foreach (var item in children)
                obj.Children.Add(item);
            return obj;
        }
        
        public static Microsoft.Maui.Controls.Shapes.TransformGroup Children(this Microsoft.Maui.Controls.Shapes.TransformGroup obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.TransformCollection>, BindingBuilder<Microsoft.Maui.Controls.Shapes.TransformCollection>> buidBinding)
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.TransformCollection>(obj, Microsoft.Maui.Controls.Shapes.TransformGroup.ChildrenProperty));
            builder.BindProperty();
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
