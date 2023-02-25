﻿//
// <auto-generated>
//

#nullable enable


using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace ExampleApp
{
	public partial class CardView : IEnumerable
	{

        // ----- constructors -----

        public CardView(out CardView cardView) : this()
        {
            cardView = this;
        }

        public CardView(System.Action<CardView> configure) : this()
        {
            configure(this);
        }

        public CardView(out CardView cardView, System.Action<CardView> configure) : this()
        {
            cardView = this;
            configure(this);
        }

        // ----- single item container -----

        IEnumerator IEnumerable.GetEnumerator() { yield return this.ContentView; }
        public new void Add(Microsoft.Maui.Controls.View contentview) => this.ContentView = contentview;

        // ----- bindable properties -----

        public static readonly Microsoft.Maui.Controls.BindableProperty CardTitleProperty =
            Microsoft.Maui.Controls.BindableProperty.Create(
                nameof(CardTitle),
                typeof(string),
                typeof(ExampleApp.CardView),
                default(string));

        public string CardTitle
        {
            get => (string)GetValue(CardTitleProperty);
            set => SetValue(CardTitleProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty CardDescriptionProperty =
            Microsoft.Maui.Controls.BindableProperty.Create(
                nameof(CardDescription),
                typeof(string),
                typeof(ExampleApp.CardView),
                default(string));

        public string CardDescription
        {
            get => (string)GetValue(CardDescriptionProperty);
            set => SetValue(CardDescriptionProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty CardColorProperty =
            Microsoft.Maui.Controls.BindableProperty.Create(
                nameof(CardColor),
                typeof(Microsoft.Maui.Graphics.Color),
                typeof(ExampleApp.CardView),
                default(Microsoft.Maui.Graphics.Color));

        public Microsoft.Maui.Graphics.Color CardColor
        {
            get => (Microsoft.Maui.Graphics.Color)GetValue(CardColorProperty);
            set => SetValue(CardColorProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty BorderColorProperty =
            Microsoft.Maui.Controls.BindableProperty.Create(
                nameof(BorderColor),
                typeof(Microsoft.Maui.Graphics.Color),
                typeof(ExampleApp.CardView),
                default(Microsoft.Maui.Graphics.Color));

        public Microsoft.Maui.Graphics.Color BorderColor
        {
            get => (Microsoft.Maui.Graphics.Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty DescriptionStyleProperty =
            Microsoft.Maui.Controls.BindableProperty.Create(
                nameof(DescriptionStyle),
                typeof(Microsoft.Maui.Controls.Style),
                typeof(ExampleApp.CardView),
                default(Microsoft.Maui.Controls.Style));

        public Microsoft.Maui.Controls.Style DescriptionStyle
        {
            get => (Microsoft.Maui.Controls.Style)GetValue(DescriptionStyleProperty);
            set => SetValue(DescriptionStyleProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty ContentViewProperty =
            Microsoft.Maui.Controls.BindableProperty.Create(
                nameof(ContentView),
                typeof(Microsoft.Maui.Controls.View),
                typeof(ExampleApp.CardView),
                default(Microsoft.Maui.Controls.View));

        public Microsoft.Maui.Controls.View ContentView
        {
            get => (Microsoft.Maui.Controls.View)GetValue(ContentViewProperty);
            set => SetValue(ContentViewProperty, value);
        }
        
        public static readonly Microsoft.Maui.Controls.BindableProperty ButtonTitleProperty =
            Microsoft.Maui.Controls.BindableProperty.Create(
                nameof(ButtonTitle),
                typeof(string),
                typeof(ExampleApp.CardView),
                default(string));

        public string ButtonTitle
        {
            get => (string)GetValue(ButtonTitleProperty);
            set => SetValue(ButtonTitleProperty, value);
        }
        
    }
}

#nullable restore