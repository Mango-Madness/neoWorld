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
        Source = ImageSource.FromFile("C:\Users\Karim Hackmann\source\repos\Neuer Ordner\App1\App1.Android\Resources\drawable\buttonIcon.png"),
        Aspect = Aspect.AspectFill
    };

    btnNeo.Clicked += (sender, args);

    return btnNeo;

}