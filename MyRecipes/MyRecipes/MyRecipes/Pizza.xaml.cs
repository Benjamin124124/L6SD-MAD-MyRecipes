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
    public partial class Pizza : ContentPage
    {
        public Pizza()
        {
            InitializeComponent();
        }

        void RecipeChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }

        void SourceChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }
        void IngredsChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }
        void StepsChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }
        void OnSave(object sender, EventArgs e)
        {
            
        }
        public void OnDelete(object sender, EventArgs e)
        {
            
        }
    }
}