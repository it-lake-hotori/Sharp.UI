﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class BindingConditionExtension
    {
        public static Microsoft.Maui.Controls.BindingCondition Binding(this Microsoft.Maui.Controls.BindingCondition self,
            Microsoft.Maui.Controls.BindingBase binding)
        {
            self.Binding = binding;
            return self;
        }
        
        public static Microsoft.Maui.Controls.BindingCondition Binding(this Microsoft.Maui.Controls.BindingCondition self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.BindingBase>, ValueBuilder<Microsoft.Maui.Controls.BindingBase>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.BindingBase>());
            if (builder.ValueIsSet()) self.Binding = builder.GetValue();
            return self;
        }
        
        public static Microsoft.Maui.Controls.BindingCondition Value(this Microsoft.Maui.Controls.BindingCondition self,
            object value)
        {
            self.Value = value;
            return self;
        }
        
        public static Microsoft.Maui.Controls.BindingCondition Value(this Microsoft.Maui.Controls.BindingCondition self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.Value = builder.GetValue();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
