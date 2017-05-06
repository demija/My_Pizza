namespace MyPizza_UI
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
            this.registracijaKorisnikaGroupBox = new System.Windows.Forms.GroupBox();
            this.korisniciDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registracijaKorisnikaGroupBox
            // 
            this.registracijaKorisnikaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.registracijaKorisnikaGroupBox.Name = "registracijaKorisnikaGroupBox";
            this.registracijaKorisnikaGroupBox.Size = new System.Drawing.Size(626, 148);
            this.registracijaKorisnikaGroupBox.TabIndex = 0;
            this.registracijaKorisnikaGroupBox.TabStop = false;
            this.registracijaKorisnikaGroupBox.Text = "Registracija korisnika";
            // 
            // korisniciDataGridView
            // 
            this.korisniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciDataGridView.Location = new System.Drawing.Point(12, 166);
            this.korisniciDataGridView.Name = "korisniciDataGridView";
            this.korisniciDataGridView.Size = new System.Drawing.Size(829, 461);
            this.korisniciDataGridView.TabIndex = 1;
            // 
            // KorisnickaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 639);
            this.Controls.Add(this.korisniciDataGridView);
            this.Controls.Add(this.registracijaKorisnikaGroupBox);
            this.Name = "KorisnickaForma";
            this.Text = "Korisnici";
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registracijaKorisnikaGroupBox;
        private System.Windows.Forms.DataGridView korisniciDataGridView;
    }
}

