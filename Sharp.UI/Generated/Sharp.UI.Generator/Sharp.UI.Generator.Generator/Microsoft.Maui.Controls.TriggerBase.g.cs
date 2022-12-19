﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class TriggerBaseGeneratedExtension
    {
        public static T EnterActions<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction> enterActions)
            where T : Sharp.UI.ITriggerBase
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerBase>(obj);
            foreach (var item in enterActions)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerAction>(item);
                mauiObject.EnterActions.Add(mauiItem);
            }
            return obj;
        }

        public static T EnterActions<T>(this T obj,
            params Microsoft.Maui.Controls.TriggerAction[] enterActions)
            where T : Sharp.UI.ITriggerBase
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerBase>(obj);
            foreach (var item in enterActions)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerAction>(item);
                mauiObject.EnterActions.Add(mauiItem);
            }
            return obj;
        }

        public static T EnterActions<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction>>> definition)
            where T : Sharp.UI.ITriggerBase
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerBase>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerAction>(item);
                    mauiObject.EnterActions.Add(mauiItem);
                }
            }
            return obj;
        }
        
        public static T ExitActions<T>(this T obj,
            System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction> exitActions)
            where T : Sharp.UI.ITriggerBase
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerBase>(obj);
            foreach (var item in exitActions)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerAction>(item);
                mauiObject.ExitActions.Add(mauiItem);
            }
            return obj;
        }

        public static T ExitActions<T>(this T obj,
            params Microsoft.Maui.Controls.TriggerAction[] exitActions)
            where T : Sharp.UI.ITriggerBase
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerBase>(obj);
            foreach (var item in exitActions)
            {
                var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerAction>(item);
                mauiObject.ExitActions.Add(mauiItem);
            }
            return obj;
        }

        public static T ExitActions<T>(this T obj,
            System.Func<Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction>>, Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction>>> definition)
            where T : Sharp.UI.ITriggerBase
        {
            var mauiObject = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerBase>(obj);
            var def = definition(new Def<System.Collections.Generic.IList<Microsoft.Maui.Controls.TriggerAction>>());
            if (def.ValueIsSet())
            {
                var items = def.GetValue();
                foreach (var item in items) 
                {
                    var mauiItem = MauiWrapper.Value<Microsoft.Maui.Controls.TriggerAction>(item);
                    mauiObject.ExitActions.Add(mauiItem);
                }
            }
            return obj;
        }
        
    }
}


#pragma warning restore CS8669