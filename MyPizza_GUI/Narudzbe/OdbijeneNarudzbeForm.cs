using MyPizza_API.Models;
using MyPizza_GUI.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace MyPizza_GUI.Narudzbe
{
    public partial class OdbijeneNarudzbeForm : Form
    {
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:50337/", "api/Narudzbe");
        private List<myPizza_Narudzbe_SelectOdbijene_Result> odbijeneNarudzbe { get; set; }

        public OdbijeneNarudzbeForm()
        {
            InitializeComponent();
        }

        private void OdbijeneNarudzbeForm_Load(object sender, EventArgs e)
        {
            BindOdbijeneNarudzbe();
        }

        private void BindOdbijeneNarudzbe()
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("GetOdbijeneNarudzbe");

            if (response.IsSuccessStatusCode)
            {
                odbijeneNarudzbe = response.Content.ReadAsAsync<List<myPizza_Narudzbe_SelectOdbijene_Result>>().Result;

                odbijeneNarudzbeDataGridView.AutoGenerateColumns = false;
                odbijeneNarudzbeDataGridView.DataSource = odbijeneNarudzbe;
                odbijeneNarudzbeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                odbijeneNarudzbeUkupnoLabel.Text = "Ukupno: " + odbijeneNarudzbe.Count.ToString();
            }
        }

        private void odbijeneNarudzbeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetaljiNarudzbeForm detaljiNarudzbe = new DetaljiNarudzbeForm(odbijeneNarudzbe[e.RowIndex]);
            detaljiNarudzbe.ShowDialog();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
