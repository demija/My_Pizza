namespace MyPizza_GUI
{
    partial class DodavanjeKorisnikaForm
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
            this.components = new System.ComponentModel.Container();
            this.imeLabel = new System.Windows.Forms.Label();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeLabel = new System.Windows.Forms.Label();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.korisnickoImeLabel = new System.Windows.Forms.Label();
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaLabel = new System.Windows.Forms.Label();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.potvrdaLozinkeLabel = new System.Windows.Forms.Label();
            this.potvrdaLozinkeTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.brojTelefonaLabel = new System.Windows.Forms.Label();
            this.gradLabel = new System.Windows.Forms.Label();
            this.ulogeLabel = new System.Windows.Forms.Label();
            this.brojTelefonaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ulogeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.gradComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.noviKorisnikGroupBox = new System.Windows.Forms.GroupBox();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.ulicaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.noviKorisnikGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Location = new System.Drawing.Point(6, 25);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(27, 13);
            this.imeLabel.TabIndex = 0;
            this.imeLabel.Text = "Ime:";
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(107, 22);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(160, 20);
            this.imeTextBox.TabIndex = 1;
            this.imeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.imeTextBox_Validating);
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Location = new System.Drawing.Point(6, 51);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(47, 13);
            this.prezimeLabel.TabIndex = 0;
            this.prezimeLabel.Text = "Prezime:";
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(107, 48);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(160, 20);
            this.prezimeTextBox.TabIndex = 2;
            this.prezimeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.prezimeTextBox_Validating);
            // 
            // korisnickoImeLabel
            // 
            this.korisnickoImeLabel.AutoSize = true;
            this.korisnickoImeLabel.Location = new System.Drawing.Point(6, 77);
            this.korisnickoImeLabel.Name = "korisnickoImeLabel";
            this.korisnickoImeLabel.Size = new System.Drawing.Size(78, 13);
            this.korisnickoImeLabel.TabIndex = 0;
            this.korisnickoImeLabel.Text = "Korisnicko ime:";
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(107, 74);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(160, 20);
            this.korisnickoImeTextBox.TabIndex = 3;
            this.korisnickoImeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.korisnickoImeTextBox_Validating);
            // 
            // lozinkaLabel
            // 
            this.lozinkaLabel.AutoSize = true;
            this.lozinkaLabel.Location = new System.Drawing.Point(6, 103);
            this.lozinkaLabel.Name = "lozinkaLabel";
            this.lozinkaLabel.Size = new System.Drawing.Size(47, 13);
            this.lozinkaLabel.TabIndex = 0;
            this.lozinkaLabel.Text = "Lozinka:";
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(107, 100);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(160, 20);
            this.lozinkaTextBox.TabIndex = 4;
            this.lozinkaTextBox.UseSystemPasswordChar = true;
            this.lozinkaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.lozinkaTextBox_Validating);
            // 
            // potvrdaLozinkeLabel
            // 
            this.potvrdaLozinkeLabel.AutoSize = true;
            this.potvrdaLozinkeLabel.Location = new System.Drawing.Point(6, 129);
            this.potvrdaLozinkeLabel.Name = "potvrdaLozinkeLabel";
            this.potvrdaLozinkeLabel.Size = new System.Drawing.Size(83, 13);
            this.potvrdaLozinkeLabel.TabIndex = 0;
            this.potvrdaLozinkeLabel.Text = "Potvrda lozinke:";
            // 
            // potvrdaLozinkeTextBox
            // 
            this.potvrdaLozinkeTextBox.Location = new System.Drawing.Point(107, 126);
            this.potvrdaLozinkeTextBox.Name = "potvrdaLozinkeTextBox";
            this.potvrdaLozinkeTextBox.Size = new System.Drawing.Size(160, 20);
            this.potvrdaLozinkeTextBox.TabIndex = 5;
            this.potvrdaLozinkeTextBox.UseSystemPasswordChar = true;
            this.potvrdaLozinkeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(6, 155);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(38, 13);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "E-mail:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(107, 152);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(160, 20);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            // 
            // brojTelefonaLabel
            // 
            this.brojTelefonaLabel.AutoSize = true;
            this.brojTelefonaLabel.Location = new System.Drawing.Point(6, 181);
            this.brojTelefonaLabel.Name = "brojTelefonaLabel";
            this.brojTelefonaLabel.Size = new System.Drawing.Size(69, 13);
            this.brojTelefonaLabel.TabIndex = 0;
            this.brojTelefonaLabel.Text = "Broj telefona:";
            // 
            // gradLabel
            // 
            this.gradLabel.AutoSize = true;
            this.gradLabel.Location = new System.Drawing.Point(6, 207);
            this.gradLabel.Name = "gradLabel";
            this.gradLabel.Size = new System.Drawing.Size(33, 13);
            this.gradLabel.TabIndex = 0;
            this.gradLabel.Text = "Grad:";
            // 
            // ulogeLabel
            // 
            this.ulogeLabel.AutoSize = true;
            this.ulogeLabel.Location = new System.Drawing.Point(6, 257);
            this.ulogeLabel.Name = "ulogeLabel";
            this.ulogeLabel.Size = new System.Drawing.Size(38, 13);
            this.ulogeLabel.TabIndex = 0;
            this.ulogeLabel.Text = "Uloge:";
            // 
            // brojTelefonaTextBox
            // 
            this.brojTelefonaTextBox.Location = new System.Drawing.Point(107, 178);
            this.brojTelefonaTextBox.Mask = "(999) 000-000";
            this.brojTelefonaTextBox.Name = "brojTelefonaTextBox";
            this.brojTelefonaTextBox.Size = new System.Drawing.Size(160, 20);
            this.brojTelefonaTextBox.TabIndex = 7;
            this.brojTelefonaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.brojTelefonaTextBox_Validating);
            // 
            // ulogeCheckedListBox
            // 
            this.ulogeCheckedListBox.FormattingEnabled = true;
            this.ulogeCheckedListBox.Location = new System.Drawing.Point(107, 257);
            this.ulogeCheckedListBox.Name = "ulogeCheckedListBox";
            this.ulogeCheckedListBox.Size = new System.Drawing.Size(160, 94);
            this.ulogeCheckedListBox.TabIndex = 9;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(192, 357);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 11;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(107, 357);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 10;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // gradComboBox
            // 
            this.gradComboBox.FormattingEnabled = true;
            this.gradComboBox.Location = new System.Drawing.Point(107, 204);
            this.gradComboBox.Name = "gradComboBox";
            this.gradComboBox.Size = new System.Drawing.Size(160, 21);
            this.gradComboBox.TabIndex = 8;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // noviKorisnikGroupBox
            // 
            this.noviKorisnikGroupBox.Controls.Add(this.ulicaLabel);
            this.noviKorisnikGroupBox.Controls.Add(this.ulicaTextBox);
            this.noviKorisnikGroupBox.Controls.Add(this.imeLabel);
            this.noviKorisnikGroupBox.Controls.Add(this.gradComboBox);
            this.noviKorisnikGroupBox.Controls.Add(this.imeTextBox);
            this.noviKorisnikGroupBox.Controls.Add(this.dodajButton);
            this.noviKorisnikGroupBox.Controls.Add(this.prezimeLabel);
            this.noviKorisnikGroupBox.Controls.Add(this.odustaniButton);
            this.noviKorisnikGroupBox.Controls.Add(this.prezimeTextBox);
            this.noviKorisnikGroupBox.Controls.Add(this.ulogeCheckedListBox);
            this.noviKorisnikGroupBox.Controls.Add(this.korisnickoImeLabel);
            this.noviKorisnikGroupBox.Controls.Add(this.brojTelefonaTextBox);
            this.noviKorisnikGroupBox.Controls.Add(this.korisnickoImeTextBox);
            this.noviKorisnikGroupBox.Controls.Add(this.ulogeLabel);
            this.noviKorisnikGroupBox.Controls.Add(this.lozinkaLabel);
            this.noviKorisnikGroupBox.Controls.Add(this.gradLabel);
            this.noviKorisnikGroupBox.Controls.Add(this.lozinkaTextBox);
            this.noviKorisnikGroupBox.Controls.Add(this.brojTelefonaLabel);
            this.noviKorisnikGroupBox.Controls.Add(this.potvrdaLozinkeLabel);
            this.noviKorisnikGroupBox.Controls.Add(this.emailTextBox);
            this.noviKorisnikGroupBox.Controls.Add(this.potvrdaLozinkeTextBox);
            this.noviKorisnikGroupBox.Controls.Add(this.emailLabel);
            this.noviKorisnikGroupBox.Location = new System.Drawing.Point(12, 12);
            this.noviKorisnikGroupBox.Name = "noviKorisnikGroupBox";
            this.noviKorisnikGroupBox.Size = new System.Drawing.Size(287, 392);
            this.noviKorisnikGroupBox.TabIndex = 12;
            this.noviKorisnikGroupBox.TabStop = false;
            this.noviKorisnikGroupBox.Text = "Novi korisnik";
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.Location = new System.Drawing.Point(107, 231);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(160, 20);
            this.ulicaTextBox.TabIndex = 12;
            this.ulicaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ulicaTextBox_Validating);
            // 
            // ulicaLabel
            // 
            this.ulicaLabel.AutoSize = true;
            this.ulicaLabel.Location = new System.Drawing.Point(6, 234);
            this.ulicaLabel.Name = "ulicaLabel";
            this.ulicaLabel.Size = new System.Drawing.Size(34, 13);
            this.ulicaLabel.TabIndex = 13;
            this.ulicaLabel.Text = "Ulica:";
            // 
            // DodavanjeKorisnikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 413);
            this.Controls.Add(this.noviKorisnikGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodavanjeKorisnikaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje korisnika";
            this.Load += new System.EventHandler(this.DodavanjeKorisnikaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.noviKorisnikGroupBox.ResumeLayout(false);
            this.noviKorisnikGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.Label korisnickoImeLabel;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.Label lozinkaLabel;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.Label potvrdaLozinkeLabel;
        private System.Windows.Forms.TextBox potvrdaLozinkeTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label brojTelefonaLabel;
        private System.Windows.Forms.Label gradLabel;
        private System.Windows.Forms.Label ulogeLabel;
        private System.Windows.Forms.MaskedTextBox brojTelefonaTextBox;
        private System.Windows.Forms.CheckedListBox ulogeCheckedListBox;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.ComboBox gradComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox noviKorisnikGroupBox;
        private System.Windows.Forms.Label ulicaLabel;
        private System.Windows.Forms.TextBox ulicaTextBox;
    }
}