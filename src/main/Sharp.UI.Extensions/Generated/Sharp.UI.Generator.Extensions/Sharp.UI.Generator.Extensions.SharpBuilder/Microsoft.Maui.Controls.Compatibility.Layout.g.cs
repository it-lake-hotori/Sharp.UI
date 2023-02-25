﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class CompatibilityLayoutExtension
    {
        public static T IsClippedToBounds<T>(this T self,
            bool isClippedToBounds)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty, isClippedToBounds);
            return self;
        }
        
        public static T IsClippedToBounds<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty, builder.GetValue());
            return self;
        }
        
        public static T IsClippedToBounds<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Padding<T>(this T self,
            Microsoft.Maui.Thickness padding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, padding);
            return self;
        }
        
        public static T Padding<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Thickness>, ValueBuilder<Microsoft.Maui.Thickness>> buildValue)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Thickness>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, builder.GetValue());
            return self;
        }
        
        public static T Padding<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Thickness>, BindingBuilder<Microsoft.Maui.Thickness>> buildBinding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Thickness>(self, Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T CascadeInputTransparent<T>(this T self,
            bool cascadeInputTransparent)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty, cascadeInputTransparent);
            return self;
        }
        
        public static T CascadeInputTransparent<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty, builder.GetValue());
            return self;
        }
        
        public static T CascadeInputTransparent<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T OnLayoutChanged<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.LayoutChanged += handler;
            return self;
        }
        
        public static T OnLayoutChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Compatibility.Layout
        {
            self.LayoutChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
