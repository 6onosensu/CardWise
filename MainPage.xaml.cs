using Microsoft.Maui.Controls;

namespace CardWise
{
    public partial class MainPage : ContentPage
    {
        int toRepeat;
        public MainPage()
        {
            InitializeComponent();

            Label labelToRepeat = new Label
            {
                Text = "Words on repetition: ",
                FontSize = 30,
                TextColor = Colors.Blue,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
            };

            Label counterToRepeat = new Label
            {
                Text = toRepeat.ToString(),
                FontSize = 30,
                TextColor = Colors.Blue,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
            };

            Button repeatBtn = new Button
            {
                Text = "Repeat the words",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                TextColor = Colors.White,
                BackgroundColor = Colors.Blue,
                Padding = 20,
                Margin = 20,
            };

            VerticalStackLayout vsl = new VerticalStackLayout() { labelToRepeat, counterToRepeat, repeatBtn};

            Frame frame = new Frame
            {
                WidthRequest = 250,
                HeightRequest = 300,
            };
        }
    }
}
