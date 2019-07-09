using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        private void Ver(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pantallas.pantalla2());
          
        }

      

        private void Aviso(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "You have been alerted", "OK");
        }
    }
}
