using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRecipes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpaghettiBolonaise : ContentPage
    {
        public SpaghettiBolonaise()
        {
            InitializeComponent();
            
        }

        async void OnDelete(object sender, EventArgs e)
        {
            this.Navigation.RemovePage(this.Navigation.NavigationStack[this.Navigation.NavigationStack.Count - 2]);
            await this.Navigation.PopAsync();
        }

        void NameTextChanged (object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }

        void SrcTextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }

        void IngTextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }

        void StepsTextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }
    }
}