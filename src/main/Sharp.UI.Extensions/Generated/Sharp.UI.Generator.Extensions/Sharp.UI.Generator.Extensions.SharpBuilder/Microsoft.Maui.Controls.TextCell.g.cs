﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class TextCellExtension
    {
        public static T Command<T>(this T self,
            System.Windows.Input.ICommand command)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TextCell.CommandProperty, command);
            return self;
        }
        
        public static T Command<T>(this T self,
            System.Func<ValueBuilder<System.Windows.Input.ICommand>, ValueBuilder<System.Windows.Input.ICommand>> buildValue)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var builder = buildValue(new ValueBuilder<System.Windows.Input.ICommand>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TextCell.CommandProperty, builder.GetValue());
            return self;
        }
        
        public static T Command<T>(this T self,
            System.Func<BindingBuilder<System.Windows.Input.ICommand>, BindingBuilder<System.Windows.Input.ICommand>> buildBinding)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var builder = buildBinding(new BindingBuilder<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.TextCell.CommandProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T CommandParameter<T>(this T self,
            object commandParameter)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TextCell.CommandParameterProperty, commandParameter);
            return self;
        }
        
        public static T CommandParameter<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TextCell.CommandParameterProperty, builder.GetValue());
            return self;
        }
        
        public static T CommandParameter<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.TextCell.CommandParameterProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Detail<T>(this T self,
            string detail)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TextCell.DetailProperty, detail);
            return self;
        }
        
        public static T Detail<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TextCell.DetailProperty, builder.GetValue());
            return self;
        }
        
        public static T Detail<T>(this T self,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.TextCell.DetailProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T DetailColor<T>(this T self,
            Microsoft.Maui.Graphics.Color detailColor)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TextCell.DetailColorProperty, detailColor);
            return self;
        }
        
        public static T DetailColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TextCell.DetailColorProperty, builder.GetValue());
            return self;
        }
        
        public static T DetailColor<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.TextCell.DetailColorProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Text<T>(this T self,
            string text)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TextCell.TextProperty, text);
            return self;
        }
        
        public static T Text<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TextCell.TextProperty, builder.GetValue());
            return self;
        }
        
        public static T Text<T>(this T self,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.TextCell.TextProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T TextColor<T>(this T self,
            Microsoft.Maui.Graphics.Color textColor)
            where T : Microsoft.Maui.Controls.TextCell
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TextCell.TextColorProperty, textColor);
            return self;
        }
        
        public static T TextColor<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Color>, ValueBuilder<Microsoft.Maui.Graphics.Color>> buildValue)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Color>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.TextCell.TextColorProperty, builder.GetValue());
            return self;
        }
        
        public static T TextColor<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Color>, BindingBuilder<Microsoft.Maui.Graphics.Color>> buildBinding)
            where T : Microsoft.Maui.Controls.TextCell
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.TextCell.TextColorProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore