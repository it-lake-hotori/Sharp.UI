﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class TableViewExtension
    {
        public static T HasUnevenRows<T>(this T self,
            bool hasUnevenRows)
            where T : Microsoft.Maui.Controls.TableView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TableView.HasUnevenRowsProperty, hasUnevenRows);
            return self;
        }
        
        public static T HasUnevenRows<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
            where T : Microsoft.Maui.Controls.TableView
        {
            var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.TableView.HasUnevenRowsProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Intent<T>(this T self,
            Microsoft.Maui.Controls.TableIntent intent)
            where T : Microsoft.Maui.Controls.TableView
        {
            if (FluentStyling.Setters != null) throw new ArgumentException("Fluent styling not available for property Intent");
            self.Intent = intent;
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
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.TableView.RowHeightProperty, rowHeight);
            return self;
        }
        
        public static T RowHeight<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
            where T : Microsoft.Maui.Controls.TableView
        {
            var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.TableView.RowHeightProperty);
            configure(context).Build();
            return self;
        }
        
        public static T Model<T>(this T self,
            Microsoft.Maui.Controls.Internals.TableModel model)
            where T : Microsoft.Maui.Controls.TableView
        {
            if (FluentStyling.Setters != null) throw new ArgumentException("Fluent styling not available for property Model");
            self.Model = model;
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