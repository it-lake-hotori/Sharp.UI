﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class CompareStateTriggerExtension
    {
        public static Microsoft.Maui.Controls.CompareStateTrigger Property(this Microsoft.Maui.Controls.CompareStateTrigger self,
            object property)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CompareStateTrigger.PropertyProperty, property);
            return self;
        }
        
        public static Microsoft.Maui.Controls.CompareStateTrigger Property(this Microsoft.Maui.Controls.CompareStateTrigger self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.CompareStateTrigger.PropertyProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.CompareStateTrigger Property(this Microsoft.Maui.Controls.CompareStateTrigger self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.CompareStateTrigger.PropertyProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Microsoft.Maui.Controls.CompareStateTrigger Value(this Microsoft.Maui.Controls.CompareStateTrigger self,
            object value)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.CompareStateTrigger.ValueProperty, value);
            return self;
        }
        
        public static Microsoft.Maui.Controls.CompareStateTrigger Value(this Microsoft.Maui.Controls.CompareStateTrigger self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.CompareStateTrigger.ValueProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.CompareStateTrigger Value(this Microsoft.Maui.Controls.CompareStateTrigger self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.CompareStateTrigger.ValueProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
