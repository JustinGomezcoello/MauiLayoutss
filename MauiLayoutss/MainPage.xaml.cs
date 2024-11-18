namespace MauiLayoutss
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina1());
        }
    }

}
