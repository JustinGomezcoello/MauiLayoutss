namespace MauiLayoutss;

public partial class Pagina1 : ContentPage
{
	public Pagina1()
	{
		InitializeComponent();
	}
    private async void OnNavigateToFlexLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pagina2());
    }
}