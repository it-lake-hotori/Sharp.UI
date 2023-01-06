namespace Sharp.UI
{
    [SharpObject(typeof(Microsoft.Maui.Controls.Trigger))]
    public partial class Trigger
    {
        public Trigger(BindableProperty property, object value) : base(property.DeclaringType)
        {
            Property = property; Value = value;
        }
    }

    [SharpObject(typeof(Microsoft.Maui.Controls.DataTrigger))]
    public partial class DataTrigger
    {
        public DataTrigger(Type type) : base(type) { }
    }

    public class DataTrigger<T> : DataTrigger
    {
        public DataTrigger(Func<Binding, Binding> bindingBuilder, object value) : base(typeof(T))
        {
            Binding = bindingBuilder(new Binding());
            Value = value;
        }
    }

    [SharpObject(typeof(Microsoft.Maui.Controls.EventTrigger))]
    public partial class EventTrigger
    {
        public EventTrigger(string @event)
        {
            Event = @event;
        }
    }

    [SharpObject(typeof(Microsoft.Maui.Controls.MultiTrigger))]
    public partial class MultiTrigger
    {
        public MultiTrigger(Type type) : base(type) { }
    }

    public class MultiTrigger<T> : MultiTrigger
    {
        public MultiTrigger() : base(typeof(T))
        {

        }
    }

    [SharpObject(typeof(Microsoft.Maui.Controls.BindingCondition))]
    public partial class BindingCondition
    {
        public BindingCondition(Func<Binding, Binding> bindingBuilder, object value) : this()
        {
            Binding = bindingBuilder(new Binding());
            Value = value;
        }
    }

    [SharpObject(typeof(Microsoft.Maui.Controls.PropertyCondition))]
    public partial class PropertyCondition
    {
        public PropertyCondition(BindableProperty property, object value) : this()
        {
            Property = property; Value = value;
        }
    }

    [SharpObject(typeof(Microsoft.Maui.Controls.StateTrigger))]
    public partial class StateTrigger { }

    [SharpObject(typeof(Microsoft.Maui.Controls.AdaptiveTrigger))]
    public partial class AdaptiveTrigger { }

    [SharpObject(typeof(Microsoft.Maui.Controls.CompareStateTrigger))]
    public partial class CompareStateTrigger
    {
        public CompareStateTrigger(Func<Binding, Binding> bindingBuilder, object value)            
        {
            Property = bindingBuilder(new Binding());
            Value = value;
        }
    }

    [SharpObject(typeof(Microsoft.Maui.Controls.DeviceStateTrigger))]
    public partial class DeviceStateTrigger { }

    [SharpObject(typeof(Microsoft.Maui.Controls.OrientationStateTrigger))]
    public partial class OrientationStateTrigger { }
}