﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public static class IStateTriggerGeneratedExtension
    {
        public static T IsActive<T>(this T obj,
            bool? isActive)
            where T : Sharp.UI.IStateTrigger
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.StateTrigger>(obj);
            if (isActive != null) mauiObject.IsActive = (bool)isActive;
            return obj;
        }
        
        public static T IsActive<T>(this T obj,
            bool? isActive,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IStateTrigger
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.StateTrigger>(obj);
            if (isActive != null) mauiObject.IsActive = (bool)isActive;
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.StateTrigger.IsActiveProperty));
            if (def.ValueIsSet()) mauiObject.IsActive = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
        public static T IsActive<T>(this T obj,
            Func<BindableDef<bool>, BindableDef<bool>> definition)
            where T : Sharp.UI.IStateTrigger
        {
            var mauiObject = MauiWrapper.GetObject<Microsoft.Maui.Controls.StateTrigger>(obj);
            var def = definition(new BindableDef<bool>(mauiObject, Microsoft.Maui.Controls.StateTrigger.IsActiveProperty));
            if (def.ValueIsSet()) mauiObject.IsActive = def.GetValue();
            def.BindProperty();
            return obj;
        }
        
    }
}


#pragma warning restore CS8669
