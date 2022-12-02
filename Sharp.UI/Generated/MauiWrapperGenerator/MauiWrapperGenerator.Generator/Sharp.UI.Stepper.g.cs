﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class Stepper : Microsoft.Maui.Controls.Stepper, Sharp.UI.IStepper, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public Stepper() { }


        public Stepper(out Stepper stepper) 
        {
            stepper = this;
        }

        public Stepper(Action<Stepper> configure) 
        {
            configure(this);
        }

        public Stepper(out Stepper stepper, Action<Stepper> configure) 
        {
            stepper = this;
            configure(this);
        }

        public Stepper(double minimum, double maximum, double increment) 
        {  
            this.Minimum = minimum;
            this.Maximum = maximum;
            this.Increment = increment;
        }

        public Stepper(double minimum, double maximum, double increment, out Stepper stepper) 
        {  
            this.Minimum = minimum;
            this.Maximum = maximum;
            this.Increment = increment;;
            stepper = this;
        }

        public Stepper(double minimum, double maximum, double increment, Action<Stepper> configure) 
        {  
            this.Minimum = minimum;
            this.Maximum = maximum;
            this.Increment = increment;
            configure(this);
        }

        public Stepper(double minimum, double maximum, double increment, out Stepper stepper, Action<Stepper> configure) 
        {  
            this.Minimum = minimum;
            this.Maximum = maximum;
            this.Increment = increment;
            stepper = this;
            configure(this);
        }

        // ----- binding context -----

        public new object BindingContext
        {
            get => base.BindingContext;
            set
            {
                var mauiObject = MauiWrapper.GetObject<object>(value);
                base.BindingContext = mauiObject;
            }
        }
        

    }
}

#pragma warning restore CS0108
#pragma warning restore CS8625
#pragma warning restore CS8669
