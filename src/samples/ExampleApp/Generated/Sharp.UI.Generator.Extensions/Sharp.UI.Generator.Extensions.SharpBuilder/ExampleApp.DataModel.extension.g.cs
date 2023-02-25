﻿//
// <auto-generated> Sharp.UI.Generator.Extensions.SharpBuilder
//

#nullable enable
#pragma warning disable CS8601


namespace ExampleApp
{
    using Sharp.UI.Internal;
    using Sharp.UI;
    
    public static partial class DataModelExtension
    {
        public static T Id<T>(this T self,
            int id)
            where T : ExampleApp.DataModel
        {
            self.SetValueOrAddSetter(ExampleApp.DataModel.IdProperty, id);
            return self;
        }
        
        public static T Id<T>(this T self,
            System.Func<ValueBuilder<int>, ValueBuilder<int>> buildValue)
            where T : ExampleApp.DataModel
        {
            var builder = buildValue(new ValueBuilder<int>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(ExampleApp.DataModel.IdProperty, builder.GetValue());
            return self;
        }
        
        public static T Id<T>(this T self,
            System.Func<BindingBuilder<int>, BindingBuilder<int>> buildBinding)
            where T : ExampleApp.DataModel
        {
            var builder = buildBinding(new BindingBuilder<int>(self, ExampleApp.DataModel.IdProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Name<T>(this T self,
            string name)
            where T : ExampleApp.DataModel
        {
            self.SetValueOrAddSetter(ExampleApp.DataModel.NameProperty, name);
            return self;
        }
        
        public static T Name<T>(this T self,
            System.Func<ValueBuilder<string>, ValueBuilder<string>> buildValue)
            where T : ExampleApp.DataModel
        {
            var builder = buildValue(new ValueBuilder<string>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(ExampleApp.DataModel.NameProperty, builder.GetValue());
            return self;
        }
        
        public static T Name<T>(this T self,
            System.Func<BindingBuilder<string>, BindingBuilder<string>> buildBinding)
            where T : ExampleApp.DataModel
        {
            var builder = buildBinding(new BindingBuilder<string>(self, ExampleApp.DataModel.NameProperty));
            builder.BindProperty();
            return self;
        }
        
        public static T Admin<T>(this T self,
            bool admin)
            where T : ExampleApp.DataModel
        {
            self.SetValueOrAddSetter(ExampleApp.DataModel.AdminProperty, admin);
            return self;
        }
        
        public static T Admin<T>(this T self,
            System.Func<ValueBuilder<bool>, ValueBuilder<bool>> buildValue)
            where T : ExampleApp.DataModel
        {
            var builder = buildValue(new ValueBuilder<bool>());
            if (builder.ValueIsSet()) self.SetValueOrAddSetter(ExampleApp.DataModel.AdminProperty, builder.GetValue());
            return self;
        }
        
        public static T Admin<T>(this T self,
            System.Func<BindingBuilder<bool>, BindingBuilder<bool>> buildBinding)
            where T : ExampleApp.DataModel
        {
            var builder = buildBinding(new BindingBuilder<bool>(self, ExampleApp.DataModel.AdminProperty));
            builder.BindProperty();
            return self;
        }
        
    }
}

#pragma warning restore CS8601
#nullable restore