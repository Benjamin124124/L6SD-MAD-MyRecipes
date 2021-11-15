using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyRecipes
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        async void OnSpag(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SpaghettiBolonaise());
        }
    }
}
