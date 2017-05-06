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

namespace MyPizza_GUI
{
    public partial class VelicinePizzaForm : Form
    {
        WebAPIHelper velicinePizzaService = new WebAPIHelper("http://localhost:50337/", "api/VelicinePizza");
        private VelicinePizza temp { get; set; }

        public VelicinePizzaForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            velicinePizzaDataGridView.AutoGenerateColumns = false;
            velicinePizzaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        } 

        private void VelicinePizzaForm_Load(object sender, EventArgs e)
        {
            BindVelicinePizza();

            if (temp == null)
            {
                obrisiButton.Enabled = false;
            }
        }

        private void BindVelicinePizza()
        {
            HttpResponseMessage response = velicinePizzaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<VelicinePizza> velicine = response.Content.ReadAsAsync<List<VelicinePizza>>().Result;

                velicinePizzaDataGridView.DataSource = velicine;
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (temp == null)
                {
                    temp = new VelicinePizza();
                }

                temp.Velicina = velicinaTextBox.Text;
                temp.Promjer = promjerTextBox.Text;
                temp.DatumIzmjene = DateTime.Now;

                HttpResponseMessage response;

                if (temp.VelicinaPizzeId == 0)
                {
                    response = velicinePizzaService.PostResponse(temp);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Veličina dodana!");
                        BindVelicinePizza();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                    }
                }
                else
                {
                    response = velicinePizzaService.PutResponse(temp.VelicinaPizzeId, temp);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sačuvane izmjene!");
                        BindVelicinePizza();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                    }
                }
            }
        }

        private void velicinePizzaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string velicinaId = velicinePizzaDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            HttpResponseMessage response = velicinePizzaService.GetResponse(velicinaId);

            if (response.IsSuccessStatusCode)
            {
                temp = response.Content.ReadAsAsync<VelicinePizza>().Result;
                LoadData();
            }

            obrisiButton.Enabled = true;
        }

        private void LoadData()
        {
            velicinaTextBox.Text = temp.Velicina;
            promjerTextBox.Text = temp.Promjer;
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = velicinePizzaService.DeleteResponse(temp.VelicinaPizzeId);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Veličina obrisana!");
                BindVelicinePizza();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
            }
        }

        private void ClearAll()
        {
            velicinaTextBox.Text = String.Empty;
            promjerTextBox.Text = String.Empty;
            temp = null;
            obrisiButton.Enabled = false;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void velicinaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(velicinaTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(velicinaTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(velicinaTextBox, "");
            }
        }

        private void promjerTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(promjerTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(promjerTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(promjerTextBox, "");
            }
        }

        private void promjerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
