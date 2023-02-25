﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class DropGestureRecognizerExtension
    {
        public static T AllowDrop<T>(this T self,
            bool allowDrop)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.AllowDropProperty, allowDrop);
            return self;
        }
        
        public static T AllowDrop<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.AllowDropProperty, builder.GetValue());
            return self;
        }
        
        public static T AllowDrop<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.DropGestureRecognizer.AllowDropProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T DragOverCommand<T>(this T self,
            System.Windows.Input.ICommand dragOverCommand)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandProperty, dragOverCommand);
            return self;
        }
        
        public static T DragOverCommand<T>(this T self,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandProperty, builder.GetValue());
            return self;
        }
        
        public static T DragOverCommand<T>(this T self,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T DragOverCommandParameter<T>(this T self,
            object dragOverCommandParameter)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandParameterProperty, dragOverCommandParameter);
            return self;
        }
        
        public static T DragOverCommandParameter<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandParameterProperty, builder.GetValue());
            return self;
        }
        
        public static T DragOverCommandParameter<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.DropGestureRecognizer.DragOverCommandParameterProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T DragLeaveCommand<T>(this T self,
            System.Windows.Input.ICommand dragLeaveCommand)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandProperty, dragLeaveCommand);
            return self;
        }
        
        public static T DragLeaveCommand<T>(this T self,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandProperty, builder.GetValue());
            return self;
        }
        
        public static T DragLeaveCommand<T>(this T self,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T DragLeaveCommandParameter<T>(this T self,
            object dragLeaveCommandParameter)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandParameterProperty, dragLeaveCommandParameter);
            return self;
        }
        
        public static T DragLeaveCommandParameter<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandParameterProperty, builder.GetValue());
            return self;
        }
        
        public static T DragLeaveCommandParameter<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.DropGestureRecognizer.DragLeaveCommandParameterProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T DropCommand<T>(this T self,
            System.Windows.Input.ICommand dropCommand)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandProperty, dropCommand);
            return self;
        }
        
        public static T DropCommand<T>(this T self,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandProperty, builder.GetValue());
            return self;
        }
        
        public static T DropCommand<T>(this T self,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T DropCommandParameter<T>(this T self,
            object dropCommandParameter)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandParameterProperty, dropCommandParameter);
            return self;
        }
        
        public static T DropCommandParameter<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandParameterProperty, builder.GetValue());
            return self;
        }
        
        public static T DropCommandParameter<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.DropGestureRecognizer.DropCommandParameterProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T OnDragLeave<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.DragEventArgs> handler)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.DragLeave += handler;
            return self;
        }
        
        public static T OnDragLeave<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.DragLeave += (o, arg) => action(self);
            return self;
        }
        
        public static T OnDragOver<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.DragEventArgs> handler)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.DragOver += handler;
            return self;
        }
        
        public static T OnDragOver<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.DragOver += (o, arg) => action(self);
            return self;
        }
        
        public static T OnDrop<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.DropEventArgs> handler)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.Drop += handler;
            return self;
        }
        
        public static T OnDrop<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.DropGestureRecognizer
        {
            self.Drop += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
