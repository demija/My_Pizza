using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPizza_GUI.Util;
using MyPizza_API.Models;

namespace MyPizza_GUI
{
    public partial class KorisnickaForma : Form
    {
        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:50337/", "api/Korisnici");

        public KorisnickaForma()
        {
            InitializeComponent();
            korisniciDataGridView.AutoGenerateColumns = false;
        }

        private void KorisnickaForma_Load(object sender, EventArgs e)
        {
            BindKorisnici();
        }

        private void noviKorisnikbutton_Click(object sender, EventArgs e)
        {
            DodavanjeKorisnikaForm noviKorisnik = new DodavanjeKorisnikaForm();
            noviKorisnik.ShowDialog();
        }

        private void traziButton_Click(object sender, EventArgs e)
        {
            BindKorisnici();
        }

        private void BindKorisnici()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("SearchKorisnici", imePrezimeTextBox.Text.Trim());

            if (response.IsSuccessStatusCode)
            {
                List<MyPizza_API.Models.Korisnici> korisnici = response.Content.ReadAsAsync<List<MyPizza_API.Models.Korisnici>>().Result;

                korisniciDataGridView.DataSource = korisnici;
            }
            else
            {
                MessageBox.Show("Error Code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
