using MyPizza_PCL.Model;
using MyPizza_PCL.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace MyPizza_MOBILE.Products
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShoppingCartPage : Page
    {
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:50337/", "api/Narudzbe");
        WebAPIHelper narudzbePizzeService = new WebAPIHelper("http://localhost:50337/", "api/NarudzbePizze");
        WebAPIHelper dodatniSastojciPizzeService = new WebAPIHelper("http://localhost:50337/", "api/DodatniSastojci");

        List<NarudzbePizze> narPizze;
        decimal cijenaSaPdv;

        public ShoppingCartPage()
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
            BindShoppingCart();
        }

        private void BindShoppingCart()
        {
            ObservableCollection<NarudzbePizze> obsPizze = new ObservableCollection<NarudzbePizze>();

            for (int i = 0; i < Global.narudzbePizze.Count; i++)
            {
                obsPizze.Add(Global.narudzbePizze[i]);
            }

            adresaZaDostavu.Text = Global.prijavljeniKorisnik.Ulica;
            kontaktTelefon.Text = Global.prijavljeniKorisnik.BrojTelefona;

            cijenaSaPdv = 0;

            if (Global.narudzbePizze != null)
            {
                narucenePizzeListView.ItemsSource = obsPizze;

                for (int i = 0; i < Global.narudzbePizze.Count; i++)
                {
                    decimal dodatniSastojciCijena = 0;

                    for (int j = 0; j < Global.narudzbePizze[i].DodatniSastojci.Count; j++)
                    {
                        dodatniSastojciCijena += Global.narudzbePizze[i].DodatniSastojci[j].DodatnaCijena;
                    }

                    var cije = Global.narudzbePizze[i].Cijena;
                    var kol = Global.narudzbePizze[i].Kolicina;

                    cijenaSaPdv += (decimal)((Global.narudzbePizze[i].Cijena + dodatniSastojciCijena) * Global.narudzbePizze[i].Kolicina);
                }
            }

            ukupnaCijenaIznos.Text = cijenaSaPdv.ToString() + " KM";
        }

        private void narucenePizzeListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            NarudzbePizze np = (NarudzbePizze)e.ClickedItem;
            Global.narudzbePizze.Where(d => d.PizzaId == np.PizzaId).First().Kolicina -= 1;

            if (np.Kolicina <= 0)
            {
                Global.narudzbePizze.Remove(np);
            }

            BindShoppingCart();
        }

        private void zavrsiNarudzbu_Click(object sender, RoutedEventArgs e)
        {
            if (Global.narudzbePizze.Count == 0)
            {
                MessageDialog msg = new MessageDialog("Korpa je prazna!");
                msg.ShowAsync();
            }
            else
            {
                Narudzbe n = new Narudzbe();
                n.KorisnikId = Global.prijavljeniKorisnik.KorisnikId;
                n.StatusNarudzbeId = 1;
                n.DatumNarudzbe = DateTime.Now;
                n.OtkazanaNarudzba = false;
                n.AdresaZaDostavu = adresaZaDostavu.Text;
                n.BrojTelefona = kontaktTelefon.Text;

                HttpResponseMessage response = narudzbeService.PostResponse(n);

                if (response.IsSuccessStatusCode)
                {
                    int narudzbaId = response.Content.ReadAsAsync<Narudzbe>().Result.NarudzbaId;

                    for (int i = 0; i < Global.narudzbePizze.Count; i++)
                    {
                        NarudzbePizze np = new NarudzbePizze();
                        np.NarudzbaId = narudzbaId;
                        np.PizzaId = Global.narudzbePizze[i].PizzaId;
                        np.Kolicina = Global.narudzbePizze[i].Kolicina;
                        np.Cijena = Global.narudzbePizze[i].Cijena;

                        HttpResponseMessage responsenp = narudzbePizzeService.PostResponse(np);

                        if (responsenp.IsSuccessStatusCode)
                        {
                            if (Global.narudzbePizze[i].DodatniSastojci != null)
                            {
                                int narudzbapId = responsenp.Content.ReadAsAsync<NarudzbePizze>().Result.NarudzbaPizzaId;

                                for (int j = 0; j < Global.narudzbePizze[i].DodatniSastojci.Count; j++)
                                {
                                    Sastojci s = new Sastojci();
                                    s.NarudzbaPizzaId = narudzbapId;
                                    s.SastojakId = Global.narudzbePizze[i].DodatniSastojci[j].SastojakId;

                                    HttpResponseMessage responseDs = dodatniSastojciPizzeService.PostResponse(s);
                                }
                            }
                        }
                    }

                    MessageDialog msg = new MessageDialog("Narudžba uspješno kompletirana!");
                    msg.ShowAsync();

                    Global.narudzbePizze = null;
                    Frame.Navigate(typeof(AllProductsPage));
                }
            }
        }
    }
}
