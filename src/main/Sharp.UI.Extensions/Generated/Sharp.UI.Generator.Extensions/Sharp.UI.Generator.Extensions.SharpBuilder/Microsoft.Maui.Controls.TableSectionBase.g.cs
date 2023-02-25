﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class TableSectionBaseExtension
    {
        public static T Title<T>(this T self,
            string title)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TableSectionBase.TitleProperty, title);
            return self;
        }
        
        public static T Title<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TableSectionBase.TitleProperty, builder.GetValue());
            return self;
        }
        
        public static T Title<T>(this T self,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.TableSectionBase.TitleProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T TextColor<T>(this T self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TableSectionBase.TextColorProperty, textColor);
            return self;
        }
        
        public static T TextColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TableSectionBase.TextColorProperty, builder.GetValue());
            return self;
        }
        
        public static T TextColor<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Microsoft.Maui.Controls.TableSectionBase
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.TableSectionBase.TextColorProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore