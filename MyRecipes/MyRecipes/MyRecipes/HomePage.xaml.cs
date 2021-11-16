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

        async void OnAdd(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Add());
        }

        async void OnSpag(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SpaghettiBolonaise());
        }
        async void OnPizza(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pizza());
        }
        async void OnBurg(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Burger());
        }
        async void OnLasa(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Lasagne());
        }
        async void OnCrumb(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppleCrumble());
        }
    }
}
