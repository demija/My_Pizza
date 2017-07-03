using MyPizza_GUI.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using MyPizza_API.Models;

namespace MyPizza_GUI.Narudzbe
{
    public partial class ObradjeneNarudzbeForm : Form
    {
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:50337/", "api/Narudzbe");
        private List<myPizza_Narudzbe_SelectObradjene_Result> obradjeneNarudzbe { get; set; }

        public ObradjeneNarudzbeForm()
        {
            InitializeComponent();
        }

        private void ObradjeneNarudzbeForm_Load(object sender, EventArgs e)
        {
            BindObradjeneNarudzbe();
        }

        private void BindObradjeneNarudzbe()
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("GetObradjeneNarudzbe");

            if (response.IsSuccessStatusCode)
            {
                obradjeneNarudzbe = response.Content.ReadAsAsync<List<myPizza_Narudzbe_SelectObradjene_Result>>().Result;

                obradjeneNarudzbeDataGridView.AutoGenerateColumns = false;
                obradjeneNarudzbeDataGridView.DataSource = obradjeneNarudzbe;
                obradjeneNarudzbeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                obradjeneNardzbeUkupnoLabel.Text = "Ukupno: " + obradjeneNarudzbe.Count.ToString();
            }
        }

        private void obradjeneNarudzbeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetaljiNarudzbeForm detaljiNarudzbe = new DetaljiNarudzbeForm(obradjeneNarudzbe[e.RowIndex]);
            detaljiNarudzbe.ShowDialog();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
