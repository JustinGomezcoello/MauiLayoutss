namespace MauiLayoutss;

public partial class Pagina1 : ContentPage
{
	public Pagina1()
	{
		InitializeComponent();
	}
    private void OnButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pagina2());
    }
}