﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class PathGeometryExtension
    {
        public static Microsoft.Maui.Controls.Shapes.PathGeometry Figures(this Microsoft.Maui.Controls.Shapes.PathGeometry self,
            IList<Microsoft.Maui.Controls.Shapes.PathFigure> figures)
        {
            foreach (var item in figures)
                self.Figures.Add(item);
            return self;
        }

        public static Microsoft.Maui.Controls.Shapes.PathGeometry Figures(this Microsoft.Maui.Controls.Shapes.PathGeometry self,
            params Microsoft.Maui.Controls.Shapes.PathFigure[] figures)
        {
            foreach (var item in figures)
                self.Figures.Add(item);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathGeometry Figures(this Microsoft.Maui.Controls.Shapes.PathGeometry self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.PathFigureCollection>, BindingBuilder<Microsoft.Maui.Controls.Shapes.PathFigureCollection>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.PathFigureCollection>(self, Microsoft.Maui.Controls.Shapes.PathGeometry.FiguresProperty));
            builder.BindProperty();
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathGeometry FillRule(this Microsoft.Maui.Controls.Shapes.PathGeometry self,
            Microsoft.Maui.Controls.Shapes.FillRule fillRule)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.PathGeometry.FillRuleProperty, fillRule);
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathGeometry FillRule(this Microsoft.Maui.Controls.Shapes.PathGeometry self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Shapes.FillRule>, ValueBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> buildValue)
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Shapes.FillRule>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.PathGeometry.FillRuleProperty, builder.GetValue());
            return self;
        }
        
        public static Microsoft.Maui.Controls.Shapes.PathGeometry FillRule(this Microsoft.Maui.Controls.Shapes.PathGeometry self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.FillRule>, BindingBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> buildBinding)
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.FillRule>(self, Microsoft.Maui.Controls.Shapes.PathGeometry.FillRuleProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore