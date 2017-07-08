using System;
using MyPizza_PCL.Model;
using MyPizza_PCL.Util;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System.Net.Http;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace MyPizza_MOBILE.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderDetailsPage : Page
    {
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:50337/", "api/Narudzbe");
        Racuni n;

        public OrderDetailsPage()
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
            n = (Racuni)e.Parameter;

            BindNarudzbeDetails(n.NarudzbaId);
        }

        private void BindNarudzbeDetails(int narudzbaId)
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("GetNarudzbeDetails", narudzbaId.ToString());

            if (response.IsSuccessStatusCode)
            {
                List<NarudzbeDetalji> narudzbeDetalji = response.Content.ReadAsAsync<List<NarudzbeDetalji>>().Result;
                ObservableCollection<NarudzbeDetalji> obsPizze = new ObservableCollection<NarudzbeDetalji>();

                for (int i = 0; i < narudzbeDetalji.Count; i++)
                {
                    obsPizze.Add(narudzbeDetalji[i]);
                }

                nardzbaListView.ItemsSource = obsPizze;
            }
        }
    }
}
