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
using Windows.UI.Popups;
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
        WebAPIHelper ocjeneService = new WebAPIHelper("http://localhost:50337/", "api/Ocjene");
        List<VelPizza> velPizza;
        List<Ocjene> listaOcjena;
        VrstePizza v;
        Ocjene o;
        Korisnici k = Global.prijavljeniKorisnik;
        int kolicinaPizza = 1;
        int likesNumber = 0;
        int dislikeNumber = 0;

        public ProductDetailsPage()
        {
            this.InitializeComponent();

            PrikaziOcjene();
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

            FormirajCijenu();
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
            PrikaziCijenu();

            if (velicinaComboBox.SelectedIndex != -1)
            {
                VelPizza pizza = (VelPizza)velicinaComboBox.SelectedItem;
                CijenaIznos.Text = (pizza.Cijena * kolicinaPizza).ToString() + " KM";
            }
        }

        private void PrikaziCijenu()
        {
            kolicnaOpis.Text = kolicinaPizza.ToString();
        }

        private void likeButton_Click(object sender, RoutedEventArgs e)
        {
            CreateInstanceOcjene();

            if (likeButton.IsChecked == true)
            {
                o.SvidjaSe = true;
                ++likesNumber;
                LikeCount.Text = likesNumber.ToString();
            }
            else
            {
                o.SvidjaSe = false;
                --likesNumber;
                LikeCount.Text = likesNumber.ToString();
            }
        }

        private void dislikeButton_Click(object sender, RoutedEventArgs e)
        {
            CreateInstanceOcjene();

            if (dislikeButton.IsChecked == true)
            {
                o.NeSvidjaSe = true;
                ++dislikeNumber;
                DislikeCount.Text = dislikeNumber.ToString();
            }
            else
            {
                o.NeSvidjaSe = false;
                --dislikeNumber;
                DislikeCount.Text = dislikeNumber.ToString();
            }
        }

        public void CreateInstanceOcjene()
        {
            if (o == null)
            {
                o = new Ocjene();
            }
        }

        private void dodajUKorpuButton_Click(object sender, RoutedEventArgs e)
        {
            UpisiOcjene();

            Frame.Navigate(typeof(AllProductsPage));
        }

        private void zavrsiKupovinuButton_Click(object sender, RoutedEventArgs e)
        {
            UpisiOcjene();

            Frame.Navigate(typeof(AllProductsPage));    //navigate to korpa !!!
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
    }
}