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
    public partial class LoginForm : Form
    {
        WebAPIHelper korisniciService = new WebAPIHelper("http://localhost:50337/", "api/Korisnici");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void prijavaButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = korisniciService.GetResponse(korisnickoImeTextBox.Text);

            if (response.IsSuccessStatusCode)
            {
                Korisnici k = response.Content.ReadAsAsync<Korisnici>().Result;

                if(UIHelper.GenerateHash(lozinkaTextBox.Text, k.LozinkaSalt) == k.LozinkaHash)
                {
                    Global.prijavljeniKorisnik = k;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Global.GetMessage("loginError"), Global.GetMessage("warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Greska - Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase);
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
