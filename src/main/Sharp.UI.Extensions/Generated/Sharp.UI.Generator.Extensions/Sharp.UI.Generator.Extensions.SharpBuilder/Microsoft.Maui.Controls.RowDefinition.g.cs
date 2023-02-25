﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class RowDefinitionExtension
    {
        public static Microsoft.Maui.Controls.RowDefinition Height(this Microsoft.Maui.Controls.RowDefinition self,
            Microsoft.Maui.GridLength height)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.RowDefinition.HeightProperty, height);
            return self;
        }
        
        public static Microsoft.Maui.Controls.RowDefinition Height(this Microsoft.Maui.Controls.RowDefinition self,
            System.Func<ValueBuilder<Microsoft.Maui.GridLength>, ValueBuilder<Microsoft.Maui.GridLength>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.GridLength>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.RowDefinition.HeightProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.RowDefinition Height(this Microsoft.Maui.Controls.RowDefinition self,
            System.Func<BindingBuilder<Microsoft.Maui.GridLength>, BindingBuilder<Microsoft.Maui.GridLength>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.GridLength>(self, Microsoft.Maui.Controls.RowDefinition.HeightProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Microsoft.Maui.Controls.RowDefinition OnSizeChanged(this Microsoft.Maui.Controls.RowDefinition self, System.EventHandler handler)
        {
            self.SizeChanged += handler;
            return self;
        }
        
        public static Microsoft.Maui.Controls.RowDefinition OnSizeChanged(this Microsoft.Maui.Controls.RowDefinition self, System.Action<Microsoft.Maui.Controls.RowDefinition> action)
        {
            self.SizeChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
