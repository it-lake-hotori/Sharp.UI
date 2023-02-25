﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class StructuredItemsViewExtension
    {
        public static T Header<T>(this T self,
            object header)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.HeaderProperty, header);
            return self;
        }
        
        public static T Header<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.HeaderProperty, builder.GetValue());
            return self;
        }
        
        public static T Header<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.StructuredItemsView.HeaderProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T HeaderTemplate<T>(this T self,
            Microsoft.Maui.Controls.DataTemplate headerTemplate)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.HeaderTemplateProperty, headerTemplate);
            return self;
        }
        
        public static T HeaderTemplate<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buildValue)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.HeaderTemplateProperty, builder.GetValue());
            return self;
        }
        
        public static T HeaderTemplate<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buildBinding)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(self, Microsoft.Maui.Controls.StructuredItemsView.HeaderTemplateProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T HeaderTemplate<T>(this T self, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.HeaderTemplateProperty, new DataTemplate(loadTemplate));
            return self;
        }
        
        public static T Footer<T>(this T self,
            object footer)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.FooterProperty, footer);
            return self;
        }
        
        public static T Footer<T>(this T self,
            System.Func<ValueBuilder<object>, ValueBuilder<object>> buildValue)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            var builder = buildValue(new ValueBuilder<object>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.FooterProperty, builder.GetValue());
            return self;
        }
        
        public static T Footer<T>(this T self,
            System.Func<BindingBuilder<object>, BindingBuilder<object>> buildBinding)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            var builder = buildBinding(new BindingBuilder<object>(self, Microsoft.Maui.Controls.StructuredItemsView.FooterProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T FooterTemplate<T>(this T self,
            Microsoft.Maui.Controls.DataTemplate footerTemplate)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.FooterTemplateProperty, footerTemplate);
            return self;
        }
        
        public static T FooterTemplate<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.DataTemplate>, ValueBuilder<Microsoft.Maui.Controls.DataTemplate>> buildValue)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.DataTemplate>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.FooterTemplateProperty, builder.GetValue());
            return self;
        }
        
        public static T FooterTemplate<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.DataTemplate>, BindingBuilder<Microsoft.Maui.Controls.DataTemplate>> buildBinding)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.DataTemplate>(self, Microsoft.Maui.Controls.StructuredItemsView.FooterTemplateProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T FooterTemplate<T>(this T self, System.Func<object> loadTemplate)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.FooterTemplateProperty, new DataTemplate(loadTemplate));
            return self;
        }
        
        public static T ItemsLayout<T>(this T self,
            Microsoft.Maui.Controls.IItemsLayout itemsLayout)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.ItemsLayoutProperty, itemsLayout);
            return self;
        }
        
        public static T ItemsLayout<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.IItemsLayout>, ValueBuilder<Microsoft.Maui.Controls.IItemsLayout>> buildValue)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.IItemsLayout>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.ItemsLayoutProperty, builder.GetValue());
            return self;
        }
        
        public static T ItemsLayout<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.IItemsLayout>, BindingBuilder<Microsoft.Maui.Controls.IItemsLayout>> buildBinding)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.IItemsLayout>(self, Microsoft.Maui.Controls.StructuredItemsView.ItemsLayoutProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T ItemSizingStrategy<T>(this T self,
            Microsoft.Maui.Controls.ItemSizingStrategy itemSizingStrategy)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.ItemSizingStrategyProperty, itemSizingStrategy);
            return self;
        }
        
        public static T ItemSizingStrategy<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ItemSizingStrategy>, ValueBuilder<Microsoft.Maui.Controls.ItemSizingStrategy>> buildValue)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.ItemSizingStrategy>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.StructuredItemsView.ItemSizingStrategyProperty, builder.GetValue());
            return self;
        }
        
        public static T ItemSizingStrategy<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.ItemSizingStrategy>, BindingBuilder<Microsoft.Maui.Controls.ItemSizingStrategy>> buildBinding)
            where T : Microsoft.Maui.Controls.StructuredItemsView
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.ItemSizingStrategy>(self, Microsoft.Maui.Controls.StructuredItemsView.ItemSizingStrategyProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
