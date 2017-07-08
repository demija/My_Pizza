using MyPizza_API.Models;
using MyPizza_GUI.Util;
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

namespace MyPizza_GUI.Izvjestaji
{
    public partial class PregledProdajePoDatumuForm : Form
    {
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:50337/", "api/Narudzbe");

        public PregledProdajePoDatumuForm()
        {
            InitializeComponent();
        }

        private void traziButton_Click(object sender, EventArgs e)
        {
            DateTime datumOd = this.datumOdDateTimePicker.Value.Date;
            DateTime datumDo = this.datumDoDateTimePicker.Value.Date;

            HttpResponseMessage response = narudzbeService.GetActionResponse2("GetNarudzbeByDate", datumOd.ToString("yyyy-MM-dd"), datumDo.ToString("yyyy-MM-dd"));

            if (response.IsSuccessStatusCode)
            {
                List<myPizza_Narudzbe_ByDate_Result> narudzbe = response.Content.ReadAsAsync<List<myPizza_Narudzbe_ByDate_Result>>().Result;

                rezultatDataGridView.AutoGenerateColumns = false;
                rezultatDataGridView.DataSource = narudzbe;
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
