using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoundedEntry.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnaSayfa : ContentPage
    {
        public AnaSayfa()
        {
            InitializeComponent();
            RoundedEntry.CustomRenderers.RoundedEntry roundedEntry = new CustomRenderers.RoundedEntry();

            Content = new StackLayout
            {
                BackgroundColor = Color.Blue,
                Padding = new Thickness(20, 20, 20, 20),

                Children =
                {
                    roundedEntry
                }
            };

            
        }
    }
}