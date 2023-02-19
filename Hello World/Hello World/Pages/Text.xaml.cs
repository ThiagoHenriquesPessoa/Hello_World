using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_World.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Text : ContentPage
    {
        public Text()
        {
            InitializeComponent();
        }

        private void btnGoBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}