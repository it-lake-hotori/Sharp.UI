﻿//
// <auto-generated> CodeMarkup.Maui.Generator.Extensions.Builder
//

#nullable enable
#pragma warning disable CS8601


namespace CodeMarkup.Maui
{
    using CodeMarkup.Maui.Internal;
    
    public static partial class FileImageSourceExtension
    {
        public static Microsoft.Maui.Controls.FileImageSource File(this Microsoft.Maui.Controls.FileImageSource self,
            string file)
        {
            self.SetValueOrAddSetter(Microsoft.Maui.Controls.FileImageSource.FileProperty, file);
            return self;
        }
        
        public static Microsoft.Maui.Controls.FileImageSource File(this Microsoft.Maui.Controls.FileImageSource self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        {
            var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.FileImageSource.FileProperty);
            configure(context).Build();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore