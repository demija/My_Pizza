using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using MyPizza_PCL.Util;
using MyPizza_PCL.Model;
using System.Net.Http;
using Windows.UI.Popups;
using MyPizza_MOBILE.Products;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace MyPizza_MOBILE
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        WebAPIHelper service = new WebAPIHelper("http://localhost:50337/", "api/Korisnici");

        public LoginPage()
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
        }

        private async void prijavaButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(korisnickoImeInput.Text) && !String.IsNullOrEmpty(lozinkaInput.Password))
            {
                HttpResponseMessage response = service.GetResponse(korisnickoImeInput.Text);

                if (response.IsSuccessStatusCode)
                {
                    Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;

                    if (UIHelper.GenerateHash(lozinkaInput.Password, k.LozinkaSalt) == k.LozinkaHash)
                    {
                        Global.prijavljeniKorisnik = k;
                        Frame.Navigate(typeof(AllProductsPage));

                        MessageDialog msg = new MessageDialog("Dobro došli " + k.Ime + " " + k.Prezime + "!");
                        await msg.ShowAsync();
                    }
                    else
                    {
                        MessageDialog msg = new MessageDialog("Podaci nisu tačni!");
                        await msg.ShowAsync();
                    }
                }
                else
                {
                    MessageDialog msg = new MessageDialog("Problem u komunikaciji!");
                    await msg.ShowAsync();
                }
            }
            else
            {
                MessageDialog msg = new MessageDialog("Potrebno unijeti korisničko ime i lozinku!");
                await msg.ShowAsync();
            }
        }

        private async void registracijaButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RegistrationPage));
        }
    }
}
