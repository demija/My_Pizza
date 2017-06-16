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

        public DetaljiNarudzbeForm(myPizza_Narudzbe_SelectAktivne_Result narudzba)
        {
            InitializeComponent();

            if (narudzba != null)
            {
                this.narudzba = narudzba;

                BindNarudzbeDetails();
                BindSatusiNarudzbi();
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

        private void BindNarudzbeDetails()
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("GetNarudzbeDetails", narudzba.NarudzbaId.ToString());

            if (response.IsSuccessStatusCode)
            {
                narudzbaDetailsDataGridView.DataSource = response.Content.ReadAsAsync<List<myPizza_Narudzbe_Details_Result>>().Result;
                narudzbaDetailsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void DetaljiNarudzbeForm_Load(object sender, EventArgs e)
        {
            BindForm();
        }

        private void BindForm()
        {
            brojNarudzbeValue.Text = narudzba.NarudzbaId.ToString();
            datumValue.Text = narudzba.DatumNarudzbe.ToString();
            adresaZaDostavuValue.Text = narudzba.AdresaZaDostavu;
            kupacValue.Text = narudzba.Korisnik;
            iznosValue.Text = narudzba.UkupnaCijena.ToString();
            kontaktTelValue.Text = narudzba.BrojTelefona;
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
                r.KorisnikId = Global.prijavljeniKorisnik.KorisnikId;
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
