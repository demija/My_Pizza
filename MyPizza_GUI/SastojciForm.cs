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
    public partial class SastojciForm : Form
    {
        WebAPIHelper sastojciPizzaService = new WebAPIHelper("http://localhost:50337/", "api/Sastojci");
        private Sastojci temp { get; set; }

        public SastojciForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            sastojciDataGridView.AutoGenerateColumns = false;
            sastojciDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SastojciForm_Load(object sender, EventArgs e)
        {
            BindSastojci();

            if (temp == null)
            {
                obrisiButton.Enabled = false;
            }
        }

        private void BindSastojci()
        {
            HttpResponseMessage response = sastojciPizzaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<Sastojci> sastojci = (response.Content.ReadAsAsync<List<Sastojci>>().Result).OrderBy(o => o.Sastojak).ToList();
                sastojciDataGridView.DataSource = sastojci;
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (temp == null)
                {
                    temp = new Sastojci();
                }

                temp.Sastojak = sastojakTextBox.Text;
                temp.BaznaCijena = double.Parse(baznaCijenaTextBox.Text.Replace(".", ","));
                temp.DodatnaCijena = double.Parse(dodatnaCijenaTextBox.Text.Replace(".", ","));

                HttpResponseMessage response;

                if (temp.SastojakId == 0)
                {
                    response = sastojciPizzaService.PostResponse(temp);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sastojak dodan!");
                        BindSastojci();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                    }
                }
                else
                {
                    response = sastojciPizzaService.PutResponse(temp.SastojakId, temp);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sačuvane izmjene!");
                        BindSastojci();
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                    }
                }
            }
        }

        private void sastojciDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sastojakId = sastojciDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            HttpResponseMessage response = sastojciPizzaService.GetResponse(sastojakId);

            if (response.IsSuccessStatusCode)
            {
                temp = response.Content.ReadAsAsync<Sastojci>().Result;
                LoadData();
            }

            obrisiButton.Enabled = true;
        }

        private void LoadData()
        {
            sastojakTextBox.Text = temp.Sastojak;
            baznaCijenaTextBox.Text = temp.BaznaCijena.ToString();
            dodatnaCijenaTextBox.Text = temp.DodatnaCijena.ToString();
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = sastojciPizzaService.DeleteResponse(temp.SastojakId);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sastojak obrisan!");
                BindSastojci();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
            }
        }

        private void ClearAll()
        {
            sastojakTextBox.Text = String.Empty;
            baznaCijenaTextBox.Text = String.Empty;
            dodatnaCijenaTextBox.Text = String.Empty;
            temp = null;
            obrisiButton.Enabled = false;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sastojakTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(sastojakTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(sastojakTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(sastojakTextBox, "");
            }
        }

        private void baznaCijenaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(baznaCijenaTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(baznaCijenaTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(baznaCijenaTextBox, "");
            }
        }

        private void dodatnaCijenaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(dodatnaCijenaTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(dodatnaCijenaTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(dodatnaCijenaTextBox, "");
            }
        }

        private void baznaCijenaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void dodatnaCijenaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
