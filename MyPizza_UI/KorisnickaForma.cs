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

namespace MyPizza_UI
{
    public partial class KorisnickaForma : Form
    {
        public KorisnickaForma()
        {
            InitializeComponent();
        }

        private void KorisnickaForma_Load(object sender, EventArgs e)
        {
            BindKorisnici();
        }

        private void BindKorisnici()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50337/");

            HttpResponseMessage response = client.GetAsync("api/Korisnici").Result;

            if (response.IsSuccessStatusCode)
            {
                var korisnici = response.Content.ReadAsAsync<List<Object>>().Result;

                //korisniciDataGridView.DataSource = korisnici;
                MessageBox.Show(korisnici.ToString());
            }
            else
            {
                MessageBox.Show("Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }
    }
}
