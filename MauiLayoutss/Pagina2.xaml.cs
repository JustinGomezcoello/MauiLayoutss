namespace MauiLayoutss;

public partial class Pagina2 : ContentPage
{
	public Pagina2()
	{
		InitializeComponent();
	}
    private void OnElementTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pagina3());
    }
}