using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ScrollView scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Margin = new Thickness(10),
                Content = new Label
                {
                    Text = "Sometimes page content fits entirely on " +
                           "the page. That's very convenient. But " +
                           "on many occasions, the content of the page " +
                           "is much too large for the page, or only " +
                           "becomes available at runtime." +
                           "\n\n" +
                           "For cases such as these, the ScrollView " +
                           "provides a solution. Simply set its " +
                           "Content property to your content \u2014 in this " +
                           "case a Label but in the general case very " +
                           "likely a Layout derivative with multiple " +
                           "children \u2014 and the ScrollView provides " +
                           "scrolling with the distinctive look and touch " +
                           "familiar to the user." +
                           "\n\n" +
                           "The ScrollView is also capable of " +
                           "horizontal scrolling, and while that's " +
                           "usually not as common as vertical scrolling, " +
                           "sometimes it comes in handy." +
                           "\n\n" +
                           "Most often, the content of a ScrollView is " +
                           "a StackLayout. Whenever you're using a " +
                           "StackLayout with a number of items determined " +
                           "only at runtime, you should probably put it in " +
                           "a ScrollView just to be sure your stuff doesn't " +
                           "go running off the bottom of the screen.",

                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                }
            };
            var top = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition {Height = new GridLength(100, GridUnitType.Star)},
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(0.5, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition { Width = new GridLength(0.5, GridUnitType.Star)},
                },
                
            };
            top.Children.Add(CreateButto("Newest"), left: 1, top: 0);
            top.Children.Add(CreateButto("O"), left: 2, top: 0);
            top.Padding = new Thickness(0);
            

            // Build the page.
            Title = "ScrollBar Demo";
            var final = new StackLayout
            {
                Children =
                {
                    scrollView,
                    top
                    
                }
            };
            final.Padding = 0;

            Content = final;
        }
        Label zeit;
        View CreateButto(string text)
        {
            var btn = new Button
            {
                Text = text,
                TextColor = Color.Yellow,
                BackgroundColor = Color.Blue,
                Font = Font.SystemFontOfSize(15, FontAttributes.Bold)
            };

            btn.Clicked += (sender, args) =>
            {
                if (((Button)sender).Text == "Oldest")
                {
                    btn.Text = "Newest";
                }
                else if (((Button)sender).Text == "Newest")
                {
                    btn.Text = "Oldest";
                }
                
                if (((Button)sender).Text == "O")
                {
                    btn.Text = "O";
                }
            };


            return btn;
        }

    }

}
