﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class MenuItemGeneratedExtension
    {
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand command)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            mauiObject.Command = (System.Windows.Input.ICommand)command;
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) mauiObject.Command = builder.GetValue();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<LazyValueBuilder<System.Windows.Input.ICommand>, LazyValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) mauiObject.Command = builder.GetValue();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.MenuItem.CommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object commandParameter)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            mauiObject.CommandParameter = (object)commandParameter;
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.CommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.CommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildBinding(new BindingBuilder<object>(mauiObject, Microsoft.Maui.Controls.MenuItem.CommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            Microsoft.Maui.Controls.ImageSource iconImageSource)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            mauiObject.IconImageSource = (Microsoft.Maui.Controls.ImageSource)iconImageSource;
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ImageSource>, ValueBuilder<Microsoft.Maui.Controls.ImageSource>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) mauiObject.IconImageSource = builder.GetValue();
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.ImageSource>, LazyValueBuilder<Microsoft.Maui.Controls.ImageSource>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Controls.ImageSource>());
            if (builder.ValueIsSet()) mauiObject.IconImageSource = builder.GetValue();
            return obj;
        }
        
        public static T IconImageSource<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ImageSource>, BindingBuilder<Microsoft.Maui.Controls.ImageSource>> buildBinding)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.ImageSource>(mauiObject, Microsoft.Maui.Controls.MenuItem.IconImageSourceProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsDestructive<T>(this T obj,
            bool isDestructive)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            mauiObject.IsDestructive = (bool)isDestructive;
            return obj;
        }
        
        public static T IsDestructive<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsDestructive = builder.GetValue();
            return obj;
        }
        
        public static T IsDestructive<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsDestructive = builder.GetValue();
            return obj;
        }
        
        public static T IsDestructive<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.MenuItem.IsDestructiveProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            string text)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            mauiObject.Text = (string)text;
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.Text = builder.GetValue();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.Text = builder.GetValue();
            return obj;
        }
        
        public static T Text<T>(this T obj,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildBinding(new BindingBuilder<string>(mauiObject, Microsoft.Maui.Controls.MenuItem.TextProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            bool isEnabled)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            mauiObject.IsEnabled = (bool)isEnabled;
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsEnabled = builder.GetValue();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsEnabled = builder.GetValue();
            return obj;
        }
        
        public static T IsEnabled<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.MenuItem.IsEnabledProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T StyleClass<T>(this T obj,
            System.Collections.Generic.IList<string> styleClass)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            mauiObject.StyleClass = (System.Collections.Generic.IList<string>)styleClass;
            return obj;
        }
        
        public static T StyleClass<T>(this T obj,
            System.Func<ValueBuilder<System.Collections.Generic.IList<string>>, ValueBuilder<System.Collections.Generic.IList<string>>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new ValueBuilder<System.Collections.Generic.IList<string>>());
            if (builder.ValueIsSet()) mauiObject.StyleClass = builder.GetValue();
            return obj;
        }
        
        public static T StyleClass<T>(this T obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<string>>, LazyValueBuilder<System.Collections.Generic.IList<string>>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Collections.Generic.IList<string>>());
            if (builder.ValueIsSet()) mauiObject.StyleClass = builder.GetValue();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Collections.Generic.IList<string> @class)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            mauiObject.@class = (System.Collections.Generic.IList<string>)@class;
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Func<ValueBuilder<System.Collections.Generic.IList<string>>, ValueBuilder<System.Collections.Generic.IList<string>>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new ValueBuilder<System.Collections.Generic.IList<string>>());
            if (builder.ValueIsSet()) mauiObject.@class = builder.GetValue();
            return obj;
        }
        
        public static T @class<T>(this T obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<string>>, LazyValueBuilder<System.Collections.Generic.IList<string>>> buildValue)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Collections.Generic.IList<string>>());
            if (builder.ValueIsSet()) mauiObject.@class = builder.GetValue();
            return obj;
        }
        
        public static T OnClicked<T>(this T obj, System.EventHandler handler)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            mauiObject.Clicked += handler;
            return obj;
        }
        
        public static T OnClicked<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IMenuItem
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.MenuItem>(obj);
            mauiObject.Clicked += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669