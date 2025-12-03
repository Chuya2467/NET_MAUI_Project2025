namespace Project2025;
[QueryProperty(nameof(MovieProperty), "Movie")]
public partial class MovieDetails : ContentPage
{
    public Movie MovieProperty { get; set; }

    public MovieDetails()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("...");
    }

    protected override async void OnAppearing()
    {
        BindingContext = MovieProperty;
        base.OnAppearing();
        await Task.Delay(50);
    }
}