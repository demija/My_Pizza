using MyPizza_API.Models;
using MyPizza_GUI.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace MyPizza_GUI.Izvjestaji
{
    public partial class NajprodavanijiProizvodiForm : Form
    {
        WebAPIHelper vrstePizzaService = new WebAPIHelper("http://localhost:50337/", "api/VrstePizza");

        public NajprodavanijiProizvodiForm()
        {
            InitializeComponent();
        }

        private void NajprodavanijiProizvodiForm_Load(object sender, EventArgs e)
        {
            BindTopVrste();
        }

        private void BindTopVrste()
        {
            HttpResponseMessage response = vrstePizzaService.GetResponse("SelectTop");

            if (response.IsSuccessStatusCode)
            {
                najprodavanijeVrsteDataGridView.AutoGenerateColumns = false;
                najprodavanijeVrsteDataGridView.DataSource = response.Content.ReadAsAsync<List<myPizza_Vrste_SelectTop_Result>>().Result;
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
