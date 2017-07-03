namespace MyPizza_GUI
{
    partial class SastojciForm
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
            this.noviSastojakGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.dodatnaCijenaTextBox = new System.Windows.Forms.TextBox();
            this.dodatnaCijenaLabel = new System.Windows.Forms.Label();
            this.baznaCijenaTextBox = new System.Windows.Forms.TextBox();
            this.baznaCijenaLabel = new System.Windows.Forms.Label();
            this.sastojakTextBox = new System.Windows.Forms.TextBox();
            this.sastojakLabel = new System.Windows.Forms.Label();
            this.sastojciGroupBox = new System.Windows.Forms.GroupBox();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.sastojciDataGridView = new System.Windows.Forms.DataGridView();
            this.SastojakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sastojak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaznaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DodatnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.noviSastojakGroupBox.SuspendLayout();
            this.sastojciGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sastojciDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // noviSastojakGroupBox
            // 
            this.noviSastojakGroupBox.Controls.Add(this.label2);
            this.noviSastojakGroupBox.Controls.Add(this.label1);
            this.noviSastojakGroupBox.Controls.Add(this.dodajButton);
            this.noviSastojakGroupBox.Controls.Add(this.dodatnaCijenaTextBox);
            this.noviSastojakGroupBox.Controls.Add(this.dodatnaCijenaLabel);
            this.noviSastojakGroupBox.Controls.Add(this.baznaCijenaTextBox);
            this.noviSastojakGroupBox.Controls.Add(this.baznaCijenaLabel);
            this.noviSastojakGroupBox.Controls.Add(this.sastojakTextBox);
            this.noviSastojakGroupBox.Controls.Add(this.sastojakLabel);
            this.noviSastojakGroupBox.Location = new System.Drawing.Point(12, 12);
            this.noviSastojakGroupBox.Name = "noviSastojakGroupBox";
            this.noviSastojakGroupBox.Size = new System.Drawing.Size(259, 134);
            this.noviSastojakGroupBox.TabIndex = 0;
            this.noviSastojakGroupBox.TabStop = false;
            this.noviSastojakGroupBox.Text = "Novi sastojak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "KM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "KM";
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(169, 97);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 4;
            this.dodajButton.Text = "Sačuvaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // dodatnaCijenaTextBox
            // 
            this.dodatnaCijenaTextBox.Location = new System.Drawing.Point(94, 71);
            this.dodatnaCijenaTextBox.Name = "dodatnaCijenaTextBox";
            this.dodatnaCijenaTextBox.Size = new System.Drawing.Size(121, 20);
            this.dodatnaCijenaTextBox.TabIndex = 3;
            this.dodatnaCijenaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dodatnaCijenaTextBox_KeyPress);
            this.dodatnaCijenaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dodatnaCijenaTextBox_Validating);
            // 
            // dodatnaCijenaLabel
            // 
            this.dodatnaCijenaLabel.AutoSize = true;
            this.dodatnaCijenaLabel.Location = new System.Drawing.Point(6, 74);
            this.dodatnaCijenaLabel.Name = "dodatnaCijenaLabel";
            this.dodatnaCijenaLabel.Size = new System.Drawing.Size(82, 13);
            this.dodatnaCijenaLabel.TabIndex = 0;
            this.dodatnaCijenaLabel.Text = "Dodatna cijena:";
            // 
            // baznaCijenaTextBox
            // 
            this.baznaCijenaTextBox.Location = new System.Drawing.Point(94, 45);
            this.baznaCijenaTextBox.Name = "baznaCijenaTextBox";
            this.baznaCijenaTextBox.Size = new System.Drawing.Size(121, 20);
            this.baznaCijenaTextBox.TabIndex = 2;
            this.baznaCijenaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.baznaCijenaTextBox_KeyPress);
            this.baznaCijenaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.baznaCijenaTextBox_Validating);
            // 
            // baznaCijenaLabel
            // 
            this.baznaCijenaLabel.AutoSize = true;
            this.baznaCijenaLabel.Location = new System.Drawing.Point(6, 48);
            this.baznaCijenaLabel.Name = "baznaCijenaLabel";
            this.baznaCijenaLabel.Size = new System.Drawing.Size(71, 13);
            this.baznaCijenaLabel.TabIndex = 0;
            this.baznaCijenaLabel.Text = "Bazna cijena:";
            // 
            // sastojakTextBox
            // 
            this.sastojakTextBox.Location = new System.Drawing.Point(94, 19);
            this.sastojakTextBox.Name = "sastojakTextBox";
            this.sastojakTextBox.Size = new System.Drawing.Size(150, 20);
            this.sastojakTextBox.TabIndex = 1;
            this.sastojakTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.sastojakTextBox_Validating);
            // 
            // sastojakLabel
            // 
            this.sastojakLabel.AutoSize = true;
            this.sastojakLabel.Location = new System.Drawing.Point(6, 22);
            this.sastojakLabel.Name = "sastojakLabel";
            this.sastojakLabel.Size = new System.Drawing.Size(51, 13);
            this.sastojakLabel.TabIndex = 0;
            this.sastojakLabel.Text = "Sastojak:";
            // 
            // sastojciGroupBox
            // 
            this.sastojciGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sastojciGroupBox.Controls.Add(this.obrisiButton);
            this.sastojciGroupBox.Controls.Add(this.sastojciDataGridView);
            this.sastojciGroupBox.Location = new System.Drawing.Point(277, 12);
            this.sastojciGroupBox.Name = "sastojciGroupBox";
            this.sastojciGroupBox.Size = new System.Drawing.Size(407, 284);
            this.sastojciGroupBox.TabIndex = 1;
            this.sastojciGroupBox.TabStop = false;
            this.sastojciGroupBox.Text = "Pregled sastojaka";
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(326, 254);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(75, 23);
            this.obrisiButton.TabIndex = 6;
            this.obrisiButton.Text = "Obriši";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // sastojciDataGridView
            // 
            this.sastojciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sastojciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SastojakId,
            this.Sastojak,
            this.BaznaCijena,
            this.DodatnaCijena});
            this.sastojciDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.sastojciDataGridView.Location = new System.Drawing.Point(3, 16);
            this.sastojciDataGridView.Name = "sastojciDataGridView";
            this.sastojciDataGridView.Size = new System.Drawing.Size(401, 232);
            this.sastojciDataGridView.TabIndex = 5;
            this.sastojciDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sastojciDataGridView_CellDoubleClick);
            // 
            // SastojakId
            // 
            this.SastojakId.DataPropertyName = "SastojakId";
            this.SastojakId.HeaderText = "ID";
            this.SastojakId.Name = "SastojakId";
            this.SastojakId.Width = 60;
            // 
            // Sastojak
            // 
            this.Sastojak.DataPropertyName = "Sastojak";
            this.Sastojak.HeaderText = "Sastojak";
            this.Sastojak.Name = "Sastojak";
            // 
            // BaznaCijena
            // 
            this.BaznaCijena.DataPropertyName = "BaznaCijena";
            this.BaznaCijena.HeaderText = "Bazna cijena";
            this.BaznaCijena.Name = "BaznaCijena";
            this.BaznaCijena.Width = 90;
            // 
            // DodatnaCijena
            // 
            this.DodatnaCijena.DataPropertyName = "DodatnaCijena";
            this.DodatnaCijena.HeaderText = "Dodatna cijena";
            this.DodatnaCijena.Name = "DodatnaCijena";
            this.DodatnaCijena.Width = 90;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(609, 302);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 2;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // SastojciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 331);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.sastojciGroupBox);
            this.Controls.Add(this.noviSastojakGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SastojciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sastojci pizza";
            this.Load += new System.EventHandler(this.SastojciForm_Load);
            this.noviSastojakGroupBox.ResumeLayout(false);
            this.noviSastojakGroupBox.PerformLayout();
            this.sastojciGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sastojciDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox noviSastojakGroupBox;
        private System.Windows.Forms.TextBox dodatnaCijenaTextBox;
        private System.Windows.Forms.Label dodatnaCijenaLabel;
        private System.Windows.Forms.TextBox baznaCijenaTextBox;
        private System.Windows.Forms.Label baznaCijenaLabel;
        private System.Windows.Forms.TextBox sastojakTextBox;
        private System.Windows.Forms.Label sastojakLabel;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.GroupBox sastojciGroupBox;
        private System.Windows.Forms.DataGridView sastojciDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SastojakId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sastojak;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaznaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DodatnaCijena;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}