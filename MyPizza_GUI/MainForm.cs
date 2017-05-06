using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPizza_GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vrstePizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VrstePizzaForm f = new VrstePizzaForm();
            f.ShowDialog();
            //f.MdiParent = this;
            //f.Show();
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
    }
}
