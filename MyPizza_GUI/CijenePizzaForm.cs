using MyPizza_GUI.Util;
using MyPizza_API.Models;
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
    public partial class CijenePizzaForm : Form
    {
        WebAPIHelper cijenePizzaService = new WebAPIHelper("http://localhost:50337/", "api/CijenePizza");
        private CijenePizza temp { get; set; }

        public CijenePizzaForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            cijenePizzaDataGridView.AutoGenerateColumns = false;
            cijenePizzaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CijenePizza_Load(object sender, EventArgs e)
        {
            BindCijenePizza();

            if (temp == null)
            {
                obrisiButton.Enabled = false;
            }
        }

        private void BindCijenePizza()
        {
            HttpResponseMessage response = cijenePizzaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<CijenePizza> cijene = (response.Content.ReadAsAsync<List<CijenePizza>>().Result).OrderBy(o => o.Cijena).ToList();
                cijenePizzaDataGridView.DataSource = cijene;
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (temp == null)
                {
                    temp = new CijenePizza();
                }

                temp.Cijena = double.Parse(cijenaTextBox.Text.Replace(".", ","));
                temp.Opis = opisTextBox.Text;
                temp.DatumIzmjene = DateTime.Now;

                HttpResponseMessage response;

                if (temp.CijenaPizzeId == 0)
                {
                    response = cijenePizzaService.PostResponse(temp);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cijena dodana!");
                        BindCijenePizza();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                    }
                }
                else
                {
                    response = cijenePizzaService.PutResponse(temp.CijenaPizzeId, temp);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sačuvane izmjene!");
                        BindCijenePizza();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                    }
                }
            }
        }

        private void cijenePizzaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cijenaId = cijenePizzaDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            HttpResponseMessage response = cijenePizzaService.GetResponse(cijenaId);
            
            if (response.IsSuccessStatusCode)
            {
                temp = response.Content.ReadAsAsync<CijenePizza>().Result;
                LoadData();
            }

            obrisiButton.Enabled = true;
        }

        private void LoadData()
        {
            cijenaTextBox.Text = temp.Cijena.ToString();
            opisTextBox.Text = temp.Opis;
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = cijenePizzaService.DeleteResponse(temp.CijenaPizzeId);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Cijena obrisana!");
                BindCijenePizza();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
            }
        }

        private void ClearAll()
        {
            cijenaTextBox.Text = String.Empty;
            opisTextBox.Text = String.Empty;
            temp = null;
            obrisiButton.Enabled = false;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cijenaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cijenaTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(cijenaTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(cijenaTextBox, "");
            }
        }

        private void cijenaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
