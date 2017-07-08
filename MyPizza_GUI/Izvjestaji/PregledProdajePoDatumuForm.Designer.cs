namespace MyPizza_GUI.Izvjestaji
{
    partial class PregledProdajePoDatumuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.odustaniButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datumOdDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.datumDoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.traziButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rezultatDataGridView = new System.Windows.Forms.DataGridView();
            this.NarudzbaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaZaDostavu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezultatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.odustaniButton.Location = new System.Drawing.Point(784, 638);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 0;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.traziButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.datumDoDateTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datumOdDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled prodaje";
            // 
            // datumOdDateTimePicker
            // 
            this.datumOdDateTimePicker.Location = new System.Drawing.Point(68, 18);
            this.datumOdDateTimePicker.Name = "datumOdDateTimePicker";
            this.datumOdDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumOdDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum od:";
            // 
            // datumDoDateTimePicker
            // 
            this.datumDoDateTimePicker.Location = new System.Drawing.Point(68, 44);
            this.datumDoDateTimePicker.Name = "datumDoDateTimePicker";
            this.datumDoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datumDoDateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum do:";
            // 
            // traziButton
            // 
            this.traziButton.Location = new System.Drawing.Point(193, 70);
            this.traziButton.Name = "traziButton";
            this.traziButton.Size = new System.Drawing.Size(75, 23);
            this.traziButton.TabIndex = 4;
            this.traziButton.Text = "Traži";
            this.traziButton.UseVisualStyleBackColor = true;
            this.traziButton.Click += new System.EventHandler(this.traziButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rezultatDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(849, 511);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezultat";
            // 
            // rezultatDataGridView
            // 
            this.rezultatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezultatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaId,
            this.Korisnik,
            this.KorisnikId,
            this.DatumNarudzbe,
            this.StatusNarudzbe,
            this.AdresaZaDostavu,
            this.BrojTelefona,
            this.UkupnaCijena});
            this.rezultatDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rezultatDataGridView.Location = new System.Drawing.Point(3, 16);
            this.rezultatDataGridView.Name = "rezultatDataGridView";
            this.rezultatDataGridView.Size = new System.Drawing.Size(843, 492);
            this.rezultatDataGridView.TabIndex = 0;
            // 
            // NarudzbaId
            // 
            this.NarudzbaId.DataPropertyName = "NarudzbaId";
            this.NarudzbaId.HeaderText = "Narudzba Id";
            this.NarudzbaId.Name = "NarudzbaId";
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            // 
            // KorisnikId
            // 
            this.KorisnikId.DataPropertyName = "KorisnikId";
            this.KorisnikId.HeaderText = "Korisnik Id";
            this.KorisnikId.Name = "KorisnikId";
            // 
            // DatumNarudzbe
            // 
            this.DatumNarudzbe.DataPropertyName = "DatumNarudzbe";
            this.DatumNarudzbe.HeaderText = "Datum Narudžbe";
            this.DatumNarudzbe.Name = "DatumNarudzbe";
            // 
            // StatusNarudzbe
            // 
            this.StatusNarudzbe.DataPropertyName = "StatusNarudzbe";
            this.StatusNarudzbe.HeaderText = "Status Narudžbe";
            this.StatusNarudzbe.Name = "StatusNarudzbe";
            // 
            // AdresaZaDostavu
            // 
            this.AdresaZaDostavu.DataPropertyName = "AdresaZaDostavu";
            this.AdresaZaDostavu.HeaderText = "Adresa Za Dostavu";
            this.AdresaZaDostavu.Name = "AdresaZaDostavu";
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.DataPropertyName = "BrojTelefona";
            this.BrojTelefona.HeaderText = "Kontakt Telefon";
            this.BrojTelefona.Name = "BrojTelefona";
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.DataPropertyName = "UkupnaCijena";
            this.UkupnaCijena.HeaderText = "Ukupna Cijena";
            this.UkupnaCijena.Name = "UkupnaCijena";
            // 
            // PregledProdajePoDatumuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.odustaniButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PregledProdajePoDatumuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled Prodaje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rezultatDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button traziButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datumDoDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datumOdDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView rezultatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresaZaDostavu;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
    }
}