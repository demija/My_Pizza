using MyPizza_PCL.Model;
using MyPizza_PCL.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace MyPizza_MOBILE.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductDetailsPage : Page
    {
        WebAPIHelper vrstePizzaService = new WebAPIHelper("http://localhost:50337/", "api/VrstePizza");

        public ProductDetailsPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            VrstePizza v = (VrstePizza)e.Parameter;

            MemoryStream ms = new MemoryStream(v.Slika);
            BitmapImage image = new BitmapImage();
            image.SetSourceAsync(ms.AsRandomAccessStream());

            pizzaVrstaLabel1.Text = v.Vrsta;
            pizzaVrstaLabel2.Text = v.Vrsta;

            pizzaOpisLabel.Text = v.Opis;
            pizzaSlika.Source = image;

            BindVelicine(v.VrstaPizzeId);
        }

        private void BindVelicine(int vrstaPizzeId)
        {
            HttpResponseMessage response = vrstePizzaService.GetActionResponse("VelPizze", vrstaPizzeId.ToString());

            if (response.IsSuccessStatusCode)
            {
                velicinaComboBox.ItemsSource = response.Content.ReadAsAsync<List<VelPizza>>().Result;
                velicinaComboBox.DisplayMemberPath = "Velicina";
            }
        }
    }
}
