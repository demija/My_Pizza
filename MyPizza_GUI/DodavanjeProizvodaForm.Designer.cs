namespace MyPizza_GUI
{
    partial class DodavanjeProizvodaForm
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
            this.vrstaLabel = new System.Windows.Forms.Label();
            this.vrstaComboBox = new System.Windows.Forms.ComboBox();
            this.velicinaLabel = new System.Windows.Forms.Label();
            this.velicinaComboBox = new System.Windows.Forms.ComboBox();
            this.cijenaLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kmLabel = new System.Windows.Forms.Label();
            this.sacuvajButton = new System.Windows.Forms.Button();
            this.cijenaComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.pizzeDataGridView = new System.Windows.Forms.DataGridView();
            this.pizzePonudaGroupBox = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeDataGridView)).BeginInit();
            this.pizzePonudaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // vrstaLabel
            // 
            this.vrstaLabel.AutoSize = true;
            this.vrstaLabel.Location = new System.Drawing.Point(6, 22);
            this.vrstaLabel.Name = "vrstaLabel";
            this.vrstaLabel.Size = new System.Drawing.Size(34, 13);
            this.vrstaLabel.TabIndex = 0;
            this.vrstaLabel.Text = "Vrsta:";
            // 
            // vrstaComboBox
            // 
            this.vrstaComboBox.FormattingEnabled = true;
            this.vrstaComboBox.Location = new System.Drawing.Point(64, 19);
            this.vrstaComboBox.Name = "vrstaComboBox";
            this.vrstaComboBox.Size = new System.Drawing.Size(146, 21);
            this.vrstaComboBox.TabIndex = 1;
            // 
            // velicinaLabel
            // 
            this.velicinaLabel.AutoSize = true;
            this.velicinaLabel.Location = new System.Drawing.Point(6, 49);
            this.velicinaLabel.Name = "velicinaLabel";
            this.velicinaLabel.Size = new System.Drawing.Size(47, 13);
            this.velicinaLabel.TabIndex = 0;
            this.velicinaLabel.Text = "Veličina:";
            // 
            // velicinaComboBox
            // 
            this.velicinaComboBox.FormattingEnabled = true;
            this.velicinaComboBox.Location = new System.Drawing.Point(64, 46);
            this.velicinaComboBox.Name = "velicinaComboBox";
            this.velicinaComboBox.Size = new System.Drawing.Size(146, 21);
            this.velicinaComboBox.TabIndex = 2;
            // 
            // cijenaLabel
            // 
            this.cijenaLabel.AutoSize = true;
            this.cijenaLabel.Location = new System.Drawing.Point(6, 103);
            this.cijenaLabel.Name = "cijenaLabel";
            this.cijenaLabel.Size = new System.Drawing.Size(39, 13);
            this.cijenaLabel.TabIndex = 2;
            this.cijenaLabel.Text = "Cijena:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kmLabel);
            this.groupBox1.Controls.Add(this.sacuvajButton);
            this.groupBox1.Controls.Add(this.vrstaComboBox);
            this.groupBox1.Controls.Add(this.cijenaLabel);
            this.groupBox1.Controls.Add(this.vrstaLabel);
            this.groupBox1.Controls.Add(this.cijenaComboBox);
            this.groupBox1.Controls.Add(this.statusComboBox);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.velicinaComboBox);
            this.groupBox1.Controls.Add(this.velicinaLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Pizza";
            // 
            // kmLabel
            // 
            this.kmLabel.AutoSize = true;
            this.kmLabel.Location = new System.Drawing.Point(187, 103);
            this.kmLabel.Name = "kmLabel";
            this.kmLabel.Size = new System.Drawing.Size(23, 13);
            this.kmLabel.TabIndex = 0;
            this.kmLabel.Text = "KM";
            // 
            // sacuvajButton
            // 
            this.sacuvajButton.Location = new System.Drawing.Point(135, 127);
            this.sacuvajButton.Name = "sacuvajButton";
            this.sacuvajButton.Size = new System.Drawing.Size(75, 23);
            this.sacuvajButton.TabIndex = 7;
            this.sacuvajButton.Text = "Sačuvaj";
            this.sacuvajButton.UseVisualStyleBackColor = true;
            this.sacuvajButton.Click += new System.EventHandler(this.sacuvajButton_Click);
            // 
            // cijenaComboBox
            // 
            this.cijenaComboBox.FormattingEnabled = true;
            this.cijenaComboBox.Location = new System.Drawing.Point(64, 100);
            this.cijenaComboBox.Name = "cijenaComboBox";
            this.cijenaComboBox.Size = new System.Drawing.Size(117, 21);
            this.cijenaComboBox.TabIndex = 4;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(64, 73);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(146, 21);
            this.statusComboBox.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 76);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Status:";
            // 
            // pizzeDataGridView
            // 
            this.pizzeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pizzeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pizzeDataGridView.Location = new System.Drawing.Point(3, 16);
            this.pizzeDataGridView.Name = "pizzeDataGridView";
            this.pizzeDataGridView.Size = new System.Drawing.Size(724, 432);
            this.pizzeDataGridView.TabIndex = 8;
            // 
            // pizzePonudaGroupBox
            // 
            this.pizzePonudaGroupBox.Controls.Add(this.pizzeDataGridView);
            this.pizzePonudaGroupBox.Location = new System.Drawing.Point(236, 12);
            this.pizzePonudaGroupBox.Name = "pizzePonudaGroupBox";
            this.pizzePonudaGroupBox.Size = new System.Drawing.Size(730, 451);
            this.pizzePonudaGroupBox.TabIndex = 5;
            this.pizzePonudaGroupBox.TabStop = false;
            this.pizzePonudaGroupBox.Text = "Pizze u ponudi";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(891, 466);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 6;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // DodavanjeProizvodaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 498);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.pizzePonudaGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DodavanjeProizvodaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizze ponuda";
            this.Load += new System.EventHandler(this.DodavanjeProizvodaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeDataGridView)).EndInit();
            this.pizzePonudaGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label vrstaLabel;
        private System.Windows.Forms.ComboBox vrstaComboBox;
        private System.Windows.Forms.Label velicinaLabel;
        private System.Windows.Forms.ComboBox velicinaComboBox;
        private System.Windows.Forms.Label cijenaLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sacuvajButton;
        private System.Windows.Forms.DataGridView pizzeDataGridView;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox cijenaComboBox;
        private System.Windows.Forms.GroupBox pizzePonudaGroupBox;
        private System.Windows.Forms.Label kmLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button odustaniButton;
    }
}