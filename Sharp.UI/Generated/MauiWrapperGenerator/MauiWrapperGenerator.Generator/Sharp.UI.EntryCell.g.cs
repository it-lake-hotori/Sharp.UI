﻿//
// <auto-generated>
//

#pragma warning disable CS8669


namespace Sharp.UI
{
    public partial class EntryCell : Microsoft.Maui.Controls.EntryCell, Sharp.UI.IEntryCell, IWrappedBindableObject
    {
        // ----- constructors -----

        public EntryCell() { }

        public EntryCell(out EntryCell entryCell) 
        {
            entryCell = this;
        }

        public EntryCell(Action<EntryCell> configure) 
        {
            configure(this);
        }

        public EntryCell(out EntryCell entryCell, Action<EntryCell> configure) 
        {
            entryCell = this;
            configure(this);
        }

        public EntryCell(string placeholder) 
        {  
            this.Placeholder = placeholder;
        }

        public EntryCell(string placeholder, out EntryCell entryCell) 
        {  
            this.Placeholder = placeholder;;
            entryCell = this;
        }

        public EntryCell(string placeholder, Action<EntryCell> configure) 
        {  
            this.Placeholder = placeholder;
            configure(this);
        }

        public EntryCell(string placeholder, out EntryCell entryCell, Action<EntryCell> configure) 
        {  
            this.Placeholder = placeholder;
            entryCell = this;
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

#pragma warning restore CS8669
