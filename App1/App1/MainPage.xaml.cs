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

btnNeo = new Button
{
    Image = ImageSource.FromFile("buttonIcon.png"),
    BackColor = Color.Transparent;
}
private void btnNeo_MouseEnter(object sender, EventArgs e)
{
    btnNeo.Image = picMouseOver;
}