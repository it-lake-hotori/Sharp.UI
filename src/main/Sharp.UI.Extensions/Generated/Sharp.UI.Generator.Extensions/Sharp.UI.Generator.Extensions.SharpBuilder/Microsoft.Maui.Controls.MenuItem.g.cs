﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class MenuItemExtension
    {
        public static T Command<T>(this T self,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuItem.CommandProperty, command);
            return self;
        }
        
        public static T Command<T>(this T self,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuItem.CommandProperty, builder.GetValue());
            return self;
        }
        
        public static T Command<T>(this T self,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.MenuItem.CommandProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T CommandParameter<T>(this T self,
            object commandParameter)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuItem.CommandParameterProperty, commandParameter);
            return self;
        }
        
        public static T CommandParameter<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuItem.CommandParameterProperty, builder.GetValue());
            return self;
        }
        
        public static T CommandParameter<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.MenuItem.CommandParameterProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T IconImageSource<T>(this T self,
            Microsoft.Maui.Controls.ImageSource iconImageSource)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuItem.IconImageSourceProperty, iconImageSource);
            return self;
        }
        
        public static T IconImageSource<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buildValue)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuItem.IconImageSourceProperty, builder.GetValue());
            return self;
        }
        
        public static T IconImageSource<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buildBinding)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(self, Microsoft.Maui.Controls.MenuItem.IconImageSourceProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T IsDestructive<T>(this T self,
            bool isDestructive)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuItem.IsDestructiveProperty, isDestructive);
            return self;
        }
        
        public static T IsDestructive<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuItem.IsDestructiveProperty, builder.GetValue());
            return self;
        }
        
        public static T IsDestructive<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.MenuItem.IsDestructiveProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Text<T>(this T self,
            string text)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuItem.TextProperty, text);
            return self;
        }
        
        public static T Text<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuItem.TextProperty, builder.GetValue());
            return self;
        }
        
        public static T Text<T>(this T self,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.MenuItem.TextProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T IsEnabled<T>(this T self,
            bool isEnabled)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuItem.IsEnabledProperty, isEnabled);
            return self;
        }
        
        public static T IsEnabled<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.MenuItem.IsEnabledProperty, builder.GetValue());
            return self;
        }
        
        public static T IsEnabled<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.MenuItem.IsEnabledProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T StyleClass<T>(this T self,
            IList<string> styleClass)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            foreach (var item in styleClass)
                self.StyleClass.Add(item);
            return self;
        }

        public static T StyleClass<T>(this T self,
            params string[] styleClass)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            foreach (var item in styleClass)
                self.StyleClass.Add(item);
            return self;
        }
        
        public static T @class<T>(this T self,
            IList<string> @class)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            foreach (var item in @class)
                self.@class.Add(item);
            return self;
        }

        public static T @class<T>(this T self,
            params string[] @class)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            foreach (var item in @class)
                self.@class.Add(item);
            return self;
        }
        
        public static T OnClicked<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            self.Clicked += handler;
            return self;
        }
        
        public static T OnClicked<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.MenuItem
        {
            self.Clicked += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
