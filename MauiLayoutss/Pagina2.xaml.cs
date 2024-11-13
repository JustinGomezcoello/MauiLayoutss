namespace MauiLayoutss;

public partial class Pagina2 : ContentPage
{
	public Pagina2()
	{
		InitializeComponent();
	}
    private async void OnImageTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pagina3());
    }
}