﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class ToolbarItemExtension
    {
        public static T Order<T>(this T self,
            Microsoft.Maui.Controls.ToolbarItemOrder order)
            where T : Microsoft.Maui.Controls.ToolbarItem
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Order");
            self.Order = order;
            return self;
        }
        
        public static T Order<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.ToolbarItemOrder>, ValueBuilder<Microsoft.Maui.Controls.ToolbarItemOrder>> buildValue)
            where T : Microsoft.Maui.Controls.ToolbarItem
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Order");
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.ToolbarItemOrder>());
            if (builder.ValueIsSet()) self.Order = builder.GetValue();
            return self;
        }
        
        public static T Priority<T>(this T self,
            int priority)
            where T : Microsoft.Maui.Controls.ToolbarItem
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Priority");
            self.Priority = priority;
            return self;
        }
        
        public static T Priority<T>(this T self,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : Microsoft.Maui.Controls.ToolbarItem
        {
            var setters = FluentStyling.Setters as IList<Setter>;
            if (setters != null) throw new ArgumentException("Fluent styling not available for property Priority");
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) self.Priority = builder.GetValue();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore