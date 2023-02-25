﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ItemsViewExtension
    {
        public static T EmptyView<T>(this T self,
            object emptyView)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.EmptyViewProperty, emptyView);
            return self;
        }
        
        public static T EmptyView<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.EmptyViewProperty, builder.GetValue());
            return self;
        }
        
        public static T EmptyView<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.ItemsView.EmptyViewProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T EmptyViewTemplate<T>(this T self,
            Microsoft.Maui.Controls.DataTemplate emptyViewTemplate)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.EmptyViewTemplateProperty, emptyViewTemplate);
            return self;
        }
        
        public static T EmptyViewTemplate<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buildValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.EmptyViewTemplateProperty, builder.GetValue());
            return self;
        }
        
        public static T EmptyViewTemplate<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buildBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(self, Microsoft.Maui.Controls.ItemsView.EmptyViewTemplateProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T EmptyViewTemplate<T>(this T self, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.EmptyViewTemplateProperty, new DataTemplate(loadTemplate));
            return self;
        }
        
        public static T ItemsSource<T>(this T self,
            System.Collections.IEnumerable itemsSource)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemsSourceProperty, itemsSource);
            return self;
        }
        
        public static T ItemsSource<T>(this T self,
            System.Func<ValueBuilder<System.Collections.IEnumerable>, ValueBuilder<System.Collections.IEnumerable>> buildValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildValue(new ValueBuilder<System.Collections.IEnumerable>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemsSourceProperty, builder.GetValue());
            return self;
        }
        
        public static T ItemsSource<T>(this T self,
            System.Func<BindingBuilder<System.Collections.IEnumerable>, BindingBuilder<System.Collections.IEnumerable>> buildBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildBinding(new BindingBuilder<System.Collections.IEnumerable>(self, Microsoft.Maui.Controls.ItemsView.ItemsSourceProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T RemainingItemsThresholdReachedCommand<T>(this T self,
            System.Windows.Input.ICommand remainingItemsThresholdReachedCommand)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandProperty, remainingItemsThresholdReachedCommand);
            return self;
        }
        
        public static T RemainingItemsThresholdReachedCommand<T>(this T self,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandProperty, builder.GetValue());
            return self;
        }
        
        public static T RemainingItemsThresholdReachedCommand<T>(this T self,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T RemainingItemsThresholdReachedCommandParameter<T>(this T self,
            object remainingItemsThresholdReachedCommandParameter)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandParameterProperty, remainingItemsThresholdReachedCommandParameter);
            return self;
        }
        
        public static T RemainingItemsThresholdReachedCommandParameter<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandParameterProperty, builder.GetValue());
            return self;
        }
        
        public static T RemainingItemsThresholdReachedCommandParameter<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdReachedCommandParameterProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T self,
            Microsoft.Maui.ScrollBarVisibility horizontalScrollBarVisibility)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.HorizontalScrollBarVisibilityProperty, horizontalScrollBarVisibility);
            return self;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.ScrollBarVisibility>, ValueBuilder<Microsoft.Maui.ScrollBarVisibility>> buildValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.ScrollBarVisibility>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.HorizontalScrollBarVisibilityProperty, builder.GetValue());
            return self;
        }
        
        public static T HorizontalScrollBarVisibility<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.ScrollBarVisibility>, BindingBuilder<Microsoft.Maui.ScrollBarVisibility>> buildBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.ScrollBarVisibility>(self, Microsoft.Maui.Controls.ItemsView.HorizontalScrollBarVisibilityProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T self,
            Microsoft.Maui.ScrollBarVisibility verticalScrollBarVisibility)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.VerticalScrollBarVisibilityProperty, verticalScrollBarVisibility);
            return self;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.ScrollBarVisibility>, ValueBuilder<Microsoft.Maui.ScrollBarVisibility>> buildValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.ScrollBarVisibility>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.VerticalScrollBarVisibilityProperty, builder.GetValue());
            return self;
        }
        
        public static T VerticalScrollBarVisibility<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.ScrollBarVisibility>, BindingBuilder<Microsoft.Maui.ScrollBarVisibility>> buildBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.ScrollBarVisibility>(self, Microsoft.Maui.Controls.ItemsView.VerticalScrollBarVisibilityProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T RemainingItemsThreshold<T>(this T self,
            int remainingItemsThreshold)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdProperty, remainingItemsThreshold);
            return self;
        }
        
        public static T RemainingItemsThreshold<T>(this T self,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdProperty, builder.GetValue());
            return self;
        }
        
        public static T RemainingItemsThreshold<T>(this T self,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildBinding(new BindingBuilder<int>(self, Microsoft.Maui.Controls.ItemsView.RemainingItemsThresholdProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T ItemTemplate<T>(this T self,
            Microsoft.Maui.Controls.DataTemplate itemTemplate)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemTemplateProperty, itemTemplate);
            return self;
        }
        
        public static T ItemTemplate<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buildValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemTemplateProperty, builder.GetValue());
            return self;
        }
        
        public static T ItemTemplate<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buildBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(self, Microsoft.Maui.Controls.ItemsView.ItemTemplateProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T ItemTemplate<T>(this T self, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemTemplateProperty, new DataTemplate(loadTemplate));
            return self;
        }
        
        public static T ItemsUpdatingScrollMode<T>(this T self,
            Microsoft.Maui.Controls.ItemsUpdatingScrollMode itemsUpdatingScrollMode)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemsUpdatingScrollModeProperty, itemsUpdatingScrollMode);
            return self;
        }
        
        public static T ItemsUpdatingScrollMode<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>, ValueBuilder<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>> buildValue)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.ItemsView.ItemsUpdatingScrollModeProperty, builder.GetValue());
            return self;
        }
        
        public static T ItemsUpdatingScrollMode<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>, BindingBuilder<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>> buildBinding)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.ItemsUpdatingScrollMode>(self, Microsoft.Maui.Controls.ItemsView.ItemsUpdatingScrollModeProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T OnScrollToRequested<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ScrollToRequestEventArgs> handler)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.ScrollToRequested += handler;
            return self;
        }
        
        public static T OnScrollToRequested<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.ScrollToRequested += (o, arg) => action(self);
            return self;
        }
        
        public static T OnScrolled<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ItemsViewScrolledEventArgs> handler)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.Scrolled += handler;
            return self;
        }
        
        public static T OnScrolled<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.Scrolled += (o, arg) => action(self);
            return self;
        }
        
        public static T OnRemainingItemsThresholdReached<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.RemainingItemsThresholdReached += handler;
            return self;
        }
        
        public static T OnRemainingItemsThresholdReached<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.ItemsView
        {
            self.RemainingItemsThresholdReached += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
