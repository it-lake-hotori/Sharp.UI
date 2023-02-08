﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class RefreshViewGeneratedExtension
    {
        public static T IsRefreshing<T>(this T obj,
            bool isRefreshing)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            mauiObject.IsRefreshing = (bool)isRefreshing;
            return obj;
        }
        
        public static T IsRefreshing<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsRefreshing = builder.GetValue();
            return obj;
        }
        
        public static T IsRefreshing<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            var builder = buildValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.IsRefreshing = builder.GetValue();
            return obj;
        }
        
        public static T IsRefreshing<T>(this T obj,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            var builder = buildBinding(new BindingBuilder<bool>(mauiObject, Microsoft.Maui.Controls.RefreshView.IsRefreshingProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Windows.Input.ICommand command)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            mauiObject.Command = (System.Windows.Input.ICommand)command;
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) mauiObject.Command = builder.GetValue();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<LazyValueBuilder<System.Windows.Input.ICommand>, LazyValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) mauiObject.Command = builder.GetValue();
            return obj;
        }
        
        public static T Command<T>(this T obj,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(mauiObject, Microsoft.Maui.Controls.RefreshView.CommandProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            object commandParameter)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            mauiObject.CommandParameter = (object)commandParameter;
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.CommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<LazyValueBuilder<object>, LazyValueBuilder<object>> buildValue)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            var builder = buildValue(new LazyValueBuilder<object>());
            if (builder.ValueIsSet()) mauiObject.CommandParameter = builder.GetValue();
            return obj;
        }
        
        public static T CommandParameter<T>(this T obj,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            var builder = buildBinding(new BindingBuilder<object>(mauiObject, Microsoft.Maui.Controls.RefreshView.CommandParameterProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T RefreshColor<T>(this T obj,
            Microsoft.Maui.Graphics.Color refreshColor)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            mauiObject.RefreshColor = (Microsoft.Maui.Graphics.Color)refreshColor;
            return obj;
        }
        
        public static T RefreshColor<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.RefreshColor = builder.GetValue();
            return obj;
        }
        
        public static T RefreshColor<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Graphics.Color>, LazyValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) mauiObject.RefreshColor = builder.GetValue();
            return obj;
        }
        
        public static T RefreshColor<T>(this T obj,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(mauiObject, Microsoft.Maui.Controls.RefreshView.RefreshColorProperty));
            builder.BindProperty();
            return obj;
        }
        
        public static T OnRefreshing<T>(this T obj, System.EventHandler handler)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            mauiObject.Refreshing += handler;
            return obj;
        }
        
        public static T OnRefreshing<T>(this T obj, OnEventAction<T> action)
            where T : Sharp.UI.IRefreshView
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.RefreshView>(obj);
            mauiObject.Refreshing += (o, arg) => action(obj);
            return obj;
        }
        
    }
}


#pragma warning restore CS8669