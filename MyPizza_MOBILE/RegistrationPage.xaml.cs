using MyPizza_PCL.Models;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace MyPizza_MOBILE
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistrationPage : Page
    {
        WebAPIHelper service = new WebAPIHelper("http://localhost:50337/", "api/Korisnici");

        public RegistrationPage()
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

        private async void registracijaButton_Click(object sender, RoutedEventArgs e)
        {
            Korisnici k = new Korisnici();
            k.Ime = imeInput.Text;
            k.Prezime = prezimeInput.Text;
            k.Email = emailInput.Text;
            k.BrojTelefona = brojTelefonaInput.Text;
            k.KorisnickoIme = korisnickoImeInput.Text;
            k.LozinkaSalt = UIHelper.GenerateSalt();
            k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Password, k.LozinkaSalt);
            k.GradId = Convert.ToInt32("1"); ; //Convert.ToInt32(gradComboBox.SelectedValue);                                   //comboox gradova uraditi
            k.StatusKorisnikaId = Convert.ToInt32("1");
            k.DatumRegistracije = DateTime.Now;

            //k.Uloge = ulogeCheckedListBox.CheckedItems.Cast<UlogeKorisnika>().ToList();                                       //novom korisniku dodati ulogu "Korisnik"

            HttpResponseMessage response = service.PostResponse(k);

            if (response.IsSuccessStatusCode)
            {
                MessageDialog msg = new MessageDialog("Registracija uspješna!");
                await msg.ShowAsync();
                Frame.Navigate(typeof(LoginPage));
            }
            else
            {
                MessageDialog msg = new MessageDialog("Došlo je do greške. " + response.ReasonPhrase);
                await msg.ShowAsync();
            }
        }
    }
}
