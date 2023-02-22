﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class SwipeItemExtension
    {
        public static T BackgroundColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color backgroundColor)
            where T : Microsoft.Maui.Controls.SwipeItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.SwipeItem.BackgroundColorProperty, backgroundColor);
            return obj;
        }
        
        public static T BackgroundColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buidValue)
            where T : Microsoft.Maui.Controls.SwipeItem
        {
            var builder = buidValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.SwipeItem.BackgroundColorProperty, builder.GetValue());
            return obj;
        }
        
        public static T BackgroundColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buidBinding)
            where T : Microsoft.Maui.Controls.SwipeItem
        {
            var builder = buidBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(obj, Microsoft.Maui.Controls.SwipeItem.BackgroundColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            bool isVisible)
            where T : Microsoft.Maui.Controls.SwipeItem
        {
            obj.SetValueOrSetter(Microsoft.Maui.Controls.SwipeItem.IsVisibleProperty, isVisible);
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buidValue)
            where T : Microsoft.Maui.Controls.SwipeItem
        {
            var builder = buidValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) obj.SetValueOrSetter(Microsoft.Maui.Controls.SwipeItem.IsVisibleProperty, builder.GetValue());
            return obj;
        }
        
        public static T IsVisible<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buidBinding)
            where T : Microsoft.Maui.Controls.SwipeItem
        {
            var builder = buidBinding(new BindingBuilder<bool>(obj, Microsoft.Maui.Controls.SwipeItem.IsVisibleProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnInvoked<T>(this T obj, System.EventHandler<System.EventArgs> handler)
            where T : Microsoft.Maui.Controls.SwipeItem
        {
            obj.Invoked += handler;
            return obj;
        }
        
        public static T OnInvoked<T>(this T obj, System.Action<T> action)
            where T : Microsoft.Maui.Controls.SwipeItem
        {
            obj.Invoked += (o, arg) => action(obj);
            return obj;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
