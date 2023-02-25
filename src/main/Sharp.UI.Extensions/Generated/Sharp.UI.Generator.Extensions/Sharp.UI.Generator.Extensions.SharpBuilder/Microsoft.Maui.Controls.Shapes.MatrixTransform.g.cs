﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class MatrixTransformExtension
    {
        public static T Matrix<T>(this T self,
            Microsoft.Maui.Controls.Shapes.Matrix matrix)
            where T : Microsoft.Maui.Controls.Shapes.MatrixTransform
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.MatrixTransform.MatrixProperty, matrix);
            return self;
        }
        
        public static T Matrix<T>(this T self,
            System.Func<ValueBuilder<Microsoft.Maui.Controls.Shapes.Matrix>, ValueBuilder<Microsoft.Maui.Controls.Shapes.Matrix>> buildValue)
            where T : Microsoft.Maui.Controls.Shapes.MatrixTransform
        {
            var builder = buildValue(new ValueBuilder<Microsoft.Maui.Controls.Shapes.Matrix>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(Microsoft.Maui.Controls.Shapes.MatrixTransform.MatrixProperty, builder.GetValue());
            return self;
        }
        
        public static T Matrix<T>(this T self,
            System.Func<BindingBuilder<Microsoft.Maui.Controls.Shapes.Matrix>, BindingBuilder<Microsoft.Maui.Controls.Shapes.Matrix>> buildBinding)
            where T : Microsoft.Maui.Controls.Shapes.MatrixTransform
        {
            var builder = buildBinding(new BindingBuilder<Microsoft.Maui.Controls.Shapes.Matrix>(self, Microsoft.Maui.Controls.Shapes.MatrixTransform.MatrixProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore
