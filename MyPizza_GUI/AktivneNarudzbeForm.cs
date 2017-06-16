using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MyPizza_GUI.Util;
using System.Net.Http;
using MyPizza_API.Models;

namespace MyPizza_GUI
{
    public partial class AktivneNarudzbeForm : Form
    {
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:50337/", "api/Narudzbe");
        private List<myPizza_Narudzbe_SelectAktivne_Result> aktivneNarudzbe { get; set; }

        public AktivneNarudzbeForm()
        {
            InitializeComponent();
        }

        private void AktivneNarudzbeForm_Load(object sender, EventArgs e)
        {
            BindAktivneNarudzbe();
        }

        private void BindAktivneNarudzbe()
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("GetAktivneNarudzbe");

            if (response.IsSuccessStatusCode)
            {
                aktivneNarudzbe = response.Content.ReadAsAsync<List<myPizza_Narudzbe_SelectAktivne_Result>>().Result;

                aktivneNarudzbeDataGridView.DataSource = aktivneNarudzbe;

                aktivneNarudzbeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void aktivneNarudzbeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetaljiNarudzbeForm detaljiNarudzbe = new DetaljiNarudzbeForm(aktivneNarudzbe[e.RowIndex]);
            detaljiNarudzbe.ShowDialog();
        }
    }
}
