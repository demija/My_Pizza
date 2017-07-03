namespace MyPizza_GUI
{
    partial class VelicinePizzaForm
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
            this.velicinaLabel = new System.Windows.Forms.Label();
            this.velicinaTextBox = new System.Windows.Forms.TextBox();
            this.promjerlabel = new System.Windows.Forms.Label();
            this.promjerTextBox = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.novaVelicinaGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pregledVelicinaGroupBox = new System.Windows.Forms.GroupBox();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.velicinePizzaDataGridView = new System.Windows.Forms.DataGridView();
            this.VelicinaPizzeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Velicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promjer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.novaVelicinaGroupBox.SuspendLayout();
            this.pregledVelicinaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.velicinePizzaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // velicinaLabel
            // 
            this.velicinaLabel.AutoSize = true;
            this.velicinaLabel.Location = new System.Drawing.Point(6, 22);
            this.velicinaLabel.Name = "velicinaLabel";
            this.velicinaLabel.Size = new System.Drawing.Size(47, 13);
            this.velicinaLabel.TabIndex = 0;
            this.velicinaLabel.Text = "Veličina:";
            // 
            // velicinaTextBox
            // 
            this.velicinaTextBox.Location = new System.Drawing.Point(59, 19);
            this.velicinaTextBox.Name = "velicinaTextBox";
            this.velicinaTextBox.Size = new System.Drawing.Size(130, 20);
            this.velicinaTextBox.TabIndex = 1;
            this.velicinaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.velicinaTextBox_Validating);
            // 
            // promjerlabel
            // 
            this.promjerlabel.AutoSize = true;
            this.promjerlabel.Location = new System.Drawing.Point(6, 48);
            this.promjerlabel.Name = "promjerlabel";
            this.promjerlabel.Size = new System.Drawing.Size(45, 13);
            this.promjerlabel.TabIndex = 0;
            this.promjerlabel.Text = "Promjer:";
            // 
            // promjerTextBox
            // 
            this.promjerTextBox.Location = new System.Drawing.Point(59, 45);
            this.promjerTextBox.Name = "promjerTextBox";
            this.promjerTextBox.Size = new System.Drawing.Size(103, 20);
            this.promjerTextBox.TabIndex = 1;
            this.promjerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.promjerTextBox_KeyPress);
            this.promjerTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.promjerTextBox_Validating);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(114, 71);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 2;
            this.dodajButton.Text = "Sačuvaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // novaVelicinaGroupBox
            // 
            this.novaVelicinaGroupBox.Controls.Add(this.label1);
            this.novaVelicinaGroupBox.Controls.Add(this.velicinaTextBox);
            this.novaVelicinaGroupBox.Controls.Add(this.dodajButton);
            this.novaVelicinaGroupBox.Controls.Add(this.velicinaLabel);
            this.novaVelicinaGroupBox.Controls.Add(this.promjerTextBox);
            this.novaVelicinaGroupBox.Controls.Add(this.promjerlabel);
            this.novaVelicinaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.novaVelicinaGroupBox.Name = "novaVelicinaGroupBox";
            this.novaVelicinaGroupBox.Size = new System.Drawing.Size(211, 102);
            this.novaVelicinaGroupBox.TabIndex = 3;
            this.novaVelicinaGroupBox.TabStop = false;
            this.novaVelicinaGroupBox.Text = "Nova veličina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "cm";
            // 
            // pregledVelicinaGroupBox
            // 
            this.pregledVelicinaGroupBox.Controls.Add(this.obrisiButton);
            this.pregledVelicinaGroupBox.Controls.Add(this.velicinePizzaDataGridView);
            this.pregledVelicinaGroupBox.Location = new System.Drawing.Point(229, 12);
            this.pregledVelicinaGroupBox.Name = "pregledVelicinaGroupBox";
            this.pregledVelicinaGroupBox.Size = new System.Drawing.Size(313, 170);
            this.pregledVelicinaGroupBox.TabIndex = 4;
            this.pregledVelicinaGroupBox.TabStop = false;
            this.pregledVelicinaGroupBox.Text = "Pregled veličina";
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(233, 141);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(75, 23);
            this.obrisiButton.TabIndex = 1;
            this.obrisiButton.Text = "Obriši";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // velicinePizzaDataGridView
            // 
            this.velicinePizzaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.velicinePizzaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VelicinaPizzeId,
            this.Velicina,
            this.Promjer});
            this.velicinePizzaDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.velicinePizzaDataGridView.Location = new System.Drawing.Point(3, 16);
            this.velicinePizzaDataGridView.Name = "velicinePizzaDataGridView";
            this.velicinePizzaDataGridView.Size = new System.Drawing.Size(307, 119);
            this.velicinePizzaDataGridView.TabIndex = 0;
            this.velicinePizzaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.velicinePizzaDataGridView_CellDoubleClick);
            // 
            // VelicinaPizzeId
            // 
            this.VelicinaPizzeId.DataPropertyName = "VelicinaPizzeId";
            this.VelicinaPizzeId.HeaderText = "ID";
            this.VelicinaPizzeId.Name = "VelicinaPizzeId";
            this.VelicinaPizzeId.Width = 60;
            // 
            // Velicina
            // 
            this.Velicina.DataPropertyName = "Velicina";
            this.Velicina.HeaderText = "Veličina";
            this.Velicina.Name = "Velicina";
            // 
            // Promjer
            // 
            this.Promjer.DataPropertyName = "Promjer";
            this.Promjer.HeaderText = "Promjer";
            this.Promjer.Name = "Promjer";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(467, 188);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 5;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // VelicinePizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 221);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.pregledVelicinaGroupBox);
            this.Controls.Add(this.novaVelicinaGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VelicinePizzaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Veličine pizza";
            this.Load += new System.EventHandler(this.VelicinePizzaForm_Load);
            this.novaVelicinaGroupBox.ResumeLayout(false);
            this.novaVelicinaGroupBox.PerformLayout();
            this.pregledVelicinaGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.velicinePizzaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label velicinaLabel;
        private System.Windows.Forms.TextBox velicinaTextBox;
        private System.Windows.Forms.Label promjerlabel;
        private System.Windows.Forms.TextBox promjerTextBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.GroupBox novaVelicinaGroupBox;
        private System.Windows.Forms.GroupBox pregledVelicinaGroupBox;
        private System.Windows.Forms.DataGridView velicinePizzaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn VelicinaPizzeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Velicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promjer;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}