﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class FlexLayoutExtension
    {
        public static T Direction<T>(this T self,
            Microsoft.Maui.Layouts.FlexDirection direction)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlexLayout.DirectionProperty, direction);
            return self;
        }
        
        public static T Direction<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.FlexDirection>, ValueBuilder<Microsoft.Maui.Layouts.FlexDirection>> buildValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Layouts.FlexDirection>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlexLayout.DirectionProperty, builder.GetValue());
            return self;
        }
        
        public static T Direction<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.FlexDirection>, BindingBuilder<Microsoft.Maui.Layouts.FlexDirection>> buildBinding)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Layouts.FlexDirection>(self, Microsoft.Maui.Controls.FlexLayout.DirectionProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T JustifyContent<T>(this T self,
            Microsoft.Maui.Layouts.FlexJustify justifyContent)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlexLayout.JustifyContentProperty, justifyContent);
            return self;
        }
        
        public static T JustifyContent<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.FlexJustify>, ValueBuilder<Microsoft.Maui.Layouts.FlexJustify>> buildValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Layouts.FlexJustify>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlexLayout.JustifyContentProperty, builder.GetValue());
            return self;
        }
        
        public static T JustifyContent<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.FlexJustify>, BindingBuilder<Microsoft.Maui.Layouts.FlexJustify>> buildBinding)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Layouts.FlexJustify>(self, Microsoft.Maui.Controls.FlexLayout.JustifyContentProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T AlignContent<T>(this T self,
            Microsoft.Maui.Layouts.FlexAlignContent alignContent)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlexLayout.AlignContentProperty, alignContent);
            return self;
        }
        
        public static T AlignContent<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.FlexAlignContent>, ValueBuilder<Microsoft.Maui.Layouts.FlexAlignContent>> buildValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Layouts.FlexAlignContent>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlexLayout.AlignContentProperty, builder.GetValue());
            return self;
        }
        
        public static T AlignContent<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.FlexAlignContent>, BindingBuilder<Microsoft.Maui.Layouts.FlexAlignContent>> buildBinding)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Layouts.FlexAlignContent>(self, Microsoft.Maui.Controls.FlexLayout.AlignContentProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T AlignItems<T>(this T self,
            Microsoft.Maui.Layouts.FlexAlignItems alignItems)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlexLayout.AlignItemsProperty, alignItems);
            return self;
        }
        
        public static T AlignItems<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.FlexAlignItems>, ValueBuilder<Microsoft.Maui.Layouts.FlexAlignItems>> buildValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Layouts.FlexAlignItems>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlexLayout.AlignItemsProperty, builder.GetValue());
            return self;
        }
        
        public static T AlignItems<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.FlexAlignItems>, BindingBuilder<Microsoft.Maui.Layouts.FlexAlignItems>> buildBinding)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Layouts.FlexAlignItems>(self, Microsoft.Maui.Controls.FlexLayout.AlignItemsProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Position<T>(this T self,
            Microsoft.Maui.Layouts.FlexPosition position)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlexLayout.PositionProperty, position);
            return self;
        }
        
        public static T Position<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.FlexPosition>, ValueBuilder<Microsoft.Maui.Layouts.FlexPosition>> buildValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Layouts.FlexPosition>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlexLayout.PositionProperty, builder.GetValue());
            return self;
        }
        
        public static T Position<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.FlexPosition>, BindingBuilder<Microsoft.Maui.Layouts.FlexPosition>> buildBinding)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Layouts.FlexPosition>(self, Microsoft.Maui.Controls.FlexLayout.PositionProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Wrap<T>(this T self,
            Microsoft.Maui.Layouts.FlexWrap wrap)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlexLayout.WrapProperty, wrap);
            return self;
        }
        
        public static T Wrap<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.FlexWrap>, ValueBuilder<Microsoft.Maui.Layouts.FlexWrap>> buildValue)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Layouts.FlexWrap>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.FlexLayout.WrapProperty, builder.GetValue());
            return self;
        }
        
        public static T Wrap<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.FlexWrap>, BindingBuilder<Microsoft.Maui.Layouts.FlexWrap>> buildBinding)
            where T : Microsoft.Maui.Controls.FlexLayout
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Layouts.FlexWrap>(self, Microsoft.Maui.Controls.FlexLayout.WrapProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
