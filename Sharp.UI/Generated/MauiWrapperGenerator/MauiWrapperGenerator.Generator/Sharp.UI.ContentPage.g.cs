﻿//
// <auto-generated>
//

#pragma warning disable CS0108
#pragma warning disable CS8625
#pragma warning disable CS8669


using System.Collections;
using System.Collections.ObjectModel;


namespace Sharp.UI
{
    public partial class ContentPage : Microsoft.Maui.Controls.ContentPage, Sharp.UI.IContentPage, IEnumerable, IWrappedBindableObject
    {
        // ----- constructors -----
        

        public ContentPage() { }


        public ContentPage(out ContentPage contentPage) 
        {
            contentPage = this;
        }

        public ContentPage(Action<ContentPage> configure) 
        {
            configure(this);
        }

        public ContentPage(out ContentPage contentPage, Action<ContentPage> configure) 
        {
            contentPage = this;
            configure(this);
        }

        public ContentPage(string title) 
        {  
            this.Title = title;
        }

        public ContentPage(string title, out ContentPage contentPage) 
        {  
            this.Title = title;;
            contentPage = this;
        }

        public ContentPage(string title, Action<ContentPage> configure) 
        {  
            this.Title = title;
            configure(this);
        }

        public ContentPage(string title, out ContentPage contentPage, Action<ContentPage> configure) 
        {  
            this.Title = title;
            contentPage = this;
            configure(this);
        }

        // ----- single item container -----

        public IEnumerator GetEnumerator() { yield return this.Content; }

        public void Add(Microsoft.Maui.Controls.View content) => this.Content = content;

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
