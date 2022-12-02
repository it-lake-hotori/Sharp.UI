﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class Slider : Microsoft.Maui.Controls.Slider, Sharp.UI.ISlider, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public Slider() { }


        public Slider(out Slider slider) 
        {
            slider = this;
        }

        public Slider(Action<Slider> configure) 
        {
            configure(this);
        }

        public Slider(out Slider slider, Action<Slider> configure) 
        {
            slider = this;
            configure(this);
        }

        public Slider(double minimum, double maximum) 
        {  
            this.Minimum = minimum;
            this.Maximum = maximum;
        }

        public Slider(double minimum, double maximum, out Slider slider) 
        {  
            this.Minimum = minimum;
            this.Maximum = maximum;;
            slider = this;
        }

        public Slider(double minimum, double maximum, Action<Slider> configure) 
        {  
            this.Minimum = minimum;
            this.Maximum = maximum;
            configure(this);
        }

        public Slider(double minimum, double maximum, out Slider slider, Action<Slider> configure) 
        {  
            this.Minimum = minimum;
            this.Maximum = maximum;
            slider = this;
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
