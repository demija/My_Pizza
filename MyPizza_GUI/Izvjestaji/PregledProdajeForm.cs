using MyPizza_API.Models;
using MyPizza_GUI.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace MyPizza_GUI.Izvjestaji
{
    public partial class PregledProdajeForm : Form
    {
        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:50337/", "api/Korisnici");
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:50337/", "api/Narudzbe");
        private List<myPizza_Narudzbe_SelectAll_Result> sveNarudzbe { get; set; }
        private List<myPizza_Narudzbe_SelectAktivne_Result> aktivneNarudzbe { get; set; }
        private List<myPizza_Narudzbe_SelectObradjene_Result> obradjeneNarudzbe { get; set; }
        private List<myPizza_Narudzbe_SelectOdbijene_Result> odbijeneNarudzbe { get; set; }

        public PregledProdajeForm()
        {
            InitializeComponent();
        }

        private void PregledProdajeForm_Load(object sender, EventArgs e)
        {
            BindKorisnici();
            BindSveNarudzbe();
        }

        private void BindKorisnici()
        {
            HttpResponseMessage response = korisniciService.GetActionResponse("SelectImeId");

            if (response.IsSuccessStatusCode)
            {
                List<myPizza_Korisnici_ImePrezimeId_Result> listaKorisnika = response.Content.ReadAsAsync<List<myPizza_Korisnici_ImePrezimeId_Result>>().Result;
                myPizza_Korisnici_ImePrezimeId_Result temp = new myPizza_Korisnici_ImePrezimeId_Result();
                temp.KorisnikId = 0;
                temp.ImePrezime = "Svi";

                listaKorisnika.Insert(0, temp);

                korisniciComboBox.DataSource = listaKorisnika;
                korisniciComboBox.DisplayMember = "ImePrezime";
                korisniciComboBox.ValueMember = "KorisnikId";
            }
        }

        private void traziButton_Click(object sender, EventArgs e)
        {
            if (sveRadioButton.Checked)
            {
                BindSveNarudzbe();
            }
            else if (aktivneRadioButton.Checked)
            {
                BindAktivneNarudzbe();
            }
            else if (obradjeneRadioButton.Checked)
            {
                BindObradjeneNarudzbe();
            }
            else if (odbijeneRadioButton.Checked)
            {
                BindOdbijeneNarudzbe();
            }
        }

        private void BindSveNarudzbe()
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("GetAllNarudzbe");

            if (response.IsSuccessStatusCode)
            {
                rezultatDataGridView.AutoGenerateColumns = false;
                rezultatDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                sveNarudzbe = response.Content.ReadAsAsync<List<myPizza_Narudzbe_SelectAll_Result>>().Result;

                if (Convert.ToInt32(korisniciComboBox.SelectedValue) != 0)
                {
                    List<myPizza_Narudzbe_SelectAll_Result> temp = new List<myPizza_Narudzbe_SelectAll_Result>();

                    foreach (var item in sveNarudzbe)
                    {
                        if (item.KorisnikId == Convert.ToInt32(korisniciComboBox.SelectedValue))
                        {
                            temp.Add(item);
                        }
                    }

                    rezultatDataGridView.DataSource = temp;
                    ukupnoLabel.Text = "Ukupno: " + temp.Count.ToString();
                }
                else
                {
                    rezultatDataGridView.DataSource = sveNarudzbe;
                    ukupnoLabel.Text = "Ukupno: " + sveNarudzbe.Count.ToString();
                }
            }
        }

        private void BindAktivneNarudzbe()
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("GetAktivneNarudzbe");

            if (response.IsSuccessStatusCode)
            {
                rezultatDataGridView.AutoGenerateColumns = false;
                rezultatDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                aktivneNarudzbe = response.Content.ReadAsAsync<List<myPizza_Narudzbe_SelectAktivne_Result>>().Result;

                if (Convert.ToInt32(korisniciComboBox.SelectedValue) != 0)
                {
                    List<myPizza_Narudzbe_SelectAktivne_Result> temp = new List<myPizza_Narudzbe_SelectAktivne_Result>();

                    foreach (var item in aktivneNarudzbe)
                    {
                        if (item.KorisnikId == Convert.ToInt32(korisniciComboBox.SelectedValue))
                        {
                            temp.Add(item);
                        }
                    }

                    rezultatDataGridView.DataSource = temp;
                    ukupnoLabel.Text = "Ukupno: " + temp.Count.ToString();
                }
                else
                {
                    rezultatDataGridView.DataSource = aktivneNarudzbe;
                    ukupnoLabel.Text = "Ukupno: " + aktivneNarudzbe.Count.ToString();
                }
            }
        }

        private void BindObradjeneNarudzbe()
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("GetObradjeneNarudzbe");

            if (response.IsSuccessStatusCode)
            {
                rezultatDataGridView.AutoGenerateColumns = false;
                rezultatDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                obradjeneNarudzbe = response.Content.ReadAsAsync<List<myPizza_Narudzbe_SelectObradjene_Result>>().Result;

                if (Convert.ToInt32(korisniciComboBox.SelectedValue) != 0)
                {
                    List<myPizza_Narudzbe_SelectObradjene_Result> temp = new List<myPizza_Narudzbe_SelectObradjene_Result>();

                    foreach (var item in obradjeneNarudzbe)
                    {
                        if (item.KorisnikId == Convert.ToInt32(korisniciComboBox.SelectedValue))
                        {
                            temp.Add(item);
                        }
                    }

                    rezultatDataGridView.DataSource = temp;
                    ukupnoLabel.Text = "Ukupno: " + temp.Count.ToString();
                }
                else
                {
                    rezultatDataGridView.DataSource = obradjeneNarudzbe;
                    ukupnoLabel.Text = "Ukupno: " + obradjeneNarudzbe.Count.ToString();
                }
            }
        }

        private void BindOdbijeneNarudzbe()
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("GetOdbijeneNarudzbe");

            if (response.IsSuccessStatusCode)
            {
                rezultatDataGridView.AutoGenerateColumns = false;
                rezultatDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                odbijeneNarudzbe = response.Content.ReadAsAsync<List<myPizza_Narudzbe_SelectOdbijene_Result>>().Result;

                if (Convert.ToInt32(korisniciComboBox.SelectedValue) != 0)
                {
                    List<myPizza_Narudzbe_SelectOdbijene_Result> temp = new List<myPizza_Narudzbe_SelectOdbijene_Result>();

                    foreach (var item in odbijeneNarudzbe)
                    {
                        if (item.KorisnikId == Convert.ToInt32(korisniciComboBox.SelectedValue))
                        {
                            temp.Add(item);
                        }
                    }

                    rezultatDataGridView.DataSource = temp;
                    ukupnoLabel.Text = "Ukupno: " + temp.Count.ToString();
                }
                else
                {
                    rezultatDataGridView.DataSource = odbijeneNarudzbe;
                    ukupnoLabel.Text = "Ukupno: " + odbijeneNarudzbe.Count.ToString();
                }
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
