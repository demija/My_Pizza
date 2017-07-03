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
    public partial class PregledProdajeForm : Form
    {
        //WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:50337/", "api/Narudzbe");
        //private List<myPizza_Narudzbe_SelectByDate_Result> narudzbe { get; set; }

        public PregledProdajeForm()
        {
            InitializeComponent();
        }

        private void traziButton_Click(object sender, EventArgs e)
        {
             
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
