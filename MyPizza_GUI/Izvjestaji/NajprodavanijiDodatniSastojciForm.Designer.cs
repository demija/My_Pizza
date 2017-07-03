namespace MyPizza_GUI.Izvjestaji
{
    partial class NajprodavanijiDodatniSastojciForm
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
            this.najprodavanijiDodatniSastojciDataGridView = new System.Windows.Forms.DataGridView();
            this.Sastojak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.najprodavanijiDodatniSastojciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(236, 411);
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
            this.groupBox1.Controls.Add(this.najprodavanijiDodatniSastojciDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 393);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Najprodavaniji dodatni sastojci";
            // 
            // najprodavanijiDodatniSastojciDataGridView
            // 
            this.najprodavanijiDodatniSastojciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.najprodavanijiDodatniSastojciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sastojak,
            this.Broj});
            this.najprodavanijiDodatniSastojciDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.najprodavanijiDodatniSastojciDataGridView.Location = new System.Drawing.Point(3, 16);
            this.najprodavanijiDodatniSastojciDataGridView.Name = "najprodavanijiDodatniSastojciDataGridView";
            this.najprodavanijiDodatniSastojciDataGridView.Size = new System.Drawing.Size(293, 374);
            this.najprodavanijiDodatniSastojciDataGridView.TabIndex = 0;
            // 
            // Sastojak
            // 
            this.Sastojak.DataPropertyName = "Sastojak";
            this.Sastojak.HeaderText = "Sastojak";
            this.Sastojak.Name = "Sastojak";
            this.Sastojak.Width = 150;
            // 
            // Broj
            // 
            this.Broj.DataPropertyName = "Broj";
            this.Broj.HeaderText = "Broj kupovina";
            this.Broj.Name = "Broj";
            // 
            // NajprodavanijiDodatniSastojciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.odustaniButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NajprodavanijiDodatniSastojciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Najprodavaniji Dodatni Sastojci";
            this.Load += new System.EventHandler(this.NajprodavanijiDodatniSastojciForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.najprodavanijiDodatniSastojciDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView najprodavanijiDodatniSastojciDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sastojak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj;
    }
}