namespace MyPizza_GUI
{
    partial class DetaljiNarudzbeForm
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
            this.brojNarudzbeLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.kupacLabel = new System.Windows.Forms.Label();
            this.iznosLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kontaktTelValue = new System.Windows.Forms.Label();
            this.iznosValue = new System.Windows.Forms.Label();
            this.kupacValue = new System.Windows.Forms.Label();
            this.adresaZaDostavuValue = new System.Windows.Forms.Label();
            this.datumValue = new System.Windows.Forms.Label();
            this.brojNarudzbeValue = new System.Windows.Forms.Label();
            this.kontaktTelLabel = new System.Windows.Forms.Label();
            this.adresaZaDosavulabel = new System.Windows.Forms.Label();
            this.statusNarudzbeComboBox = new System.Windows.Forms.ComboBox();
            this.narudzbaDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sastojci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.procesirajButton = new System.Windows.Forms.Button();
            this.zatvoriButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaDetailsDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // brojNarudzbeLabel
            // 
            this.brojNarudzbeLabel.AutoSize = true;
            this.brojNarudzbeLabel.Location = new System.Drawing.Point(6, 16);
            this.brojNarudzbeLabel.Name = "brojNarudzbeLabel";
            this.brojNarudzbeLabel.Size = new System.Drawing.Size(75, 13);
            this.brojNarudzbeLabel.TabIndex = 0;
            this.brojNarudzbeLabel.Text = "Broj narudžbe:";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(6, 38);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(41, 13);
            this.datumLabel.TabIndex = 1;
            this.datumLabel.Text = "Datum:";
            // 
            // kupacLabel
            // 
            this.kupacLabel.AutoSize = true;
            this.kupacLabel.Location = new System.Drawing.Point(395, 16);
            this.kupacLabel.Name = "kupacLabel";
            this.kupacLabel.Size = new System.Drawing.Size(41, 13);
            this.kupacLabel.TabIndex = 2;
            this.kupacLabel.Text = "Kupac:";
            // 
            // iznosLabel
            // 
            this.iznosLabel.AutoSize = true;
            this.iznosLabel.Location = new System.Drawing.Point(6, 60);
            this.iznosLabel.Name = "iznosLabel";
            this.iznosLabel.Size = new System.Drawing.Size(35, 13);
            this.iznosLabel.TabIndex = 3;
            this.iznosLabel.Text = "Iznos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kontaktTelValue);
            this.groupBox1.Controls.Add(this.iznosValue);
            this.groupBox1.Controls.Add(this.kupacValue);
            this.groupBox1.Controls.Add(this.adresaZaDostavuValue);
            this.groupBox1.Controls.Add(this.datumValue);
            this.groupBox1.Controls.Add(this.brojNarudzbeValue);
            this.groupBox1.Controls.Add(this.kontaktTelLabel);
            this.groupBox1.Controls.Add(this.adresaZaDosavulabel);
            this.groupBox1.Controls.Add(this.kupacLabel);
            this.groupBox1.Controls.Add(this.iznosLabel);
            this.groupBox1.Controls.Add(this.brojNarudzbeLabel);
            this.groupBox1.Controls.Add(this.datumLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o narudžbi";
            // 
            // kontaktTelValue
            // 
            this.kontaktTelValue.AutoSize = true;
            this.kontaktTelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kontaktTelValue.Location = new System.Drawing.Point(499, 60);
            this.kontaktTelValue.Name = "kontaktTelValue";
            this.kontaktTelValue.Size = new System.Drawing.Size(79, 13);
            this.kontaktTelValue.TabIndex = 11;
            this.kontaktTelValue.Text = "Kontakt telefon";
            // 
            // iznosValue
            // 
            this.iznosValue.AutoSize = true;
            this.iznosValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iznosValue.Location = new System.Drawing.Point(110, 60);
            this.iznosValue.Name = "iznosValue";
            this.iznosValue.Size = new System.Drawing.Size(32, 13);
            this.iznosValue.TabIndex = 10;
            this.iznosValue.Text = "Iznos";
            // 
            // kupacValue
            // 
            this.kupacValue.AutoSize = true;
            this.kupacValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kupacValue.Location = new System.Drawing.Point(499, 16);
            this.kupacValue.Name = "kupacValue";
            this.kupacValue.Size = new System.Drawing.Size(38, 13);
            this.kupacValue.TabIndex = 9;
            this.kupacValue.Text = "Kupac";
            // 
            // adresaZaDostavuValue
            // 
            this.adresaZaDostavuValue.AutoSize = true;
            this.adresaZaDostavuValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adresaZaDostavuValue.Location = new System.Drawing.Point(499, 38);
            this.adresaZaDostavuValue.Name = "adresaZaDostavuValue";
            this.adresaZaDostavuValue.Size = new System.Drawing.Size(95, 13);
            this.adresaZaDostavuValue.TabIndex = 8;
            this.adresaZaDostavuValue.Text = "Adresa za dostavu";
            // 
            // datumValue
            // 
            this.datumValue.AutoSize = true;
            this.datumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datumValue.Location = new System.Drawing.Point(110, 38);
            this.datumValue.Name = "datumValue";
            this.datumValue.Size = new System.Drawing.Size(38, 13);
            this.datumValue.TabIndex = 7;
            this.datumValue.Text = "Datum";
            // 
            // brojNarudzbeValue
            // 
            this.brojNarudzbeValue.AutoSize = true;
            this.brojNarudzbeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brojNarudzbeValue.Location = new System.Drawing.Point(110, 16);
            this.brojNarudzbeValue.Name = "brojNarudzbeValue";
            this.brojNarudzbeValue.Size = new System.Drawing.Size(13, 13);
            this.brojNarudzbeValue.TabIndex = 6;
            this.brojNarudzbeValue.Text = "0";
            // 
            // kontaktTelLabel
            // 
            this.kontaktTelLabel.AutoSize = true;
            this.kontaktTelLabel.Location = new System.Drawing.Point(395, 60);
            this.kontaktTelLabel.Name = "kontaktTelLabel";
            this.kontaktTelLabel.Size = new System.Drawing.Size(82, 13);
            this.kontaktTelLabel.TabIndex = 5;
            this.kontaktTelLabel.Text = "Kontakt telefon:";
            // 
            // adresaZaDosavulabel
            // 
            this.adresaZaDosavulabel.AutoSize = true;
            this.adresaZaDosavulabel.Location = new System.Drawing.Point(395, 38);
            this.adresaZaDosavulabel.Name = "adresaZaDosavulabel";
            this.adresaZaDosavulabel.Size = new System.Drawing.Size(98, 13);
            this.adresaZaDosavulabel.TabIndex = 4;
            this.adresaZaDosavulabel.Text = "Adresa za dostavu:";
            // 
            // statusNarudzbeComboBox
            // 
            this.statusNarudzbeComboBox.FormattingEnabled = true;
            this.statusNarudzbeComboBox.Location = new System.Drawing.Point(63, 433);
            this.statusNarudzbeComboBox.Name = "statusNarudzbeComboBox";
            this.statusNarudzbeComboBox.Size = new System.Drawing.Size(194, 21);
            this.statusNarudzbeComboBox.TabIndex = 5;
            // 
            // narudzbaDetailsDataGridView
            // 
            this.narudzbaDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.narudzbaDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vrsta,
            this.Velicina,
            this.Kolicina,
            this.Sastojci});
            this.narudzbaDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.narudzbaDetailsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.narudzbaDetailsDataGridView.Name = "narudzbaDetailsDataGridView";
            this.narudzbaDetailsDataGridView.Size = new System.Drawing.Size(646, 305);
            this.narudzbaDetailsDataGridView.TabIndex = 6;
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta pizze";
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.Width = 150;
            // 
            // Velicina
            // 
            this.Velicina.DataPropertyName = "Velicina";
            this.Velicina.HeaderText = "Veličina pizze";
            this.Velicina.Name = "Velicina";
            this.Velicina.Width = 150;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Width = 150;
            // 
            // Sastojci
            // 
            this.Sastojci.DataPropertyName = "Sastojci";
            this.Sastojci.HeaderText = "Dodatni sastojci";
            this.Sastojci.Name = "Sastojci";
            this.Sastojci.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Status:";
            // 
            // procesirajButton
            // 
            this.procesirajButton.Location = new System.Drawing.Point(263, 431);
            this.procesirajButton.Name = "procesirajButton";
            this.procesirajButton.Size = new System.Drawing.Size(75, 23);
            this.procesirajButton.TabIndex = 8;
            this.procesirajButton.Text = "Procesiraj";
            this.procesirajButton.UseVisualStyleBackColor = true;
            this.procesirajButton.Click += new System.EventHandler(this.procesirajButton_Click);
            // 
            // zatvoriButton
            // 
            this.zatvoriButton.Location = new System.Drawing.Point(589, 431);
            this.zatvoriButton.Name = "zatvoriButton";
            this.zatvoriButton.Size = new System.Drawing.Size(75, 23);
            this.zatvoriButton.TabIndex = 9;
            this.zatvoriButton.Text = "Odustani";
            this.zatvoriButton.UseVisualStyleBackColor = true;
            this.zatvoriButton.Click += new System.EventHandler(this.zatvoriButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.narudzbaDetailsDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 324);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalji narudžbe";
            // 
            // DetaljiNarudzbeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.zatvoriButton);
            this.Controls.Add(this.procesirajButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusNarudzbeComboBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DetaljiNarudzbeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji Narudžbe";
            this.Load += new System.EventHandler(this.DetaljiNarudzbeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaDetailsDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label brojNarudzbeLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label kupacLabel;
        private System.Windows.Forms.Label iznosLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label kontaktTelLabel;
        private System.Windows.Forms.Label adresaZaDosavulabel;
        private System.Windows.Forms.ComboBox statusNarudzbeComboBox;
        private System.Windows.Forms.DataGridView narudzbaDetailsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button procesirajButton;
        private System.Windows.Forms.Label kontaktTelValue;
        private System.Windows.Forms.Label iznosValue;
        private System.Windows.Forms.Label kupacValue;
        private System.Windows.Forms.Label adresaZaDostavuValue;
        private System.Windows.Forms.Label datumValue;
        private System.Windows.Forms.Label brojNarudzbeValue;
        private System.Windows.Forms.Button zatvoriButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sastojci;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}