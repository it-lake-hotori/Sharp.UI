﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class ReorderableItemsViewExtension
    {
        public static T CanMixGroups<T>(this T self,
            bool canMixGroups)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ReorderableItemsView.CanMixGroupsProperty, canMixGroups);
            return self;
        }
        
        public static T CanMixGroups<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ReorderableItemsView.CanMixGroupsProperty, builder.GetValue());
            return self;
        }
        
        public static T CanMixGroups<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.ReorderableItemsView.CanMixGroupsProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T CanReorderItems<T>(this T self,
            bool canReorderItems)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.ReorderableItemsView.CanReorderItemsProperty, canReorderItems);
            return self;
        }
        
        public static T CanReorderItems<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.ReorderableItemsView.CanReorderItemsProperty, builder.GetValue());
            return self;
        }
        
        public static T CanReorderItems<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.ReorderableItemsView.CanReorderItemsProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T OnReorderCompleted<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            self.ReorderCompleted += handler;
            return self;
        }
        
        public static T OnReorderCompleted<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ReorderableItemsView
        {
            self.ReorderCompleted += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore