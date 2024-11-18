namespace MauiLayoutss;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}
    private void OnButtonClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}