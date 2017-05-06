using MyPizza_API.Models;
using MyPizza_GUI.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPizza_GUI
{
    public partial class VrstePizzaForm : Form
    {
        WebAPIHelper vrstePizzaService = new WebAPIHelper("http://localhost:50337/", "api/VrstePizza");
        WebAPIHelper sastojciPizzaService = new WebAPIHelper("http://localhost:50337/", "api/Sastojci");

        private VrstePizza vrstaPizze { get; set; }

        public VrstePizzaForm()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            vrstePizzaDataGridView.AutoGenerateColumns = false;
            //vrstePizzaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void VrstePizzaForm_Load(object sender, EventArgs e)
        {
            BindVrstePizza();
            BindSastojci();
        }

        private void dodajSlikuButton_Click(object sender, EventArgs e)
        {
            vrstaPizze = new VrstePizza();

            openFileDialog.ShowDialog();
            slikaTextBox.Text = openFileDialog.FileName;

            try
            {
                Image image = Image.FromFile(slikaTextBox.Text);

                MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                vrstaPizze.Slika = ms.ToArray();

                int resizedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgWidth"]);
                int resizedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["resizedImgHeight"]);
                int croppedImgWidth = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgWidth"]);
                int croppedImgHeight = Convert.ToInt32(ConfigurationManager.AppSettings["croppedImgHeight"]);

                if (image.Width > resizedImgWidth)
                {
                    Image resizedImage = UIHelper.ResizeImage(image, new Size(resizedImgWidth, resizedImgHeight));
                    Image croppedImage = resizedImage;

                    int croppedXPosition = (resizedImage.Width - croppedImgWidth) / 2;
                    int croppedYPosition = (resizedImage.Height - croppedImgHeight) / 2;

                    if (resizedImage.Width >= croppedImgWidth && resizedImage.Height >= croppedImgHeight)
                    {
                        croppedImage = UIHelper.CropImage(resizedImage, new Rectangle(croppedXPosition, croppedYPosition, croppedImgWidth, croppedImgHeight));
                        ms = new MemoryStream();
                        croppedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        vrstaPizze.SlikaThumb = ms.ToArray();

                        vrstaPizzePictureBox.Image = croppedImage;
                    }
                    else
                    {
                        //minimalne dimenzije slike ako je slika manja!!!

                        //sve staviti u try catch blok ako uploadan file nije slika
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                slikaTextBox.Text = "";
                MessageBox.Show("Greska: " + ex.Message);
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (vrstaPizze == null)
                {
                    vrstaPizze = new VrstePizza();
                }

                vrstaPizze.Vrsta = vrstaTextBox.Text;
                vrstaPizze.Opis = opisTextBox.Text;
                vrstaPizze.DatumDodavanja = DateTime.Now;
                vrstaPizze.Sastojak = sastojciCheckedListBox.CheckedItems.Cast<Sastojci>().ToList();

                HttpResponseMessage response = vrstePizzaService.PostResponse(vrstaPizze);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Vrsta pizze dodana! (" + response.Content.ReadAsAsync<VrstePizza>().Result.VrstaPizzeId + ")");
                    BindVrstePizza();
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode + Environment.NewLine + "Message: " + response.ReasonPhrase);
                }
            }
        }

        private void BindVrstePizza()
        {
            HttpResponseMessage response = vrstePizzaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                List<VrstePizza> vrstePizza = response.Content.ReadAsAsync<List<VrstePizza>>().Result;

                vrstePizzaDataGridView.DataSource = vrstePizza;
            }
        }

        private void BindSastojci()
        {
            HttpResponseMessage response = sastojciPizzaService.GetResponse();

            if (response.IsSuccessStatusCode)
            {
                ((ListBox)sastojciCheckedListBox).DataSource = response.Content.ReadAsAsync<List<Sastojci>>().Result;
                ((ListBox)sastojciCheckedListBox).DisplayMember = "Sastojak";
                ((ListBox)sastojciCheckedListBox).ValueMember = "SastojakId";
                sastojciCheckedListBox.ClearSelected();
            }
        }

        private void ClearAll()
        {
            vrstaTextBox.Text = string.Empty;
            opisTextBox.Text = string.Empty;
            sastojciCheckedListBox.ClearSelected();

            for (int i = 0; i < sastojciCheckedListBox.Items.Count; i++)
            {
                sastojciCheckedListBox.SetItemChecked(i, false);
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vrstaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(vrstaTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(vrstaTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(vrstaTextBox, "");
            }
        }

        private void opisTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(opisTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(opisTextBox, Global.GetMessage("req"));
            }
            else
            {
                errorProvider.SetError(opisTextBox, "");
            }
        }

        private void sastojciCheckedListBox_Validating(object sender, CancelEventArgs e)
        {
            if (sastojciCheckedListBox.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(sastojciCheckedListBox, Global.GetMessage("sastojakReq"));
            }
            else
            {
                errorProvider.SetError(sastojciCheckedListBox, "");
            }
        }
    }
}
