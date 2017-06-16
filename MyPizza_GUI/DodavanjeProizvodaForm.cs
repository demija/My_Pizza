using MyPizza_API.Models;
using MyPizza_GUI.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace MyPizza_GUI
{
    public partial class DodavanjeProizvodaForm : Form
    {
        WebAPIHelper pizzeService = new WebAPIHelper("http://localhost:50337/", "api/Pizze");
        WebAPIHelper vrstePizzaService = new WebAPIHelper("http://localhost:50337/", "api/VrstePizza");
        WebAPIHelper velicinePizzaService = new WebAPIHelper("http://localhost:50337/", "api/VelicinePizza");
        WebAPIHelper statusiPizzaService = new WebAPIHelper("http://localhost:50337/", "api/StatusiPizza");
        WebAPIHelper cijenePizzaService = new WebAPIHelper("http://localhost:50337/", "api/CijenePizza");

        private Pizze pizza { get; set; }

        public DodavanjeProizvodaForm()
        {
            InitializeComponent();
        }

        private void DodavanjeProizvodaForm_Load(object sender, EventArgs e)
        {
            BindPizze();
            BindVrste();
            BindVelicine();
            BindStatusi();
            BindCijene();
        }

        private void sacuvajButton_Click(object sender, EventArgs e)
        {
            if(pizza == null)
            {
                pizza = new Pizze();
            }

            pizza.VrstaId = Convert.ToInt32(vrstaComboBox.SelectedValue);
            pizza.VelicinaId = Convert.ToInt32(velicinaComboBox.SelectedValue);
            pizza.StatusPizzeId = Convert.ToInt32(statusComboBox.SelectedValue);
            pizza.CijenaId = Convert.ToInt32(cijenaComboBox.SelectedValue);

            HttpResponseMessage response = pizzeService.PostResponse(pizza);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Uspjesno dodato! (" + response.Content.ReadAsAsync<Pizze>().Result.PizzaId + ")");
                BindPizze();
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
            }
        }

        private void BindPizze()
        {
            HttpResponseMessage response = pizzeService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Pizze> pizze = response.Content.ReadAsAsync<List<Pizze>>().Result;
                pizzeDataGridView.DataSource = pizze;
            }
        }

        private void BindVrste()
        {
            HttpResponseMessage response = vrstePizzaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<VrstePizza> vrstePizza = (response.Content.ReadAsAsync<List<VrstePizza>>().Result).OrderBy(o => o.Vrsta).ToList();
                VrstePizza temp = new VrstePizza();
                temp.Vrsta = "Odaberi";
                vrstePizza.Insert(0, temp);

                vrstaComboBox.DataSource = vrstePizza;
                vrstaComboBox.DisplayMember = "Vrsta";
                vrstaComboBox.ValueMember = "VrstaPizzeId";
            }
        }

        private void BindVelicine()
        {
            HttpResponseMessage response = velicinePizzaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<VelicinePizza> velicinePizza = response.Content.ReadAsAsync<List<VelicinePizza>>().Result;
                VelicinePizza temp = new VelicinePizza();
                temp.Velicina = "Odaberi";
                velicinePizza.Insert(0, temp);

                velicinaComboBox.DataSource = velicinePizza;
                velicinaComboBox.DisplayMember = "Velicina";
                velicinaComboBox.ValueMember = "VelicinaPizzeId";
            }
        }

        private void BindStatusi()
        {
            HttpResponseMessage response = statusiPizzaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<StatusiPizza> statusiPizza = response.Content.ReadAsAsync<List<StatusiPizza>>().Result;
                StatusiPizza temp = new StatusiPizza();
                temp.StatusPizze = "Odaberi";
                statusiPizza.Insert(0, temp);

                statusComboBox.DataSource = statusiPizza;
                statusComboBox.DisplayMember = "StatusPizze";
                statusComboBox.ValueMember = "StatusPizzeId";
            }
        }

        private void BindCijene()
        {
            HttpResponseMessage response = cijenePizzaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<CijenePizza> cijenePizza = (response.Content.ReadAsAsync<List<CijenePizza>>().Result).OrderBy(o => o.Cijena).ToList();
                CijenePizza temp = new CijenePizza();
                temp.Cijena = 0;
                cijenePizza.Insert(0, temp);

                cijenaComboBox.DataSource = cijenePizza;
                cijenaComboBox.DisplayMember = "Cijena";
                cijenaComboBox.ValueMember = "CijenaPizzeId";
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
