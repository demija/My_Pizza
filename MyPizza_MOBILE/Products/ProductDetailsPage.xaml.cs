using MyPizza_PCL.Model;
using MyPizza_PCL.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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
        WebAPIHelper ocjeneService = new WebAPIHelper("http://localhost:50337/", "api/Ocjene");
        WebAPIHelper sastojciService = new WebAPIHelper("http://localhost:50337/", "api/Sastojci");

        List<VelPizza> velPizza;
        List<Ocjene> listaOcjena;
        List<Sastojci> sviSastojci;
        List<Sastojci> odabraniSastojci;

        VrstePizza v;
        Ocjene o;
        Korisnici k = Global.prijavljeniKorisnik;
        NarudzbePizze naPizza = new NarudzbePizze();

        int kolicinaPizza = 1;
        int likesNumber = 0;
        int dislikeNumber = 0;

        public ProductDetailsPage()
        {
            this.InitializeComponent();

            PrikaziOcjene();

            ocjenaButton.Visibility = Visibility.Collapsed;
        }

        private void PrikaziOcjene()
        {
            LikeCount.Text = likesNumber.ToString();
            DislikeCount.Text = dislikeNumber.ToString();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            v = (VrstePizza)e.Parameter;

            MemoryStream ms = new MemoryStream(v.Slika);
            BitmapImage image = new BitmapImage();
            image.SetSourceAsync(ms.AsRandomAccessStream());

            pizzaVrstaLabel1.Text = v.Vrsta;
            pizzaVrstaLabel2.Text = v.Vrsta;

            pizzaOpisLabel.Text = v.Opis;
            pizzaSlika.Source = image;

            BindVelicine(v.VrstaPizzeId);
            BindOcjene(v.VrstaPizzeId);
            BindSastojci(v.VrstaPizzeId);

            FormirajCijenu();
        }

        private void BindSastojci(int vrstaPizzeId)
        {
            HttpResponseMessage response = sastojciService.GetActionResponse("VrstaSastojci", vrstaPizzeId.ToString());

            if (response.IsSuccessStatusCode)
            {
                sviSastojci = response.Content.ReadAsAsync<List<Sastojci>>().Result;
                dodatniSastojciListView.ItemsSource = sviSastojci;
                dodatniSastojciListView.DisplayMemberPath = "Sastojak";
            }
        }

        private void BindVelicine(int vrstaPizzeId)
        {
            HttpResponseMessage response = vrstePizzaService.GetActionResponse("VelPizze", vrstaPizzeId.ToString());

            if (response.IsSuccessStatusCode)
            {
                velPizza = response.Content.ReadAsAsync<List<VelPizza>>().Result;
                velicinaComboBox.ItemsSource = velPizza;
                velicinaComboBox.DisplayMemberPath = "Velicina";
            }
        }

        private void BindOcjene(int vrstaPizzeId)
        {
            HttpResponseMessage response = ocjeneService.GetActionResponse("OcjeneVrsta", vrstaPizzeId.ToString());

            if (response.IsSuccessStatusCode)
            {
                listaOcjena = response.Content.ReadAsAsync<List<Ocjene>>().Result;
            }

            IzracunajOcjene();
        }

        private void IzracunajOcjene()
        {
            for (int i = 0; i < listaOcjena.Count; i++)
            {
                if (listaOcjena[i].SvidjaSe)
                {
                    ++likesNumber;
                }

                if (listaOcjena[i].NeSvidjaSe)
                {
                    ++dislikeNumber;
                }
            }

            PrikaziOcjene();
        }

        private void velicinaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FormirajCijenu();
        }

        private void dodajKolicinu_Click(object sender, RoutedEventArgs e)
        {
            ++kolicinaPizza;

            FormirajCijenu();
        }

        private void oduzmiKolicinu_Click(object sender, RoutedEventArgs e)
        {
            if(kolicinaPizza > 1)
            {
                --kolicinaPizza;
            }

            FormirajCijenu();
        }

        private void FormirajCijenu()
        {
            if (odabraniSastojci == null)
            {
                odabraniSastojci = new List<Sastojci>();
            }

            PrikaziKolicinu();

            if (velicinaComboBox.SelectedIndex != -1)
            {
                VelPizza velPizza = (VelPizza)velicinaComboBox.SelectedItem;

                decimal cijena = velPizza.Cijena;
                naPizza.Cijena = cijena;

                naPizza.PizzaId = velPizza.PizzaId;
                naPizza.Velicina = velPizza.Velicina;

                if (odabraniSastojci.Count > 0)
                {
                    for (int i = 0; i < odabraniSastojci.Count; i++)
                    {
                        cijena += (decimal)odabraniSastojci[i].DodatnaCijena;
                    }
                }

                CijenaIznos.Text = (cijena * kolicinaPizza).ToString() + " KM";
            }
        }

        private void PrikaziKolicinu()
        {
            kolicnaOpis.Text = kolicinaPizza.ToString();
        }

        private void likeButton_Click(object sender, RoutedEventArgs e)
        {
            CreateInstanceOcjene();

            if (likeButton.IsChecked == true)
            {
                o.SvidjaSe = true;
                o.Ocjena = 5;
                ++likesNumber;
                LikeCount.Text = likesNumber.ToString();
                ocijenaLabel.Text = "5";
                ocjenaButton.Visibility = Visibility.Visible;
            }
            else
            {
                o.SvidjaSe = false;
                --likesNumber;
                LikeCount.Text = likesNumber.ToString();
                ocijenaLabel.Text = "";
                ocjenaButton.Visibility = Visibility.Collapsed;
            }
        }

        private void dislikeButton_Click(object sender, RoutedEventArgs e)
        {
            CreateInstanceOcjene();

            if (dislikeButton.IsChecked == true)
            {
                o.NeSvidjaSe = true;
                o.Ocjena = 1;
                ++dislikeNumber;
                DislikeCount.Text = dislikeNumber.ToString();
                ocijenaLabel.Text = "1";
                ocjenaButton.Visibility = Visibility.Visible;
            }
            else
            {
                o.NeSvidjaSe = false;
                --dislikeNumber;
                DislikeCount.Text = dislikeNumber.ToString();
                ocijenaLabel.Text = "";
                ocjenaButton.Visibility = Visibility.Collapsed;
            }
        }

        private async void dodajUKorpuButton_Click(object sender, RoutedEventArgs e)
        {
            if (velicinaComboBox.SelectedIndex == -1)
            {
                MessageDialog msg = new MessageDialog("Odaberi veličinu!");
                await msg.ShowAsync();
            }
            else
            {
                PizzaUKorpu();
                Frame.Navigate(typeof(AllProductsPage));
            }
        }

        private async void zavrsiKupovinuButton_Click(object sender, RoutedEventArgs e)
        {
            if (velicinaComboBox.SelectedIndex == -1)
            {
                MessageDialog msg = new MessageDialog("Odaberi veličinu!");
                await msg.ShowAsync();
            }
            else
            {
                PizzaUKorpu();
                Frame.Navigate(typeof(ShoppingCartPage));
            }
        }

        private void PizzaUKorpu()
        {
            MessageDialog msg = new MessageDialog("Pizza dodana u korpu!");
            msg.ShowAsync();

            UpisiOcjene();

            naPizza.Kolicina = kolicinaPizza;
            naPizza.DodatniSastojci = odabraniSastojci;
            naPizza.Vrsta = v.Vrsta;

            for (int i = 0; i < odabraniSastojci.Count; i++)
            {
                naPizza.dodajtniSastojciOpis += odabraniSastojci[i].Sastojak + ", ";
            }

            Global.narudzbePizze.Add(naPizza);
        }

        public void UpisiOcjene()
        {
            CreateInstanceOcjene();

            o.KorisnikId = k.KorisnikId;
            o.DatumOcjene = DateTime.Now;
            o.VrstaPizzeId = v.VrstaPizzeId;

            if (o.SvidjaSe || o.NeSvidjaSe)
            {
                HttpResponseMessage response = ocjeneService.PostResponse(o);
            }
        }

        public void CreateInstanceOcjene()
        {
            if (o == null)
            {
                o = new Ocjene();
            }
        }

        private void dodatniSastojciListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dodatniSastojciListView.SelectedItems != null)
            {
                odabraniSastojci = new List<Sastojci>();

                for (int i = 0; i < dodatniSastojciListView.SelectedItems.Count; i++)
                {
                    Sastojci s = new Sastojci();
                    s = (Sastojci)dodatniSastojciListView.SelectedItems[i];

                    if (odabraniSastojci.IndexOf(s) == -1)
                    {
                        odabraniSastojci.Add(s);
                    }
                }

                FormirajCijenu();
            }
        }

        private void ocjeneListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ocjeneListView.SelectedIndex == 0)
            {
                o.Ocjena = 5;
                ocijenaLabel.Text = "5";
            }
            else if (ocjeneListView.SelectedIndex == 1)
            {
                o.Ocjena = 4;
                ocijenaLabel.Text = "4";
            }
            else if (ocjeneListView.SelectedIndex == 2)
            {
                o.Ocjena = 3;
                ocijenaLabel.Text = "3";
            }
            else if (ocjeneListView.SelectedIndex == 3)
            {
                o.Ocjena = 2;
                ocijenaLabel.Text = "2";
            }
            else if (ocjeneListView.SelectedIndex == 4)
            {
                o.Ocjena = 1;
                ocijenaLabel.Text = "1";
            }
        }
    }
}