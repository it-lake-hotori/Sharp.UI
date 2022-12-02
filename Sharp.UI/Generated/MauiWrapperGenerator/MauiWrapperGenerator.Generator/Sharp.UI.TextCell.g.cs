﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class TextCell : Microsoft.Maui.Controls.TextCell, Sharp.UI.ITextCell, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public TextCell() { }


        public TextCell(out TextCell textCell) 
        {
            textCell = this;
        }

        public TextCell(Action<TextCell> configure) 
        {
            configure(this);
        }

        public TextCell(out TextCell textCell, Action<TextCell> configure) 
        {
            textCell = this;
            configure(this);
        }

        public TextCell(string text) 
        {  
            this.Text = text;
        }

        public TextCell(string text, out TextCell textCell) 
        {  
            this.Text = text;;
            textCell = this;
        }

        public TextCell(string text, Action<TextCell> configure) 
        {  
            this.Text = text;
            configure(this);
        }

        public TextCell(string text, out TextCell textCell, Action<TextCell> configure) 
        {  
            this.Text = text;
            textCell = this;
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
