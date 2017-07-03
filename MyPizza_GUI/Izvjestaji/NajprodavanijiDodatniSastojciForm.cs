using MyPizza_API.Models;
using MyPizza_GUI.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace MyPizza_GUI.Izvjestaji
{
    public partial class NajprodavanijiDodatniSastojciForm : Form
    {
        WebAPIHelper dodatniSastojciService = new WebAPIHelper("http://localhost:50337/", "api/DodatniSastojci");

        public NajprodavanijiDodatniSastojciForm()
        {
            InitializeComponent();
        }

        private void NajprodavanijiDodatniSastojciForm_Load(object sender, EventArgs e)
        {
            BindNajprodavanijiSastojci();
        }

        private void BindNajprodavanijiSastojci()
        {
            HttpResponseMessage response = dodatniSastojciService.GetResponse("SelectTop");

            if (response.IsSuccessStatusCode)
            {
                najprodavanijiDodatniSastojciDataGridView.AutoGenerateColumns = false;
                najprodavanijiDodatniSastojciDataGridView.DataSource = response.Content.ReadAsAsync<List<myPizza_DodatniSastojciTop_Result>>().Result;
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
