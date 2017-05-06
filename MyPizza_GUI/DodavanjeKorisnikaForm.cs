using MyPizza_API.Models;
using MyPizza_GUI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPizza_GUI
{
    public partial class DodavanjeKorisnikaForm : Form
    {
        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:50337/", "api/Korisnici");
        WebAPIHelper ulogeService = new WebAPIHelper("http://localhost:50337/", "api/UlogeKorisnika");
        WebAPIHelper gradoviService = new WebAPIHelper("http://localhost:50337/", "api/Gradovi");

        public DodavanjeKorisnikaForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void DodavanjeKorisnikaForm_Load(object sender, EventArgs e)
        {
            BindGradovi();
            BindUlogeKorisnika();
        }

        private void BindGradovi()
        {
            HttpResponseMessage response = gradoviService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Gradovi> gradovi = response.Content.ReadAsAsync<List<Gradovi>>().Result;
                Gradovi temp = new Gradovi();
                temp.Grad = "Odaberi";
                gradovi.Insert(0, temp);

                gradComboBox.DataSource = gradovi;
                gradComboBox.DisplayMember = "Grad";
                gradComboBox.ValueMember = "GradId";
            }
        }

        private void BindUlogeKorisnika()
        {
            HttpResponseMessage response = ulogeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                ((ListBox)ulogeCheckedListBox).DataSource = response.Content.ReadAsAsync<List<UlogeKorisnika>>().Result;
                ((ListBox)ulogeCheckedListBox).DisplayMember = "Uloga";
                ((ListBox)ulogeCheckedListBox).ValueMember = "UlogaKorisnikaId";
                ulogeCheckedListBox.ClearSelected();
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                Korisnici k = new Korisnici();
                k.Ime = imeTextBox.Text;
                k.Prezime = prezimeTextBox.Text;
                k.Email = emailTextBox.Text;
                k.BrojTelefona = brojTelefonaTextBox.Text;
                k.KorisnickoIme = korisnickoImeTextBox.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(lozinkaTextBox.Text, k.LozinkaSalt);
                k.GradId = Convert.ToInt32(gradComboBox.SelectedValue); //Convert.ToInt32("1");
                k.StatusKorisnikaId = Convert.ToInt32("1");
                k.DatumRegistracije = DateTime.Now;

                k.Uloge = ulogeCheckedListBox.CheckedItems.Cast<UlogeKorisnika>().ToList();

                HttpResponseMessage response = korisniciService.PostResponse(k);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Korisnik dodat! (" + response.Content.ReadAsAsync<Korisnici>().Result.KorisnikId + ")");
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                }
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //validacija
        private void imeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(imeTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(imeTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(imeTextBox, "");
            }
        }

        private void prezimeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(prezimeTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(prezimeTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(prezimeTextBox, "");
            }
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(emailTextBox, Global.GetMessage("req"));
            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(emailTextBox.Text);
                    errorProvider.SetError(emailTextBox, "");
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    errorProvider.SetError(emailTextBox, Global.GetMessage("email_err"));
                }
            }
        }

        private void korisnickoImeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(korisnickoImeTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(korisnickoImeTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(korisnickoImeTextBox, "");
            }
        }

        private void lozinkaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(lozinkaTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(lozinkaTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(lozinkaTextBox, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(potvrdaLozinkeTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(potvrdaLozinkeTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(potvrdaLozinkeTextBox, "");
            }
        }

        private void brojTelefonaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(brojTelefonaTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(brojTelefonaTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(brojTelefonaTextBox, "");
            }
        }
    }
}
