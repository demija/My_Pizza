using MyPizza_API.Models;
using MyPizza_GUI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Windows.Forms;

namespace MyPizza_GUI
{
    public partial class StatusiPizzaForm : Form
    {
        WebAPIHelper statusiPizzaService = new WebAPIHelper("http://localhost:50337/", "api/StatusiPizza");
        private StatusiPizza temp { get; set; }

        public StatusiPizzaForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            statusiDataGridView.AutoGenerateColumns = false;
            statusiDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void StatusiPizzaForm_Load(object sender, EventArgs e)
        {
            BindStatusi();

            if (temp == null)
            {
                obrisiButton.Enabled = false;
            }
        }

        private void BindStatusi()
        {
            HttpResponseMessage response = statusiPizzaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<StatusiPizza> statusi = response.Content.ReadAsAsync<List<StatusiPizza>>().Result;
                statusiDataGridView.DataSource = statusi;
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (temp == null)
                {
                    temp = new StatusiPizza();
                }

                temp.StatusPizze = statusTextBox.Text;
                temp.Opis = opisTextBox.Text;
                temp.DatumIzmjene = DateTime.Now;

                HttpResponseMessage response;

                if (temp.StatusPizzeId == 0)
                {
                    response = statusiPizzaService.PostResponse(temp);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Status dodan!");
                        BindStatusi();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                    }
                }
                else
                {
                    response = statusiPizzaService.PutResponse(temp.StatusPizzeId, temp);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sačuvane izmjene!");
                        BindStatusi();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                    }
                }
            }
        }

        private void statusiDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string statusId = statusiDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            HttpResponseMessage response = statusiPizzaService.GetResponse(statusId);

            if (response.IsSuccessStatusCode)
            {
                temp = response.Content.ReadAsAsync<StatusiPizza>().Result;
                LoadData();
            }

            obrisiButton.Enabled = true;
        }

        private void LoadData()
        {
            statusTextBox.Text = temp.StatusPizze;
            opisTextBox.Text = temp.Opis;
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = statusiPizzaService.DeleteResponse(temp.StatusPizzeId);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Status obrisan!");
                BindStatusi();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
            }
        }

        private void ClearAll()
        {
            statusTextBox.Text = String.Empty;
            opisTextBox.Text = String.Empty;
            temp = null;
            obrisiButton.Enabled = false;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(statusTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(statusTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(statusTextBox, "");
            }
        }
    }
}
