using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyPizza_API.Models;
using MyPizza_GUI.Util;
using System.Net.Http;

namespace MyPizza_GUI
{
    public partial class DetaljiNarudzbeForm : Form
    {
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:50337/", "api/Narudzbe");
        WebAPIHelper statusiNarudzbiService = new WebAPIHelper("http://localhost:50337/", "api/StatusiNarudzbi");
        WebAPIHelper racuniService = new WebAPIHelper("http://localhost:50337/", "api/Racuni");
        public myPizza_Narudzbe_SelectAktivne_Result narudzba { get; set; }
        public myPizza_Narudzbe_SelectObradjene_Result obradjenaNarudzba { get; set; }
        public myPizza_Narudzbe_SelectOdbijene_Result odbijenaNarudzba { get; set; }

        public DetaljiNarudzbeForm(myPizza_Narudzbe_SelectAktivne_Result narudzba)
        {
            InitializeComponent();

            if (narudzba != null)
            {
                this.narudzba = narudzba;

                BindNarudzbeDetails(narudzba.NarudzbaId.ToString());
                BindSatusiNarudzbi();
            }
        }

        public DetaljiNarudzbeForm(myPizza_Narudzbe_SelectObradjene_Result obradjenaNarudzba)
        {
            InitializeComponent();

            if (obradjenaNarudzba != null)
            {
                this.obradjenaNarudzba = obradjenaNarudzba;

                statusNarudzbeComboBox.Enabled = false;
                procesirajButton.Enabled = false;

                BindNarudzbeDetails(obradjenaNarudzba.NarudzbaId.ToString());
            }
        }

        public DetaljiNarudzbeForm(myPizza_Narudzbe_SelectOdbijene_Result odbijenaNarudzba)
        {
            InitializeComponent();

            if (odbijenaNarudzba != null)
            {
                this.odbijenaNarudzba = odbijenaNarudzba;

                statusNarudzbeComboBox.Enabled = false;
                procesirajButton.Enabled = false;

                BindNarudzbeDetails(odbijenaNarudzba.NarudzbaId.ToString());
            }
        }

        private void BindNarudzbeDetails(string v)
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("GetNarudzbeDetails", v);

            if (response.IsSuccessStatusCode)
            {
                narudzbaDetailsDataGridView.AutoGenerateColumns = false;
                narudzbaDetailsDataGridView.DataSource = response.Content.ReadAsAsync<List<myPizza_Narudzbe_Details_Result>>().Result;
                narudzbaDetailsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void BindSatusiNarudzbi()
        {
            HttpResponseMessage response = statusiNarudzbiService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<StatusiNarudzbi> statusiNarudzbi = response.Content.ReadAsAsync<List<StatusiNarudzbi>>().Result;
                StatusiNarudzbi temp = new StatusiNarudzbi();
                temp.StatusNarudzbe = "Odaberi";
                statusiNarudzbi.Insert(0, temp);

                statusNarudzbeComboBox.DataSource = statusiNarudzbi;
                statusNarudzbeComboBox.DisplayMember = "StatusNarudzbe";
                statusNarudzbeComboBox.ValueMember = "StatusNarudzbeId";
            }
        }

        private void DetaljiNarudzbeForm_Load(object sender, EventArgs e)
        {
            if (narudzba != null)
            {
                BindForm(narudzba);
            }

            if (obradjenaNarudzba != null)
            {
                BindObradjenaForm(obradjenaNarudzba);
            }

            if (odbijenaNarudzba != null)
            {
                BindOdbijenaForm(odbijenaNarudzba);
            }
        }

        private void BindForm(myPizza_Narudzbe_SelectAktivne_Result narudzba)
        {
            brojNarudzbeValue.Text = narudzba.NarudzbaId.ToString();
            datumValue.Text = narudzba.DatumNarudzbe.ToString();
            adresaZaDostavuValue.Text = narudzba.AdresaZaDostavu;
            kupacValue.Text = narudzba.Korisnik;
            iznosValue.Text = narudzba.UkupnaCijena.ToString();
            kontaktTelValue.Text = narudzba.BrojTelefona;
        }

        private void BindObradjenaForm(myPizza_Narudzbe_SelectObradjene_Result obradjenaNarudzba)
        {
            brojNarudzbeValue.Text = obradjenaNarudzba.NarudzbaId.ToString();
            datumValue.Text = obradjenaNarudzba.DatumNarudzbe.ToString();
            adresaZaDostavuValue.Text = obradjenaNarudzba.AdresaZaDostavu;
            kupacValue.Text = obradjenaNarudzba.Korisnik;
            iznosValue.Text = obradjenaNarudzba.UkupnaCijena.ToString();
            kontaktTelValue.Text = obradjenaNarudzba.BrojTelefona;
        }

        private void BindOdbijenaForm(myPizza_Narudzbe_SelectOdbijene_Result odbijenaNarudzba)
        {
            brojNarudzbeValue.Text = odbijenaNarudzba.NarudzbaId.ToString();
            datumValue.Text = odbijenaNarudzba.DatumNarudzbe.ToString();
            adresaZaDostavuValue.Text = odbijenaNarudzba.AdresaZaDostavu;
            kupacValue.Text = odbijenaNarudzba.Korisnik;
            iznosValue.Text = odbijenaNarudzba.UkupnaCijena.ToString();
            kontaktTelValue.Text = odbijenaNarudzba.BrojTelefona;
        }

        private void procesirajButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToUInt32(statusNarudzbeComboBox.SelectedValue) == 0)
            {
                MessageBox.Show("Odaberi status!");
            }
            else if (Convert.ToUInt32(statusNarudzbeComboBox.SelectedValue) == 3)
            {
                Racuni r = new Racuni();

                r.Datum = DateTime.Now;
                r.NarudzbaId = narudzba.NarudzbaId;
                r.KorisnikId = narudzba.KorisnikId;
                r.CijenaSaPDV = (decimal)narudzba.UkupnaCijena;
                r.CijenaBezPDV = (decimal)narudzba.UkupnaCijena / (decimal)1.17;

                HttpResponseMessage responser = racuniService.PostResponse(r);

                if (responser.IsSuccessStatusCode)
                {
                    MessageBox.Show("Narudzba procesirana!");
                    this.Close();
                }
            }
            else if(Convert.ToUInt32(statusNarudzbeComboBox.SelectedValue) == 4)
            {
                HttpResponseMessage response = narudzbeService.GetActionResponse("UpdateNarudzbe", narudzba.NarudzbaId.ToString());

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Narudzba procesirana!");
                    this.Close();
                }
            }
        }

        private void zatvoriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
