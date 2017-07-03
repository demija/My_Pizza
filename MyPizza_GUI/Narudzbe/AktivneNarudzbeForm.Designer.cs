namespace MyPizza_GUI
{
    partial class AktivneNarudzbeForm
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
            this.aktivneNarudzbeDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ukupnnoLabel = new System.Windows.Forms.Label();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.NarudzbaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresaZaDostavu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aktivneNarudzbeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aktivneNarudzbeDataGridView
            // 
            this.aktivneNarudzbeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aktivneNarudzbeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aktivneNarudzbeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaId,
            this.Korisnik,
            this.KorisnikId,
            this.StatusNarudzbe,
            this.DatumNarudzbe,
            this.AdresaZaDostavu,
            this.BrojTelefona,
            this.UkupnaCijena});
            this.aktivneNarudzbeDataGridView.Location = new System.Drawing.Point(12, 55);
            this.aktivneNarudzbeDataGridView.Name = "aktivneNarudzbeDataGridView";
            this.aktivneNarudzbeDataGridView.Size = new System.Drawing.Size(1194, 589);
            this.aktivneNarudzbeDataGridView.TabIndex = 0;
            this.aktivneNarudzbeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aktivneNarudzbeDataGridView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pregled aktivnih narudžbi";
            // 
            // ukupnnoLabel
            // 
            this.ukupnnoLabel.AutoSize = true;
            this.ukupnnoLabel.Location = new System.Drawing.Point(12, 31);
            this.ukupnnoLabel.Name = "ukupnnoLabel";
            this.ukupnnoLabel.Size = new System.Drawing.Size(35, 13);
            this.ukupnnoLabel.TabIndex = 2;
            this.ukupnnoLabel.Text = "label2";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(1131, 650);
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
            this.NarudzbaId.Width = 150;
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
            // StatusNarudzbe
            // 
            this.StatusNarudzbe.DataPropertyName = "StatusNarudzbe";
            this.StatusNarudzbe.HeaderText = "Status narudžbe";
            this.StatusNarudzbe.Name = "StatusNarudzbe";
            this.StatusNarudzbe.Width = 150;
            // 
            // DatumNarudzbe
            // 
            this.DatumNarudzbe.DataPropertyName = "DatumNarudzbe";
            this.DatumNarudzbe.HeaderText = "Datum narudžbe";
            this.DatumNarudzbe.Name = "DatumNarudzbe";
            this.DatumNarudzbe.Width = 150;
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
            // AktivneNarudzbeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 685);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.ukupnnoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aktivneNarudzbeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AktivneNarudzbeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktivne Narudžbe";
            this.Load += new System.EventHandler(this.AktivneNarudzbeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aktivneNarudzbeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView aktivneNarudzbeDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ukupnnoLabel;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnikId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresaZaDostavu;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
    }
}