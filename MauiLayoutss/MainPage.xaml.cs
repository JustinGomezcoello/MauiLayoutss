﻿namespace MauiLayoutss
{
    public partial class MainPage : ContentPage
    {
       

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
