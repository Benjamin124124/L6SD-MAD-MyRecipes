using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRecipes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Burger : ContentPage
    {
        public Burger()
        {
            InitializeComponent();

            /*if (File.Exists(BurgerName))
            {
                Editor.Text = File.ReadAllText(BurgerName);
            }*/
        }

        

        void OnSave(object sender, EventArgs e)
        {

        }

        void OnDelete(object sender, EventArgs e)
        {

        }
    }
}