using Android.Content.Res;
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
        }
    }
}

View CreateButton(string text)
{


    var btnNeo = new Button

    {
        Source = ImageSource.FromFile("buttonIcon.png"),
        Aspect = Aspect.AspectFill
    };

    btnNeo.Clicked += (sender, args);

    return btnNeo;

}