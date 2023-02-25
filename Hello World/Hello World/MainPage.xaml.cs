using System;
using Xamarin.Forms;

namespace Hello_World
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello", "Hello, " + txtName.Text + "!", "OK");
        }

        private void btnImagem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.Imagem());
        }

        private void btnTexti_Clicked(object sender, EventArgs e)
        {
            var Navigat = new Pages.Text();
            Navigation.PushModalAsync(Navigat);
        }

        private void btnEvents_Pressed(object sender, EventArgs e)
        {
            lblEvents.Text = "held down";
        }

        private void btnEvents_Released(object sender, EventArgs e)
        {
            lblEvents.Text = "Released";
        }
    }
}
