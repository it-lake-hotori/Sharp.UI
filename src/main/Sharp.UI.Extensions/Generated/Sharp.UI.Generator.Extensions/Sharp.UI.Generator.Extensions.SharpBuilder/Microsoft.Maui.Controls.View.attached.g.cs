﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class ViewExtension
    {
        public static T Column<T>(this T self,
            int column)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnProperty, column);
            return self;
        }
        
        public static T Column<T>(this T self,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnProperty, builder.GetValue());
            return self;
        }
        
        public static T Column<T>(this T self,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildBinding(new BindingBuilder<int>(self, Microsoft.Maui.Controls.Grid.ColumnProperty));
            builder.BindProperty();
            return self;
        }
        
        public static int GetColumnValue<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            return (int)self.GetValue(Microsoft.Maui.Controls.Grid.ColumnProperty);
        }
        
        public static T Row<T>(this T self,
            int row)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowProperty, row);
            return self;
        }
        
        public static T Row<T>(this T self,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowProperty, builder.GetValue());
            return self;
        }
        
        public static T Row<T>(this T self,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildBinding(new BindingBuilder<int>(self, Microsoft.Maui.Controls.Grid.RowProperty));
            builder.BindProperty();
            return self;
        }
        
        public static int GetRowValue<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            return (int)self.GetValue(Microsoft.Maui.Controls.Grid.RowProperty);
        }
        
        public static T ColumnSpan<T>(this T self,
            int columnSpan)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnSpanProperty, columnSpan);
            return self;
        }
        
        public static T ColumnSpan<T>(this T self,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.Grid.ColumnSpanProperty, builder.GetValue());
            return self;
        }
        
        public static T ColumnSpan<T>(this T self,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildBinding(new BindingBuilder<int>(self, Microsoft.Maui.Controls.Grid.ColumnSpanProperty));
            builder.BindProperty();
            return self;
        }
        
        public static int GetColumnSpanValue<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            return (int)self.GetValue(Microsoft.Maui.Controls.Grid.ColumnSpanProperty);
        }
        
        public static T RowSpan<T>(this T self,
            int rowSpan)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowSpanProperty, rowSpan);
            return self;
        }
        
        public static T RowSpan<T>(this T self,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.Grid.RowSpanProperty, builder.GetValue());
            return self;
        }
        
        public static T RowSpan<T>(this T self,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildBinding(new BindingBuilder<int>(self, Microsoft.Maui.Controls.Grid.RowSpanProperty));
            builder.BindProperty();
            return self;
        }
        
        public static int GetRowSpanValue<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            return (int)self.GetValue(Microsoft.Maui.Controls.Grid.RowSpanProperty);
        }
        
        public static T AbsoluteLayoutFlags<T>(this T self,
            Microsoft.Maui.Layouts.AbsoluteLayoutFlags absoluteLayoutFlags)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.AbsoluteLayout.LayoutFlagsProperty, absoluteLayoutFlags);
            return self;
        }
        
        public static T AbsoluteLayoutFlags<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Layouts.AbsoluteLayoutFlags>, ValueBuilder<Microsoft.Maui.Layouts.AbsoluteLayoutFlags>> buildValue)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Layouts.AbsoluteLayoutFlags>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.AbsoluteLayout.LayoutFlagsProperty, builder.GetValue());
            return self;
        }
        
        public static T AbsoluteLayoutFlags<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Layouts.AbsoluteLayoutFlags>, BindingBuilder<Microsoft.Maui.Layouts.AbsoluteLayoutFlags>> buildBinding)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Layouts.AbsoluteLayoutFlags>(self, Microsoft.Maui.Controls.AbsoluteLayout.LayoutFlagsProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Microsoft.Maui.Layouts.AbsoluteLayoutFlags GetAbsoluteLayoutFlagsValue<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            return (Microsoft.Maui.Layouts.AbsoluteLayoutFlags)self.GetValue(Microsoft.Maui.Controls.AbsoluteLayout.LayoutFlagsProperty);
        }
        
        public static T AbsoluteLayoutBounds<T>(this T self,
            Microsoft.Maui.Graphics.Rect absoluteLayoutBounds)
            where T : Microsoft.Maui.Controls.View
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.AbsoluteLayout.LayoutBoundsProperty, absoluteLayoutBounds);
            return self;
        }
        
        public static T AbsoluteLayoutBounds<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Graphics.Rect>, ValueBuilder<Microsoft.Maui.Graphics.Rect>> buildValue)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Graphics.Rect>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.AbsoluteLayout.LayoutBoundsProperty, builder.GetValue());
            return self;
        }
        
        public static T AbsoluteLayoutBounds<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Graphics.Rect>, BindingBuilder<Microsoft.Maui.Graphics.Rect>> buildBinding)
            where T : Microsoft.Maui.Controls.View
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Graphics.Rect>(self, Microsoft.Maui.Controls.AbsoluteLayout.LayoutBoundsProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Microsoft.Maui.Graphics.Rect GetAbsoluteLayoutBoundsValue<T>(this T self)
            where T : Microsoft.Maui.Controls.View
        {
            return (Microsoft.Maui.Graphics.Rect)self.GetValue(Microsoft.Maui.Controls.AbsoluteLayout.LayoutBoundsProperty);
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
