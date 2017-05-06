namespace MyPizza_GUI
{
    partial class StatusiPizzaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.opisLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusiGroupBox = new System.Windows.Forms.GroupBox();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.statusiDataGridView = new System.Windows.Forms.DataGridView();
            this.StatusPizzeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusPizze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.statusiGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dodajButton);
            this.groupBox1.Controls.Add(this.opisTextBox);
            this.groupBox1.Controls.Add(this.opisLabel);
            this.groupBox1.Controls.Add(this.statusTextBox);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novi status";
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(127, 95);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 3;
            this.dodajButton.Text = "Sačuvaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // opisTextBox
            // 
            this.opisTextBox.Location = new System.Drawing.Point(52, 49);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(150, 40);
            this.opisTextBox.TabIndex = 2;
            // 
            // opisLabel
            // 
            this.opisLabel.AutoSize = true;
            this.opisLabel.Location = new System.Drawing.Point(6, 52);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(31, 13);
            this.opisLabel.TabIndex = 0;
            this.opisLabel.Text = "Opis:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(52, 23);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(150, 20);
            this.statusTextBox.TabIndex = 1;
            this.statusTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.statusTextBox_Validating);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 26);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status:";
            // 
            // statusiGroupBox
            // 
            this.statusiGroupBox.Controls.Add(this.obrisiButton);
            this.statusiGroupBox.Controls.Add(this.statusiDataGridView);
            this.statusiGroupBox.Location = new System.Drawing.Point(242, 12);
            this.statusiGroupBox.Name = "statusiGroupBox";
            this.statusiGroupBox.Size = new System.Drawing.Size(313, 198);
            this.statusiGroupBox.TabIndex = 1;
            this.statusiGroupBox.TabStop = false;
            this.statusiGroupBox.Text = "Pregled statusa";
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(232, 169);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(75, 23);
            this.obrisiButton.TabIndex = 5;
            this.obrisiButton.Text = "Obriši";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // statusiDataGridView
            // 
            this.statusiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StatusPizzeId,
            this.StatusPizze,
            this.Opis});
            this.statusiDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusiDataGridView.Location = new System.Drawing.Point(3, 16);
            this.statusiDataGridView.Name = "statusiDataGridView";
            this.statusiDataGridView.Size = new System.Drawing.Size(307, 147);
            this.statusiDataGridView.TabIndex = 4;
            this.statusiDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.statusiDataGridView_CellDoubleClick);
            // 
            // StatusPizzeId
            // 
            this.StatusPizzeId.DataPropertyName = "StatusPizzeId";
            this.StatusPizzeId.HeaderText = "ID";
            this.StatusPizzeId.Name = "StatusPizzeId";
            this.StatusPizzeId.Width = 60;
            // 
            // StatusPizze
            // 
            this.StatusPizze.DataPropertyName = "StatusPizze";
            this.StatusPizze.HeaderText = "Status";
            this.StatusPizze.Name = "StatusPizze";
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(480, 216);
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
            // StatusiPizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 247);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.statusiGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatusiPizzaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statusi pizza";
            this.Load += new System.EventHandler(this.StatusiPizzaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusiGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Label opisLabel;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox statusiGroupBox;
        private System.Windows.Forms.DataGridView statusiDataGridView;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusPizzeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusPizze;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}