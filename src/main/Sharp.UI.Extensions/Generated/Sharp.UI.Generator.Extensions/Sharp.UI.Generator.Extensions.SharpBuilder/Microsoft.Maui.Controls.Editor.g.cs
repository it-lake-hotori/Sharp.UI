﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class EditorExtension
    {
        public static T AutoSize<T>(this T self,
            Microsoft.Maui.Controls.EditorAutoSizeOption autoSize)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.AutoSizeProperty, autoSize);
            return self;
        }
        
        public static T AutoSize<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.EditorAutoSizeOption>, ValueBuilder<Microsoft.Maui.Controls.EditorAutoSizeOption>> buildValue)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.EditorAutoSizeOption>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.AutoSizeProperty, builder.GetValue());
            return self;
        }
        
        public static T AutoSize<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.EditorAutoSizeOption>, BindingBuilder<Microsoft.Maui.Controls.EditorAutoSizeOption>> buildBinding)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.EditorAutoSizeOption>(self, Microsoft.Maui.Controls.Editor.AutoSizeProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T FontAttributes<T>(this T self,
            Microsoft.Maui.Controls.FontAttributes fontAttributes)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.FontAttributesProperty, fontAttributes);
            return self;
        }
        
        public static T FontAttributes<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.FontAttributes>, ValueBuilder<Microsoft.Maui.Controls.FontAttributes>> buildValue)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.FontAttributes>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.FontAttributesProperty, builder.GetValue());
            return self;
        }
        
        public static T FontAttributes<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.FontAttributes>, BindingBuilder<Microsoft.Maui.Controls.FontAttributes>> buildBinding)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.FontAttributes>(self, Microsoft.Maui.Controls.Editor.FontAttributesProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T IsTextPredictionEnabled<T>(this T self,
            bool isTextPredictionEnabled)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.IsTextPredictionEnabledProperty, isTextPredictionEnabled);
            return self;
        }
        
        public static T IsTextPredictionEnabled<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.IsTextPredictionEnabledProperty, builder.GetValue());
            return self;
        }
        
        public static T IsTextPredictionEnabled<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.Editor.IsTextPredictionEnabledProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T CursorPosition<T>(this T self,
            int cursorPosition)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.CursorPositionProperty, cursorPosition);
            return self;
        }
        
        public static T CursorPosition<T>(this T self,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.CursorPositionProperty, builder.GetValue());
            return self;
        }
        
        public static T CursorPosition<T>(this T self,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildBinding(new BindingBuilder<int>(self, Microsoft.Maui.Controls.Editor.CursorPositionProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T SelectionLength<T>(this T self,
            int selectionLength)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.SelectionLengthProperty, selectionLength);
            return self;
        }
        
        public static T SelectionLength<T>(this T self,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.SelectionLengthProperty, builder.GetValue());
            return self;
        }
        
        public static T SelectionLength<T>(this T self,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildBinding(new BindingBuilder<int>(self, Microsoft.Maui.Controls.Editor.SelectionLengthProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            string fontFamily)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.FontFamilyProperty, fontFamily);
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.FontFamilyProperty, builder.GetValue());
            return self;
        }
        
        public static T FontFamily<T>(this T self,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildBinding(new BindingBuilder<string>(self, Microsoft.Maui.Controls.Editor.FontFamilyProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T FontSize<T>(this T self,
            double fontSize)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.FontSizeProperty, fontSize);
            return self;
        }
        
        public static T FontSize<T>(this T self,
            System.Func<ValueBuilder<double>, ValueBuilder<double>> buildValue)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildValue(new ValueBuilder<double>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.FontSizeProperty, builder.GetValue());
            return self;
        }
        
        public static T FontSize<T>(this T self,
            System.Func<BindingBuilder<double>, BindingBuilder<double>> buildBinding)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildBinding(new BindingBuilder<double>(self, Microsoft.Maui.Controls.Editor.FontSizeProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
            where T : Microsoft.Maui.Controls.Editor
        {
            double fromValue = self.FontSize;
            var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
            var callback = (double actValue) => { self.FontSize = actValue; };
            return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
        }
        
        public static T HorizontalTextAlignment<T>(this T self,
            Microsoft.Maui.TextAlignment horizontalTextAlignment)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty, horizontalTextAlignment);
            return self;
        }
        
        public static T HorizontalTextAlignment<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.TextAlignment>, ValueBuilder<Microsoft.Maui.TextAlignment>> buildValue)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.TextAlignment>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty, builder.GetValue());
            return self;
        }
        
        public static T HorizontalTextAlignment<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.TextAlignment>, BindingBuilder<Microsoft.Maui.TextAlignment>> buildBinding)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.TextAlignment>(self, Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T VerticalTextAlignment<T>(this T self,
            Microsoft.Maui.TextAlignment verticalTextAlignment)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty, verticalTextAlignment);
            return self;
        }
        
        public static T VerticalTextAlignment<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.TextAlignment>, ValueBuilder<Microsoft.Maui.TextAlignment>> buildValue)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.TextAlignment>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty, builder.GetValue());
            return self;
        }
        
        public static T VerticalTextAlignment<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.TextAlignment>, BindingBuilder<Microsoft.Maui.TextAlignment>> buildBinding)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.TextAlignment>(self, Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            bool fontAutoScalingEnabled)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.FontAutoScalingEnabledProperty, builder.GetValue());
            return self;
        }
        
        public static T FontAutoScalingEnabled<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.Editor
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.Editor.FontAutoScalingEnabledProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T OnCompleted<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.Completed += handler;
            return self;
        }
        
        public static T OnCompleted<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.Completed += (o, arg) => action(self);
            return self;
        }
        

        public static T TextCenterHorizontal<T>(this T self)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextCenterVertical<T>(this T self)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextCenter<T>(this T self)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty, TextAlignment.Center);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }

        public static T TextTop<T>(this T self)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextBottom<T>(this T self)
            where T : Microsoft.Maui.Controls.Editor, Microsoft.Maui.ITextAlignment
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextTopStart<T>(this T self)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextBottomStart<T>(this T self)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextTopEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextBottomEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        public static T TextStart<T>(this T self)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }

        public static T TextEnd<T>(this T self)
            where T : Microsoft.Maui.Controls.Editor
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Editor.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }

        
    }
}

#pragma warning restore CS8601
#nullable restore
