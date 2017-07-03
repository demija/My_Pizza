using MyPizza_PCL.Util;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using MyPizza_PCL.Model;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Collections.Generic;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace MyPizza_MOBILE.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrdersPage : Page
    {
        WebAPIHelper racuniService = new WebAPIHelper("http://localhost:50337/", "api/Racuni");

        public OrdersPage()
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
            BindUserOrders();
        }

        private void BindUserOrders()
        {
            HttpResponseMessage response = racuniService.GetActionResponse("GetRacuniByUser", Global.prijavljeniKorisnik.KorisnikId.ToString());

            if (response.IsSuccessStatusCode)
            {
                List<Racuni> racuniKorisnika = response.Content.ReadAsAsync<List<Racuni>>().Result;
                ObservableCollection<Racuni> obsPizze = new ObservableCollection<Racuni>();

                for (int i = 0; i < racuniKorisnika.Count; i++)
                {
                    obsPizze.Add(racuniKorisnika[i]);
                }

                narucenePizzeListView.ItemsSource = obsPizze;
            }
        }
    }
}
