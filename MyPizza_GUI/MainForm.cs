using System;
using System.Windows.Forms;
using MyPizza_GUI.Util;
using System.Net.Http;

namespace MyPizza_GUI
{
    public partial class MainForm : Form
    {
        WebAPIHelper narudzbeService = new WebAPIHelper("http://localhost:50337/", "api/Narudzbe");

        public MainForm()
        {
            InitializeComponent();
        }

        private void vrstePizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VrstePizzaForm f = new VrstePizzaForm();
            f.ShowDialog();
        }

        private void sastojciPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SastojciForm f = new SastojciForm();
            f.ShowDialog();
        }

        private void veličinePizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VelicinePizzaForm f = new VelicinePizzaForm();
            f.ShowDialog();
        }

        private void statusiPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusiPizzaForm f = new StatusiPizzaForm();
            f.ShowDialog();
        }

        private void novaPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodavanjeProizvodaForm f = new DodavanjeProizvodaForm();
            f.ShowDialog();
        }

        private void cijeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CijenePizzaForm f = new CijenePizzaForm();
            f.ShowDialog();
        }

        private void upravljanjeKorisnicimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KorisnickaForma f = new KorisnickaForma();
            f.MdiParent = this;
            f.Show();
        }

        private void izlazToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HttpResponseMessage response = narudzbeService.GetActionResponse("GetBrojAktivnihNarudzbi");

            if (response.IsSuccessStatusCode)
            {
                int brojNarudzbi = response.Content.ReadAsAsync<int>().Result;

                if (brojNarudzbi > 0)
                {
                    notifyIcon1.ShowBalloonTip(5000, "Nove narudzbe", "Broj narudzbi: " + brojNarudzbi, ToolTipIcon.Info);
                }
            }
        }

        private void aktivneNaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AktivneNarudzbeForm f = new AktivneNarudzbeForm();
            f.ShowDialog();
        }
    }
}
