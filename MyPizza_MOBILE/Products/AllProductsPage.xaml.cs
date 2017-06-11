﻿using MyPizza_PCL.Model;
using MyPizza_PCL.Util;
using System.Collections.Generic;
using System.Net.Http;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace MyPizza_MOBILE.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AllProductsPage : Page
    {
        WebAPIHelper vrstePizzaService = new WebAPIHelper("http://localhost:50337/", "api/VrstePizza");

        public AllProductsPage()
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
            if (Global.narudzbePizze == null)
            {
                Global.narudzbePizze = new List<NarudzbePizze>();
            }

            BindVrstePizza();

            ///////////////////////////////////////////////////
            if (Global.narudzbePizze.Count == 0)
            {
                korpaButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                korpaButton.Visibility = Visibility.Visible;
            }

            narudzbePizzaLabel.Text = Global.narudzbePizze.Count.ToString();
            ///////////////////////////////////////////////////
        }

        private void BindVrstePizza()
        {
            HttpResponseMessage response = vrstePizzaService.GetResponse("AktivnePizze");

            if (response.IsSuccessStatusCode)
            {
                svePizzeList.ItemsSource = response.Content.ReadAsAsync<List<VrstePizza>>().Result;
            }
        }

        private void svePizzeList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(ProductDetailsPage), ((VrstePizza)e.ClickedItem));
        }

        private void menuListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (menuListView.SelectedIndex == 3)
            {
                Application.Current.Exit();
            }
        }
    }
}
