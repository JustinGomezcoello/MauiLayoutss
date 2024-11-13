namespace MauiLayoutss;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}
    private async void OnNavigateToGridLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}