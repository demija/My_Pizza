namespace MyPizza_GUI.Narudzbe
{
    partial class OdbijeneNarudzbeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.odbijeneNarudzbeUkupnoLabel = new System.Windows.Forms.Label();
            this.odbijeneNarudzbeDataGridView = new System.Windows.Forms.DataGridView();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.NarudzbaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaZaDostavu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.odbijeneNarudzbeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregled odbijenih narudžbi";
            // 
            // odbijeneNarudzbeUkupnoLabel
            // 
            this.odbijeneNarudzbeUkupnoLabel.AutoSize = true;
            this.odbijeneNarudzbeUkupnoLabel.Location = new System.Drawing.Point(12, 31);
            this.odbijeneNarudzbeUkupnoLabel.Name = "odbijeneNarudzbeUkupnoLabel";
            this.odbijeneNarudzbeUkupnoLabel.Size = new System.Drawing.Size(35, 13);
            this.odbijeneNarudzbeUkupnoLabel.TabIndex = 1;
            this.odbijeneNarudzbeUkupnoLabel.Text = "label2";
            // 
            // odbijeneNarudzbeDataGridView
            // 
            this.odbijeneNarudzbeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.odbijeneNarudzbeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odbijeneNarudzbeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaId,
            this.Korisnik,
            this.KorisnikId,
            this.DatumNarudzbe,
            this.StatusNarudzbe,
            this.AdresaZaDostavu,
            this.BrojTelefona,
            this.UkupnaCijena});
            this.odbijeneNarudzbeDataGridView.Location = new System.Drawing.Point(12, 56);
            this.odbijeneNarudzbeDataGridView.Name = "odbijeneNarudzbeDataGridView";
            this.odbijeneNarudzbeDataGridView.Size = new System.Drawing.Size(1144, 594);
            this.odbijeneNarudzbeDataGridView.TabIndex = 2;
            this.odbijeneNarudzbeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.odbijeneNarudzbeDataGridView_CellDoubleClick);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(1081, 656);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 3;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
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
            this.Korisnik.Width = 150;
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
            this.DatumNarudzbe.HeaderText = "Datum narudžbe";
            this.DatumNarudzbe.Name = "DatumNarudzbe";
            this.DatumNarudzbe.Width = 150;
            // 
            // StatusNarudzbe
            // 
            this.StatusNarudzbe.DataPropertyName = "StatusNarudzbe";
            this.StatusNarudzbe.HeaderText = "Status narudžbe";
            this.StatusNarudzbe.Name = "StatusNarudzbe";
            this.StatusNarudzbe.Width = 150;
            // 
            // AdresaZaDostavu
            // 
            this.AdresaZaDostavu.DataPropertyName = "AdresaZaDostavu";
            this.AdresaZaDostavu.HeaderText = "Adresa za dostavu";
            this.AdresaZaDostavu.Name = "AdresaZaDostavu";
            this.AdresaZaDostavu.Width = 150;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.DataPropertyName = "BrojTelefona";
            this.BrojTelefona.HeaderText = "Kontakt telefon";
            this.BrojTelefona.Name = "BrojTelefona";
            this.BrojTelefona.Width = 150;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.DataPropertyName = "UkupnaCijena";
            this.UkupnaCijena.HeaderText = "Ukupna cijena";
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.Width = 150;
            // 
            // OdbijeneNarudzbeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 691);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.odbijeneNarudzbeDataGridView);
            this.Controls.Add(this.odbijeneNarudzbeUkupnoLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OdbijeneNarudzbeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odbijene Narudžbe";
            this.Load += new System.EventHandler(this.OdbijeneNarudzbeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odbijeneNarudzbeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label odbijeneNarudzbeUkupnoLabel;
        private System.Windows.Forms.DataGridView odbijeneNarudzbeDataGridView;
        private System.Windows.Forms.Button odustaniButton;
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