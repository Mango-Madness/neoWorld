using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var final = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(10, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(100, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
            };

            ImageButton btnNeo = NewMethod();

            //btnNeo.Image = ImageSource.FromFile(@"buttonIcon_final");
            //btnNeo.Image = ImageSource.FromFile("buttonIcon_final.png");

            final.Children.Add(btnNeo, left: 0, top: 0);
            Content = final;
        }

        private static ImageButton NewMethod()
        {
            return new ImageButton
            {
                Source = ImageSource.FromFile(@"buttonIcon_final.png"),
                Aspect = Aspect.AspectFill
            };
        }
    }
}
/**
View CreateButto(string text)
{


    var btnNeo = new Button

    {
        Text = text,
        btnNeo.Image = ImageSource.FromFile("buttonIcon.png"),
       // Aspect = Aspect.AspectFill
    };

    btnNeo.Clicked += (sender, args);

    return btnNeo;

}
    **/