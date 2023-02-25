﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class StateTriggerExtension
    {
        public static Microsoft.Maui.Controls.StateTrigger IsActive(this Microsoft.Maui.Controls.StateTrigger self,
            bool isActive)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.StateTrigger.IsActiveProperty, isActive);
            return self;
        }
        
        public static Microsoft.Maui.Controls.StateTrigger IsActive(this Microsoft.Maui.Controls.StateTrigger self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.StateTrigger.IsActiveProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.StateTrigger IsActive(this Microsoft.Maui.Controls.StateTrigger self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.StateTrigger.IsActiveProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore