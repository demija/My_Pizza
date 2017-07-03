namespace MyPizza_GUI.Izvjestaji
{
    partial class NajprodavanijiProizvodiForm
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
            this.najprodavanijeVrsteDataGridView = new System.Windows.Forms.DataGridView();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojProdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.najprodavanijeVrsteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(387, 508);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 0;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.najprodavanijeVrsteDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 490);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Najprodavanije vrste";
            // 
            // najprodavanijeVrsteDataGridView
            // 
            this.najprodavanijeVrsteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.najprodavanijeVrsteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vrsta,
            this.Velicina,
            this.BrojProdavanja});
            this.najprodavanijeVrsteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.najprodavanijeVrsteDataGridView.Location = new System.Drawing.Point(3, 16);
            this.najprodavanijeVrsteDataGridView.Name = "najprodavanijeVrsteDataGridView";
            this.najprodavanijeVrsteDataGridView.Size = new System.Drawing.Size(444, 471);
            this.najprodavanijeVrsteDataGridView.TabIndex = 0;
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.Width = 150;
            // 
            // Velicina
            // 
            this.Velicina.DataPropertyName = "Velicina";
            this.Velicina.HeaderText = "Veličina";
            this.Velicina.Name = "Velicina";
            this.Velicina.Width = 150;
            // 
            // BrojProdavanja
            // 
            this.BrojProdavanja.DataPropertyName = "BrojProdavanja";
            this.BrojProdavanja.HeaderText = "Broj kupovina";
            this.BrojProdavanja.Name = "BrojProdavanja";
            // 
            // NajprodavanijiProizvodiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.odustaniButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NajprodavanijiProizvodiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Najprodavaniji Proizvodi";
            this.Load += new System.EventHandler(this.NajprodavanijiProizvodiForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.najprodavanijeVrsteDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView najprodavanijeVrsteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojProdavanja;
    }
}