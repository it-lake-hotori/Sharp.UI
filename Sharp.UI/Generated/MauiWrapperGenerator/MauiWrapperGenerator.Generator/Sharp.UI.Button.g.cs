﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class Button : Microsoft.Maui.Controls.Button, Sharp.UI.IButton, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public Button() { }


        public Button(out Button button) 
        {
            button = this;
        }

        public Button(Action<Button> configure) 
        {
            configure(this);
        }

        public Button(out Button button, Action<Button> configure) 
        {
            button = this;
            configure(this);
        }

        public Button(string text) 
        {  
            this.Text = text;
        }

        public Button(string text, out Button button) 
        {  
            this.Text = text;;
            button = this;
        }

        public Button(string text, Action<Button> configure) 
        {  
            this.Text = text;
            configure(this);
        }

        public Button(string text, out Button button, Action<Button> configure) 
        {  
            this.Text = text;
            button = this;
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
