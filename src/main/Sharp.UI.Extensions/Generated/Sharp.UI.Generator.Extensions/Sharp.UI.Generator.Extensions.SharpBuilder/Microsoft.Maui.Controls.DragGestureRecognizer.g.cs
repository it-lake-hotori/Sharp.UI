﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class DragGestureRecognizerExtension
    {
        public static T CanDrag<T>(this T self,
            bool canDrag)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.CanDragProperty, canDrag);
            return self;
        }
        
        public static T CanDrag<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.CanDragProperty, builder.GetValue());
            return self;
        }
        
        public static T CanDrag<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.DragGestureRecognizer.CanDragProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T DropCompletedCommand<T>(this T self,
            System.Windows.Input.ICommand dropCompletedCommand)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.DropCompletedCommandProperty, dropCompletedCommand);
            return self;
        }
        
        public static T DropCompletedCommand<T>(this T self,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.DropCompletedCommandProperty, builder.GetValue());
            return self;
        }
        
        public static T DropCompletedCommand<T>(this T self,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.DragGestureRecognizer.DropCompletedCommandProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T DropCompletedCommandParameter<T>(this T self,
            object dropCompletedCommandParameter)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.DropCompletedCommandParameterProperty, dropCompletedCommandParameter);
            return self;
        }
        
        public static T DropCompletedCommandParameter<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.DropCompletedCommandParameterProperty, builder.GetValue());
            return self;
        }
        
        public static T DropCompletedCommandParameter<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.DragGestureRecognizer.DropCompletedCommandParameterProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T DragStartingCommand<T>(this T self,
            System.Windows.Input.ICommand dragStartingCommand)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.DragStartingCommandProperty, dragStartingCommand);
            return self;
        }
        
        public static T DragStartingCommand<T>(this T self,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.DragStartingCommandProperty, builder.GetValue());
            return self;
        }
        
        public static T DragStartingCommand<T>(this T self,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.DragGestureRecognizer.DragStartingCommandProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T DragStartingCommandParameter<T>(this T self,
            object dragStartingCommandParameter)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.DragStartingCommandParameterProperty, dragStartingCommandParameter);
            return self;
        }
        
        public static T DragStartingCommandParameter<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.DragGestureRecognizer.DragStartingCommandParameterProperty, builder.GetValue());
            return self;
        }
        
        public static T DragStartingCommandParameter<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.DragGestureRecognizer.DragStartingCommandParameterProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T OnDropCompleted<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.DropCompletedEventArgs> handler)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.DropCompleted += handler;
            return self;
        }
        
        public static T OnDropCompleted<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.DropCompleted += (o, arg) => action(self);
            return self;
        }
        
        public static T OnDragStarting<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.DragStartingEventArgs> handler)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.DragStarting += handler;
            return self;
        }
        
        public static T OnDragStarting<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DragGestureRecognizer
        {
            self.DragStarting += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore