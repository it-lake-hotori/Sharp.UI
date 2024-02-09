﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class MultiTriggerExtension
    {
        public static Microsoft.Maui.Controls.MultiTrigger Conditions(this Microsoft.Maui.Controls.MultiTrigger self,
            IList<Microsoft.Maui.Controls.Condition> conditions)
        {
            foreach (var item in conditions)
                self.Conditions.Add(item);
            return self;
        }

        public static Microsoft.Maui.Controls.MultiTrigger Conditions(this Microsoft.Maui.Controls.MultiTrigger self,
            params Microsoft.Maui.Controls.Condition[] conditions)
        {
            foreach (var item in conditions)
                self.Conditions.Add(item);
            return self;
        }
        
        public static Microsoft.Maui.Controls.MultiTrigger Setters(this Microsoft.Maui.Controls.MultiTrigger self,
            IList<Microsoft.Maui.Controls.Setter> setters)
        {
            foreach (var item in setters)
                self.Setters.Add(item);
            return self;
        }

        public static Microsoft.Maui.Controls.MultiTrigger Setters(this Microsoft.Maui.Controls.MultiTrigger self,
            params Microsoft.Maui.Controls.Setter[] setters)
        {
            foreach (var item in setters)
                self.Setters.Add(item);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore