﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace Sharp.UI
{
    using Sharp.UI.Internal;
    
    public static partial class BezierSegmentExtension
    {
        public static T Point1<T>(this T self,
            Microsoft.Maui.Graphics.Point point1)
            where T : Microsoft.Maui.Controls.Shapes.BezierSegment
        {
            self.SetValue(Microsoft.Maui.Controls.Shapes.BezierSegment.Point1Property, point1);
            return self;
        }
        
        public static T Point1<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Point>, IPropertyBuilder<Microsoft.Maui.Graphics.Point>> configure)
            where T : Microsoft.Maui.Controls.Shapes.BezierSegment
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.Shapes.BezierSegment.Point1Property);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Point1<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Point point1)
            where T : Microsoft.Maui.Controls.Shapes.BezierSegment
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.BezierSegment.Point1Property, Value = point1 });
            return self;
        }
        
        public static SettersContext<T> Point1<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Point>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Point>> configure)
            where T : Microsoft.Maui.Controls.Shapes.BezierSegment
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.BezierSegment.Point1Property);
            configure(context).Build();
            return self;
        }
        
        public static T Point2<T>(this T self,
            Microsoft.Maui.Graphics.Point point2)
            where T : Microsoft.Maui.Controls.Shapes.BezierSegment
        {
            self.SetValue(Microsoft.Maui.Controls.Shapes.BezierSegment.Point2Property, point2);
            return self;
        }
        
        public static T Point2<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Point>, IPropertyBuilder<Microsoft.Maui.Graphics.Point>> configure)
            where T : Microsoft.Maui.Controls.Shapes.BezierSegment
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.Shapes.BezierSegment.Point2Property);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Point2<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Point point2)
            where T : Microsoft.Maui.Controls.Shapes.BezierSegment
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.BezierSegment.Point2Property, Value = point2 });
            return self;
        }
        
        public static SettersContext<T> Point2<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Point>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Point>> configure)
            where T : Microsoft.Maui.Controls.Shapes.BezierSegment
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.BezierSegment.Point2Property);
            configure(context).Build();
            return self;
        }
        
        public static T Point3<T>(this T self,
            Microsoft.Maui.Graphics.Point point3)
            where T : Microsoft.Maui.Controls.Shapes.BezierSegment
        {
            self.SetValue(Microsoft.Maui.Controls.Shapes.BezierSegment.Point3Property, point3);
            return self;
        }
        
        public static T Point3<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Point>, IPropertyBuilder<Microsoft.Maui.Graphics.Point>> configure)
            where T : Microsoft.Maui.Controls.Shapes.BezierSegment
        {
            var context = new PropertyContext<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.Shapes.BezierSegment.Point3Property);
            configure(context).Build();
            return self;
        }
        
        public static SettersContext<T> Point3<T>(this SettersContext<T> self,
            Microsoft.Maui.Graphics.Point point3)
            where T : Microsoft.Maui.Controls.Shapes.BezierSegment
        {
            self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.BezierSegment.Point3Property, Value = point3 });
            return self;
        }
        
        public static SettersContext<T> Point3<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Point>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Point>> configure)
            where T : Microsoft.Maui.Controls.Shapes.BezierSegment
        {
            var context = new PropertySettersContext<Microsoft.Maui.Graphics.Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.BezierSegment.Point3Property);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore