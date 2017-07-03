namespace MyPizza_GUI
{
    partial class KorisnickaForma
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
            this.korisniciDataGridView = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noviKorisnikbutton = new System.Windows.Forms.Button();
            this.imePrezimeLabel = new System.Windows.Forms.Label();
            this.imePrezimeTextBox = new System.Windows.Forms.TextBox();
            this.traziButton = new System.Windows.Forms.Button();
            this.pregledKorisnikaGroupBox = new System.Windows.Forms.GroupBox();
            this.odustaniButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).BeginInit();
            this.pregledKorisnikaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // korisniciDataGridView
            // 
            this.korisniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.Email,
            this.BrojTelefona,
            this.Grad,
            this.Status});
            this.korisniciDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.korisniciDataGridView.Location = new System.Drawing.Point(3, 16);
            this.korisniciDataGridView.Name = "korisniciDataGridView";
            this.korisniciDataGridView.Size = new System.Drawing.Size(871, 535);
            this.korisniciDataGridView.TabIndex = 10;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.Width = 120;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.Width = 120;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisnicko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Width = 120;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.Width = 120;
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.DataPropertyName = "BrojTelefona";
            this.BrojTelefona.HeaderText = "Broj telefona";
            this.BrojTelefona.Name = "BrojTelefona";
            this.BrojTelefona.Width = 120;
            // 
            // Grad
            // 
            this.Grad.DataPropertyName = "GradId";
            this.Grad.HeaderText = "Grad";
            this.Grad.Name = "Grad";
            this.Grad.Width = 120;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StatusKorisnikaId";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // noviKorisnikbutton
            // 
            this.noviKorisnikbutton.Location = new System.Drawing.Point(779, 12);
            this.noviKorisnikbutton.Name = "noviKorisnikbutton";
            this.noviKorisnikbutton.Size = new System.Drawing.Size(110, 23);
            this.noviKorisnikbutton.TabIndex = 11;
            this.noviKorisnikbutton.Text = "Novi korisnik";
            this.noviKorisnikbutton.UseVisualStyleBackColor = true;
            this.noviKorisnikbutton.Click += new System.EventHandler(this.noviKorisnikbutton_Click);
            // 
            // imePrezimeLabel
            // 
            this.imePrezimeLabel.AutoSize = true;
            this.imePrezimeLabel.Location = new System.Drawing.Point(12, 15);
            this.imePrezimeLabel.Name = "imePrezimeLabel";
            this.imePrezimeLabel.Size = new System.Drawing.Size(71, 13);
            this.imePrezimeLabel.TabIndex = 12;
            this.imePrezimeLabel.Text = "Ime i prezime:";
            // 
            // imePrezimeTextBox
            // 
            this.imePrezimeTextBox.Location = new System.Drawing.Point(89, 12);
            this.imePrezimeTextBox.Name = "imePrezimeTextBox";
            this.imePrezimeTextBox.Size = new System.Drawing.Size(150, 20);
            this.imePrezimeTextBox.TabIndex = 13;
            // 
            // traziButton
            // 
            this.traziButton.Location = new System.Drawing.Point(245, 10);
            this.traziButton.Name = "traziButton";
            this.traziButton.Size = new System.Drawing.Size(75, 23);
            this.traziButton.TabIndex = 14;
            this.traziButton.Text = "Trazi";
            this.traziButton.UseVisualStyleBackColor = true;
            this.traziButton.Click += new System.EventHandler(this.traziButton_Click);
            // 
            // pregledKorisnikaGroupBox
            // 
            this.pregledKorisnikaGroupBox.Controls.Add(this.korisniciDataGridView);
            this.pregledKorisnikaGroupBox.Location = new System.Drawing.Point(12, 44);
            this.pregledKorisnikaGroupBox.Name = "pregledKorisnikaGroupBox";
            this.pregledKorisnikaGroupBox.Size = new System.Drawing.Size(877, 554);
            this.pregledKorisnikaGroupBox.TabIndex = 15;
            this.pregledKorisnikaGroupBox.TabStop = false;
            this.pregledKorisnikaGroupBox.Text = "Pregled korisnika";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(814, 604);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 16;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // KorisnickaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 637);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.pregledKorisnikaGroupBox);
            this.Controls.Add(this.traziButton);
            this.Controls.Add(this.imePrezimeTextBox);
            this.Controls.Add(this.imePrezimeLabel);
            this.Controls.Add(this.noviKorisnikbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "KorisnickaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.KorisnickaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).EndInit();
            this.pregledKorisnikaGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView korisniciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button noviKorisnikbutton;
        private System.Windows.Forms.Label imePrezimeLabel;
        private System.Windows.Forms.TextBox imePrezimeTextBox;
        private System.Windows.Forms.Button traziButton;
        private System.Windows.Forms.GroupBox pregledKorisnikaGroupBox;
        private System.Windows.Forms.Button odustaniButton;
    }
}