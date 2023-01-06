﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class StyleGeneratedExtension
    {
        public static T ApplyToDerivedTypes<T>(this T obj,
            bool applyToDerivedTypes)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            mauiObject.ApplyToDerivedTypes = (bool)applyToDerivedTypes;
            return obj;
        }
        
        public static T ApplyToDerivedTypes<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.ApplyToDerivedTypes = builder.GetValue();
            return obj;
        }
        
        public static T ApplyToDerivedTypes<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.ApplyToDerivedTypes = builder.GetValue();
            return obj;
        }
        
        public static T BasedOn<T>(this T obj,
            Microsoft.Maui.Controls.Style basedOn)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            mauiObject.BasedOn = (Microsoft.Maui.Controls.Style)basedOn;
            return obj;
        }
        
        public static T BasedOn<T>(this T obj,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Style>, ValueBuilder<Microsoft.Maui.Controls.Style>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Style>());
            if (builder.ValueIsSet()) mauiObject.BasedOn = builder.GetValue();
            return obj;
        }
        
        public static T BasedOn<T>(this T obj,
            System.Func<LazyValueBuilder<Microsoft.Maui.Controls.Style>, LazyValueBuilder<Microsoft.Maui.Controls.Style>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new LazyValueBuilder<Microsoft.Maui.Controls.Style>());
            if (builder.ValueIsSet()) mauiObject.BasedOn = builder.GetValue();
            return obj;
        }
        
        public static T BaseResourceKey<T>(this T obj,
            string baseResourceKey)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            mauiObject.BaseResourceKey = (string)baseResourceKey;
            return obj;
        }
        
        public static T BaseResourceKey<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.BaseResourceKey = builder.GetValue();
            return obj;
        }
        
        public static T BaseResourceKey<T>(this T obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.BaseResourceKey = builder.GetValue();
            return obj;
        }
        
        public static T Behaviors<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior> behaviors)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in behaviors)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Behavior>(item);
                mauiObject.Behaviors.Add(mauiItem);
            }
            return obj;
        }

        public static T Behaviors<T>(this T obj,
            params Microsoft.Maui.Controls.Behavior[] behaviors)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in behaviors)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Behavior>(item);
                mauiObject.Behaviors.Add(mauiItem);
            }
            return obj;
        }

        public static T Behaviors<T>(this T obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior>>, LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior>>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Behavior>>());
            if (builder.ValueIsSet())
            {
                var items = builder.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Behavior>(item);
                    mauiObject.Behaviors.Add(mauiItem);
                }
            }
            return obj;
        }
        
        public static T CanCascade<T>(this T obj,
            bool canCascade)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            mauiObject.CanCascade = (bool)canCascade;
            return obj;
        }
        
        public static T CanCascade<T>(this T obj,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.CanCascade = builder.GetValue();
            return obj;
        }
        
        public static T CanCascade<T>(this T obj,
            System.Func<LazyValueBuilder<bool>, LazyValueBuilder<bool>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new LazyValueBuilder<bool>());
            if (builder.ValueIsSet()) mauiObject.CanCascade = builder.GetValue();
            return obj;
        }
        
        public static T Class<T>(this T obj,
            string @class)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            mauiObject.Class = (string)@class;
            return obj;
        }
        
        public static T Class<T>(this T obj,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.Class = builder.GetValue();
            return obj;
        }
        
        public static T Class<T>(this T obj,
            System.Func<LazyValueBuilder<string>, LazyValueBuilder<string>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new LazyValueBuilder<string>());
            if (builder.ValueIsSet()) mauiObject.Class = builder.GetValue();
            return obj;
        }
        
        public static T Setters<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter> setters)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in setters)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Setter>(item);
                mauiObject.Setters.Add(mauiItem);
            }
            return obj;
        }

        public static T Setters<T>(this T obj,
            params Microsoft.Maui.Controls.Setter[] setters)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in setters)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Setter>(item);
                mauiObject.Setters.Add(mauiItem);
            }
            return obj;
        }

        public static T Setters<T>(this T obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>, LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.Setter>>());
            if (builder.ValueIsSet())
            {
                var items = builder.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.Setter>(item);
                    mauiObject.Setters.Add(mauiItem);
                }
            }
            return obj;
        }
        
        public static T Triggers<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase> triggers)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in triggers)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerBase>(item);
                mauiObject.Triggers.Add(mauiItem);
            }
            return obj;
        }

        public static T Triggers<T>(this T obj,
            params Microsoft.Maui.Controls.TriggerBase[] triggers)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            foreach (var item in triggers)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerBase>(item);
                mauiObject.Triggers.Add(mauiItem);
            }
            return obj;
        }

        public static T Triggers<T>(this T obj,
            System.Func<LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase>>, LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase>>> buildValue)
            where T : Sharp.UI.IStyle
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.Style>(obj);
            var builder = buildValue(new LazyValueBuilder<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerBase>>());
            if (builder.ValueIsSet())
            {
                var items = builder.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerBase>(item);
                    mauiObject.Triggers.Add(mauiItem);
                }
            }
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
