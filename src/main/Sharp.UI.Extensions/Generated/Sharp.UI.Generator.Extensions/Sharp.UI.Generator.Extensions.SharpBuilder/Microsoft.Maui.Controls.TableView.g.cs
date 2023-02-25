﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI;
    using Sharp.UI.Internal;

    public static partial class TableViewExtension
    {
        public static T HasUnevenRows<T>(this T self,
            bool hasUnevenRows)
            where T : Microsoft.Maui.Controls.TableView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.TableView.HasUnevenRowsProperty, hasUnevenRows);
            return self;
        }
        
        public static T HasUnevenRows<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : Microsoft.Maui.Controls.TableView
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.TableView.HasUnevenRowsProperty, builder.GetValue());
            return self;
        }
        
        public static T HasUnevenRows<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : Microsoft.Maui.Controls.TableView
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, Microsoft.Maui.Controls.TableView.HasUnevenRowsProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Intent<T>(this T self,
            Microsoft.Maui.Controls.TableIntent intent)
            where T : Microsoft.Maui.Controls.TableView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Intent");
            self.Intent = intent;
            return self;
        }
        
        public static T Intent<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.TableIntent>, ValueBuilder<Microsoft.Maui.Controls.TableIntent>> buildValue)
            where T : Microsoft.Maui.Controls.TableView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Intent");
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.TableIntent>());
            if (builder.ValueIsSet()) self.Intent = builder.GetValue();
            return self;
        }
        
        public static T Root<T>(this T self,
            IList<Microsoft.Maui.Controls.TableSection> root)
            where T : Microsoft.Maui.Controls.TableView
        {
            foreach (var item in root)
                self.Root.Add(item);
            return self;
        }

        public static T Root<T>(this T self,
            params Microsoft.Maui.Controls.TableSection[] root)
            where T : Microsoft.Maui.Controls.TableView
        {
            foreach (var item in root)
                self.Root.Add(item);
            return self;
        }
        
        public static T RowHeight<T>(this T self,
            int rowHeight)
            where T : Microsoft.Maui.Controls.TableView
        {
            self.SetValueOrSetter(Microsoft.Maui.Controls.TableView.RowHeightProperty, rowHeight);
            return self;
        }
        
        public static T RowHeight<T>(this T self,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Microsoft.Maui.Controls.TableView
        {
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) self.SetValueOrSetter(Microsoft.Maui.Controls.TableView.RowHeightProperty, builder.GetValue());
            return self;
        }
        
        public static T RowHeight<T>(this T self,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : Microsoft.Maui.Controls.TableView
        {
            var builder = buildBinding(new BindingBuilder<int>(self, Microsoft.Maui.Controls.TableView.RowHeightProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Model<T>(this T self,
            Microsoft.Maui.Controls.Internals.TableModel model)
            where T : Microsoft.Maui.Controls.TableView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Model");
            self.Model = model;
            return self;
        }
        
        public static T Model<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Internals.TableModel>, ValueBuilder<Microsoft.Maui.Controls.Internals.TableModel>> buildValue)
            where T : Microsoft.Maui.Controls.TableView
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Model");
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Internals.TableModel>());
            if (builder.ValueIsSet()) self.Model = builder.GetValue();
            return self;
        }
        
        public static T OnModelChanged<T>(this T self, System.EventHandler handler)
            where T : Microsoft.Maui.Controls.TableView
        {
            self.ModelChanged += handler;
            return self;
        }
        
        public static T OnModelChanged<T>(this T self, System.Action<T> action)
            where T : Microsoft.Maui.Controls.TableView
        {
            self.ModelChanged += (o, arg) => action(self);
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
