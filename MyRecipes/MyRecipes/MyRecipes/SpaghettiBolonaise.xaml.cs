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
    public partial class SpaghettiBolonaise : ContentPage
    {
        /*
        string SpagName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SpagName.txt");
        string Steve = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Steve.txt");
        string SpagIngred = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SpagIngred.txt");
        string SpagSteps = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SpagSteps.txt"); */
        public SpaghettiBolonaise()
        {
            InitializeComponent();

            /* if (File.Exists(SpagName))
            {

            }*/
        }
        
        void OnDelete(object sender, EventArgs e)
        {
            /*if (File.Exists(SpagName))
            {
                File.Delete(SpagName);
            }
            Editor.Text*/

        }

        void OnSave (object sender, EventArgs e)
        {
            /*File.WriteAllText(SpagName, Editor.(Recipe));
            File.WriteAllText(Steve, Editor.XProperty.PropertyName(Source));
            File.WriteAllText(SpagIngred, Editor.XProperty.PropertyName(Ingredients));
            File.WriteAllText(SpagSteps, Editor.XProperty.PropertyName(Steps));*/

        }
    }
}