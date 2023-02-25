﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class PropertyConditionExtension
    {
        public static Microsoft.Maui.Controls.PropertyCondition Property(this Microsoft.Maui.Controls.PropertyCondition self,
            Microsoft.Maui.Controls.BindableProperty property)
        {
            self.Property = property;
            return self;
        }
        
        public static Microsoft.Maui.Controls.PropertyCondition Property(this Microsoft.Maui.Controls.PropertyCondition self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.BindableProperty>, ValueBuilder<Microsoft.Maui.Controls.BindableProperty>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.BindableProperty>());
            if (builder.ValueIsSet()) self.Property = builder.GetValue();
            return self;
        }
        
        public static Microsoft.Maui.Controls.PropertyCondition Value(this Microsoft.Maui.Controls.PropertyCondition self,
            object value)
        {
            self.Value = value;
            return self;
        }
        
        public static Microsoft.Maui.Controls.PropertyCondition Value(this Microsoft.Maui.Controls.PropertyCondition self,
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