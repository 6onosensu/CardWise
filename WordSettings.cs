namespace CardWise;

public class WordSettings : ContentPage
{
	public WordSettings(int i)
	{
		

		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}

	private void DeleteWord()
	{

	}
	private void UpdateWord()
	{

	}

}