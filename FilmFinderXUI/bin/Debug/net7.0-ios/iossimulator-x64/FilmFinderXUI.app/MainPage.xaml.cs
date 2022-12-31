namespace FilmFinderXUI;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void Search(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Search());
	}
}


