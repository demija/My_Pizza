namespace MyPizza_GUI
{
    partial class CijenePizzaForm
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
            this.novaCijenaGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.opisLabel = new System.Windows.Forms.Label();
            this.cijenaLabel = new System.Windows.Forms.Label();
            this.pregledCijenaGroupBox = new System.Windows.Forms.GroupBox();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.cijenePizzaDataGridView = new System.Windows.Forms.DataGridView();
            this.CijenaPizzeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cijenaTextBox = new System.Windows.Forms.TextBox();
            this.novaCijenaGroupBox.SuspendLayout();
            this.pregledCijenaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cijenePizzaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // novaCijenaGroupBox
            // 
            this.novaCijenaGroupBox.Controls.Add(this.cijenaTextBox);
            this.novaCijenaGroupBox.Controls.Add(this.label1);
            this.novaCijenaGroupBox.Controls.Add(this.dodajButton);
            this.novaCijenaGroupBox.Controls.Add(this.opisTextBox);
            this.novaCijenaGroupBox.Controls.Add(this.opisLabel);
            this.novaCijenaGroupBox.Controls.Add(this.cijenaLabel);
            this.novaCijenaGroupBox.Location = new System.Drawing.Point(12, 12);
            this.novaCijenaGroupBox.Name = "novaCijenaGroupBox";
            this.novaCijenaGroupBox.Size = new System.Drawing.Size(201, 126);
            this.novaCijenaGroupBox.TabIndex = 0;
            this.novaCijenaGroupBox.TabStop = false;
            this.novaCijenaGroupBox.Text = "Nova cijena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "KM";
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(115, 91);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 3;
            this.dodajButton.Text = "Sačuvaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // opisTextBox
            // 
            this.opisTextBox.Location = new System.Drawing.Point(51, 45);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(139, 40);
            this.opisTextBox.TabIndex = 2;
            // 
            // opisLabel
            // 
            this.opisLabel.AutoSize = true;
            this.opisLabel.Location = new System.Drawing.Point(6, 48);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(31, 13);
            this.opisLabel.TabIndex = 0;
            this.opisLabel.Text = "Opis:";
            // 
            // cijenaLabel
            // 
            this.cijenaLabel.AutoSize = true;
            this.cijenaLabel.Location = new System.Drawing.Point(6, 22);
            this.cijenaLabel.Name = "cijenaLabel";
            this.cijenaLabel.Size = new System.Drawing.Size(39, 13);
            this.cijenaLabel.TabIndex = 0;
            this.cijenaLabel.Text = "Cijena:";
            // 
            // pregledCijenaGroupBox
            // 
            this.pregledCijenaGroupBox.Controls.Add(this.obrisiButton);
            this.pregledCijenaGroupBox.Controls.Add(this.cijenePizzaDataGridView);
            this.pregledCijenaGroupBox.Location = new System.Drawing.Point(219, 12);
            this.pregledCijenaGroupBox.Name = "pregledCijenaGroupBox";
            this.pregledCijenaGroupBox.Size = new System.Drawing.Size(297, 209);
            this.pregledCijenaGroupBox.TabIndex = 1;
            this.pregledCijenaGroupBox.TabStop = false;
            this.pregledCijenaGroupBox.Text = "Pregled cijena";
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(216, 178);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(75, 23);
            this.obrisiButton.TabIndex = 5;
            this.obrisiButton.Text = "Obriši";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // cijenePizzaDataGridView
            // 
            this.cijenePizzaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cijenePizzaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CijenaPizzeId,
            this.Cijena,
            this.Opis});
            this.cijenePizzaDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.cijenePizzaDataGridView.Location = new System.Drawing.Point(3, 16);
            this.cijenePizzaDataGridView.Name = "cijenePizzaDataGridView";
            this.cijenePizzaDataGridView.Size = new System.Drawing.Size(291, 156);
            this.cijenePizzaDataGridView.TabIndex = 4;
            this.cijenePizzaDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cijenePizzaDataGridView_CellDoubleClick);
            // 
            // CijenaPizzeId
            // 
            this.CijenaPizzeId.DataPropertyName = "CijenaPizzeId";
            this.CijenaPizzeId.HeaderText = "ID";
            this.CijenaPizzeId.Name = "CijenaPizzeId";
            this.CijenaPizzeId.Width = 60;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.Width = 70;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(441, 227);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cijenaTextBox
            // 
            this.cijenaTextBox.Location = new System.Drawing.Point(51, 19);
            this.cijenaTextBox.Name = "cijenaTextBox";
            this.cijenaTextBox.Size = new System.Drawing.Size(110, 20);
            this.cijenaTextBox.TabIndex = 1;
            this.cijenaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cijenaTextBox_KeyPress);
            this.cijenaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cijenaTextBox_Validating);
            // 
            // CijenePizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 258);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.pregledCijenaGroupBox);
            this.Controls.Add(this.novaCijenaGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CijenePizzaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cijene Pizza";
            this.Load += new System.EventHandler(this.CijenePizza_Load);
            this.novaCijenaGroupBox.ResumeLayout(false);
            this.novaCijenaGroupBox.PerformLayout();
            this.pregledCijenaGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cijenePizzaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox novaCijenaGroupBox;
        private System.Windows.Forms.Label cijenaLabel;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Label opisLabel;
        private System.Windows.Forms.GroupBox pregledCijenaGroupBox;
        private System.Windows.Forms.DataGridView cijenePizzaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button obrisiButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaPizzeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox cijenaTextBox;
    }
}