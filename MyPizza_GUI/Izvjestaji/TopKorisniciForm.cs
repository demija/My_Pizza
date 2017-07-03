using MyPizza_API.Models;
using MyPizza_GUI.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace MyPizza_GUI.Izvjestaji
{
    public partial class TopKorisniciForm : Form
    {
        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:50337/", "api/Korisnici");

        public TopKorisniciForm()
        {
            InitializeComponent();
        }

        private void TopKorisniciForm_Load(object sender, EventArgs e)
        {
            BindTopKorisnike();
        }

        private void BindTopKorisnike()
        {
            HttpResponseMessage response = korisniciService.GetResponse("SelectTop");

            if (response.IsSuccessStatusCode)
            {
                topKorisniciDataGridView.AutoGenerateColumns = false;
                topKorisniciDataGridView.DataSource = response.Content.ReadAsAsync<List<myPizza_Korisnici_SelectTop_Result>>().Result;
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
