﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class DeviceStateTriggerExtension
    {
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger self,
            string device)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.DeviceStateTrigger.DeviceProperty, device);
            return self;
        }
        
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.DeviceStateTrigger.DeviceProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.DeviceStateTrigger Device(this Microsoft.Maui.Controls.DeviceStateTrigger self,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.DeviceStateTrigger.DeviceProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore