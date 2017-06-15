using MyPizza_PCL.Model;
using MyPizza_PCL.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace MyPizza_MOBILE
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistrationPage : Page
    {
        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:50337/", "api/Korisnici");
        WebAPIHelper gradoviService = new WebAPIHelper("http://localhost:50337/", "api/Gradovi");

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
            BindGradovi();
        }

        private void BindGradovi()
        {
            HttpResponseMessage response = gradoviService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                gradComboBox.ItemsSource = response.Content.ReadAsAsync<List<Gradovi>>().Result;
                gradComboBox.DisplayMemberPath = "Grad";
            }
        }

        private async void registracijaButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateForm())
            {
                if (lozinkaInput.Password == potvrdaLozinkeInput.Password)
                {
                    UlogeKorisnika u = new UlogeKorisnika();
                    u.UlogaKorisnikaId = 2;

                    Korisnici k = new Korisnici();
                    k.Ime = imeInput.Text;
                    k.Prezime = prezimeInput.Text;
                    k.Email = emailInput.Text;
                    k.BrojTelefona = brojTelefonaInput.Text;
                    k.KorisnickoIme = korisnickoImeInput.Text;
                    k.LozinkaSalt = UIHelper.GenerateSalt();
                    k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Password, k.LozinkaSalt);
                    k.Ulica = ulicaInput.Text;
                    k.GradId = ((Gradovi)gradComboBox.SelectedValue).GradId;
                    k.StatusKorisnikaId = Convert.ToInt32("1");
                    k.DatumRegistracije = DateTime.Now;

                    k.Uloge = new List<UlogeKorisnika>();
                    k.Uloge.Add(u);

                    HttpResponseMessage response = korisniciService.PostResponse(k);

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
                else
                {
                    MessageDialog msg = new MessageDialog("Lozinka i potvrda lozinke nisu iste!");
                    await msg.ShowAsync();
                }
            }
            else
            {
                MessageDialog msg = new MessageDialog("Potrebno je unijeti sve podatke!");
                await msg.ShowAsync();
            }
        }

        private bool ValidateForm()
        {
            bool valid = true;

            if (String.IsNullOrEmpty(imeInput.Text))
            {
                valid = false;
            }

            if (String.IsNullOrEmpty(prezimeInput.Text))
            {
                valid = false;
            }

            if (String.IsNullOrEmpty(emailInput.Text))
            {
                valid = false;
            }

            if (String.IsNullOrEmpty(brojTelefonaInput.Text))
            {
                valid = false;
            }

            if (String.IsNullOrEmpty(korisnickoImeInput.Text))
            {
                valid = false;
            }

            if (String.IsNullOrEmpty(lozinkaInput.Password))
            {
                valid = false;
            }

            if (String.IsNullOrEmpty(potvrdaLozinkeInput.Password))
            {
                valid = false;
            }

            if (gradComboBox.SelectedIndex == -1)
            {
                valid = false;
            }

            return valid;
        }
    }
}
