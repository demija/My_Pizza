namespace MyPizza_GUI.Izvjestaji
{
    partial class PregledProdajeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sveRadioButton = new System.Windows.Forms.RadioButton();
            this.korisniciComboBox = new System.Windows.Forms.ComboBox();
            this.traziButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rezultatDataGridView = new System.Windows.Forms.DataGridView();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.aktivneRadioButton = new System.Windows.Forms.RadioButton();
            this.obradjeneRadioButton = new System.Windows.Forms.RadioButton();
            this.odbijeneRadioButton = new System.Windows.Forms.RadioButton();
            this.NarudzbaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaZaDostavu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezultatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.odbijeneRadioButton);
            this.groupBox1.Controls.Add(this.obradjeneRadioButton);
            this.groupBox1.Controls.Add(this.aktivneRadioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sveRadioButton);
            this.groupBox1.Controls.Add(this.korisniciComboBox);
            this.groupBox1.Controls.Add(this.traziButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status narudžbe:";
            // 
            // sveRadioButton
            // 
            this.sveRadioButton.AutoSize = true;
            this.sveRadioButton.Checked = true;
            this.sveRadioButton.Location = new System.Drawing.Point(99, 46);
            this.sveRadioButton.Name = "sveRadioButton";
            this.sveRadioButton.Size = new System.Drawing.Size(44, 17);
            this.sveRadioButton.TabIndex = 4;
            this.sveRadioButton.TabStop = true;
            this.sveRadioButton.Text = "Sve";
            this.sveRadioButton.UseVisualStyleBackColor = true;
            // 
            // korisniciComboBox
            // 
            this.korisniciComboBox.FormattingEnabled = true;
            this.korisniciComboBox.Location = new System.Drawing.Point(99, 19);
            this.korisniciComboBox.Name = "korisniciComboBox";
            this.korisniciComboBox.Size = new System.Drawing.Size(263, 21);
            this.korisniciComboBox.TabIndex = 3;
            // 
            // traziButton
            // 
            this.traziButton.Location = new System.Drawing.Point(429, 43);
            this.traziButton.Name = "traziButton";
            this.traziButton.Size = new System.Drawing.Size(75, 23);
            this.traziButton.TabIndex = 2;
            this.traziButton.Text = "Traži";
            this.traziButton.UseVisualStyleBackColor = true;
            this.traziButton.Click += new System.EventHandler(this.traziButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisnik:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ukupnoLabel);
            this.groupBox2.Controls.Add(this.rezultatDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 595);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rezultat pretrage";
            // 
            // rezultatDataGridView
            // 
            this.rezultatDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.rezultatDataGridView.Location = new System.Drawing.Point(6, 32);
            this.rezultatDataGridView.Name = "rezultatDataGridView";
            this.rezultatDataGridView.Size = new System.Drawing.Size(846, 557);
            this.rezultatDataGridView.TabIndex = 0;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.odustaniButton.Location = new System.Drawing.Point(795, 694);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 4;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // aktivneRadioButton
            // 
            this.aktivneRadioButton.AutoSize = true;
            this.aktivneRadioButton.Location = new System.Drawing.Point(149, 46);
            this.aktivneRadioButton.Name = "aktivneRadioButton";
            this.aktivneRadioButton.Size = new System.Drawing.Size(61, 17);
            this.aktivneRadioButton.TabIndex = 6;
            this.aktivneRadioButton.Text = "Aktivne";
            this.aktivneRadioButton.UseVisualStyleBackColor = true;
            // 
            // obradjeneRadioButton
            // 
            this.obradjeneRadioButton.AutoSize = true;
            this.obradjeneRadioButton.Location = new System.Drawing.Point(216, 46);
            this.obradjeneRadioButton.Name = "obradjeneRadioButton";
            this.obradjeneRadioButton.Size = new System.Drawing.Size(73, 17);
            this.obradjeneRadioButton.TabIndex = 7;
            this.obradjeneRadioButton.Text = "Obrađene";
            this.obradjeneRadioButton.UseVisualStyleBackColor = true;
            // 
            // odbijeneRadioButton
            // 
            this.odbijeneRadioButton.AutoSize = true;
            this.odbijeneRadioButton.Location = new System.Drawing.Point(295, 46);
            this.odbijeneRadioButton.Name = "odbijeneRadioButton";
            this.odbijeneRadioButton.Size = new System.Drawing.Size(67, 17);
            this.odbijeneRadioButton.TabIndex = 8;
            this.odbijeneRadioButton.Text = "Odbijene";
            this.odbijeneRadioButton.UseVisualStyleBackColor = true;
            // 
            // NarudzbaId
            // 
            this.NarudzbaId.DataPropertyName = "NarudzbaId";
            this.NarudzbaId.HeaderText = "Narudžba Id";
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
            // ukupnoLabel
            // 
            this.ukupnoLabel.AutoSize = true;
            this.ukupnoLabel.Location = new System.Drawing.Point(6, 16);
            this.ukupnoLabel.Name = "ukupnoLabel";
            this.ukupnoLabel.Size = new System.Drawing.Size(35, 13);
            this.ukupnoLabel.TabIndex = 1;
            this.ukupnoLabel.Text = "label3";
            // 
            // PregledProdajeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 729);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PregledProdajeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled Prodaje";
            this.Load += new System.EventHandler(this.PregledProdajeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rezultatDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button traziButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.DataGridView rezultatDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton sveRadioButton;
        private System.Windows.Forms.ComboBox korisniciComboBox;
        private System.Windows.Forms.RadioButton odbijeneRadioButton;
        private System.Windows.Forms.RadioButton obradjeneRadioButton;
        private System.Windows.Forms.RadioButton aktivneRadioButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresaZaDostavu;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.Label ukupnoLabel;
    }
}