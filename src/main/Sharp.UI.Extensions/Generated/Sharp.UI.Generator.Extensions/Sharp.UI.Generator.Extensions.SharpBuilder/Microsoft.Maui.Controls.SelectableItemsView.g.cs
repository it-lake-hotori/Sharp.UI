﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class SelectableItemsViewExtension
    {
        public static T SelectedItem<T>(this T self,
            object selectedItem)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.SelectableItemsView.SelectedItemProperty, selectedItem);
            return self;
        }
        
        public static T SelectedItem<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.SelectableItemsView.SelectedItemProperty, builder.GetValue());
            return self;
        }
        
        public static T SelectedItem<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.SelectableItemsView.SelectedItemProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T SelectedItems<T>(this T self,
            IList<object> selectedItems)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            foreach (var item in selectedItems)
                self.SelectedItems.Add(item);
            return self;
        }

        public static T SelectedItems<T>(this T self,
            params object[] selectedItems)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            foreach (var item in selectedItems)
                self.SelectedItems.Add(item);
            return self;
        }
        
        public static T SelectedItems<T>(this T self,
            System.Func<BindingBuilder<System.Collections.Generic.IList<object>>, BindingBuilder<System.Collections.Generic.IList<object>>> buildBinding)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var builder = buildBinding(new BindingBuilder<System.Collections.Generic.IList<object>>(self, Microsoft.Maui.Controls.SelectableItemsView.SelectedItemsProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T SelectionChangedCommand<T>(this T self,
            System.Windows.Input.ICommand selectionChangedCommand)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandProperty, selectionChangedCommand);
            return self;
        }
        
        public static T SelectionChangedCommand<T>(this T self,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandProperty, builder.GetValue());
            return self;
        }
        
        public static T SelectionChangedCommand<T>(this T self,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T SelectionChangedCommandParameter<T>(this T self,
            object selectionChangedCommandParameter)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandParameterProperty, selectionChangedCommandParameter);
            return self;
        }
        
        public static T SelectionChangedCommandParameter<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandParameterProperty, builder.GetValue());
            return self;
        }
        
        public static T SelectionChangedCommandParameter<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.SelectableItemsView.SelectionChangedCommandParameterProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T SelectionMode<T>(this T self,
            Microsoft.Maui.Controls.SelectionMode selectionMode)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.SelectableItemsView.SelectionModeProperty, selectionMode);
            return self;
        }
        
        public static T SelectionMode<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.SelectionMode>, ValueBuilder<Microsoft.Maui.Controls.SelectionMode>> buildValue)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.SelectionMode>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.SelectableItemsView.SelectionModeProperty, builder.GetValue());
            return self;
        }
        
        public static T SelectionMode<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.SelectionMode>, BindingBuilder<Microsoft.Maui.Controls.SelectionMode>> buildBinding)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.SelectionMode>(self, Microsoft.Maui.Controls.SelectableItemsView.SelectionModeProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T OnSelectionChanged<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.SelectionChangedEventArgs> handler)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.SelectionChanged += handler;
            return self;
        }
        
        public static T OnSelectionChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.SelectableItemsView
        {
            self.SelectionChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
