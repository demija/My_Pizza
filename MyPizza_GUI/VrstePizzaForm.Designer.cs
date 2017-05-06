namespace MyPizza_GUI
{
    partial class VrstePizzaForm
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
            this.vrstaPizzePictureBox = new System.Windows.Forms.PictureBox();
            this.dodajSlikuButton = new System.Windows.Forms.Button();
            this.slikaTextBox = new System.Windows.Forms.TextBox();
            this.slikaLabel = new System.Windows.Forms.Label();
            this.dodajButton = new System.Windows.Forms.Button();
            this.sastojciCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.sastojciLabel = new System.Windows.Forms.Label();
            this.opisLabel = new System.Windows.Forms.Label();
            this.vrstaTextBox = new System.Windows.Forms.TextBox();
            this.vrstaLabel = new System.Windows.Forms.Label();
            this.vrstePizzaGroupBox = new System.Windows.Forms.GroupBox();
            this.vrstePizzaDataGridView = new System.Windows.Forms.DataGridView();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.VrstaPizzeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDodavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPizzePictureBox)).BeginInit();
            this.vrstePizzaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstePizzaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vrstaPizzePictureBox);
            this.groupBox1.Controls.Add(this.dodajSlikuButton);
            this.groupBox1.Controls.Add(this.slikaTextBox);
            this.groupBox1.Controls.Add(this.slikaLabel);
            this.groupBox1.Controls.Add(this.dodajButton);
            this.groupBox1.Controls.Add(this.sastojciCheckedListBox);
            this.groupBox1.Controls.Add(this.opisTextBox);
            this.groupBox1.Controls.Add(this.sastojciLabel);
            this.groupBox1.Controls.Add(this.opisLabel);
            this.groupBox1.Controls.Add(this.vrstaTextBox);
            this.groupBox1.Controls.Add(this.vrstaLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 516);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova vrsta pizze";
            // 
            // vrstaPizzePictureBox
            // 
            this.vrstaPizzePictureBox.Location = new System.Drawing.Point(94, 169);
            this.vrstaPizzePictureBox.Name = "vrstaPizzePictureBox";
            this.vrstaPizzePictureBox.Size = new System.Drawing.Size(120, 120);
            this.vrstaPizzePictureBox.TabIndex = 8;
            this.vrstaPizzePictureBox.TabStop = false;
            // 
            // dodajSlikuButton
            // 
            this.dodajSlikuButton.Location = new System.Drawing.Point(139, 140);
            this.dodajSlikuButton.Name = "dodajSlikuButton";
            this.dodajSlikuButton.Size = new System.Drawing.Size(75, 23);
            this.dodajSlikuButton.TabIndex = 4;
            this.dodajSlikuButton.Text = "Dodaj sliku";
            this.dodajSlikuButton.UseVisualStyleBackColor = true;
            this.dodajSlikuButton.Click += new System.EventHandler(this.dodajSlikuButton_Click);
            // 
            // slikaTextBox
            // 
            this.slikaTextBox.Location = new System.Drawing.Point(64, 114);
            this.slikaTextBox.Name = "slikaTextBox";
            this.slikaTextBox.Size = new System.Drawing.Size(150, 20);
            this.slikaTextBox.TabIndex = 3;
            // 
            // slikaLabel
            // 
            this.slikaLabel.AutoSize = true;
            this.slikaLabel.Location = new System.Drawing.Point(6, 117);
            this.slikaLabel.Name = "slikaLabel";
            this.slikaLabel.Size = new System.Drawing.Size(33, 13);
            this.slikaLabel.TabIndex = 5;
            this.slikaLabel.Text = "Slika:";
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(139, 485);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 23);
            this.dodajButton.TabIndex = 6;
            this.dodajButton.Text = "Sačuvaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // sastojciCheckedListBox
            // 
            this.sastojciCheckedListBox.FormattingEnabled = true;
            this.sastojciCheckedListBox.Location = new System.Drawing.Point(64, 295);
            this.sastojciCheckedListBox.Name = "sastojciCheckedListBox";
            this.sastojciCheckedListBox.Size = new System.Drawing.Size(150, 184);
            this.sastojciCheckedListBox.TabIndex = 5;
            this.sastojciCheckedListBox.Validating += new System.ComponentModel.CancelEventHandler(this.sastojciCheckedListBox_Validating);
            // 
            // opisTextBox
            // 
            this.opisTextBox.Location = new System.Drawing.Point(64, 48);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(150, 60);
            this.opisTextBox.TabIndex = 2;
            this.opisTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.opisTextBox_Validating);
            // 
            // sastojciLabel
            // 
            this.sastojciLabel.AutoSize = true;
            this.sastojciLabel.Location = new System.Drawing.Point(6, 295);
            this.sastojciLabel.Name = "sastojciLabel";
            this.sastojciLabel.Size = new System.Drawing.Size(47, 13);
            this.sastojciLabel.TabIndex = 2;
            this.sastojciLabel.Text = "Sastojci:";
            // 
            // opisLabel
            // 
            this.opisLabel.AutoSize = true;
            this.opisLabel.Location = new System.Drawing.Point(6, 51);
            this.opisLabel.Name = "opisLabel";
            this.opisLabel.Size = new System.Drawing.Size(31, 13);
            this.opisLabel.TabIndex = 0;
            this.opisLabel.Text = "Opis:";
            // 
            // vrstaTextBox
            // 
            this.vrstaTextBox.Location = new System.Drawing.Point(64, 22);
            this.vrstaTextBox.Name = "vrstaTextBox";
            this.vrstaTextBox.Size = new System.Drawing.Size(150, 20);
            this.vrstaTextBox.TabIndex = 1;
            this.vrstaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.vrstaTextBox_Validating);
            // 
            // vrstaLabel
            // 
            this.vrstaLabel.AutoSize = true;
            this.vrstaLabel.Location = new System.Drawing.Point(6, 25);
            this.vrstaLabel.Name = "vrstaLabel";
            this.vrstaLabel.Size = new System.Drawing.Size(34, 13);
            this.vrstaLabel.TabIndex = 0;
            this.vrstaLabel.Text = "Vrsta:";
            // 
            // vrstePizzaGroupBox
            // 
            this.vrstePizzaGroupBox.Controls.Add(this.vrstePizzaDataGridView);
            this.vrstePizzaGroupBox.Location = new System.Drawing.Point(257, 12);
            this.vrstePizzaGroupBox.Name = "vrstePizzaGroupBox";
            this.vrstePizzaGroupBox.Size = new System.Drawing.Size(532, 516);
            this.vrstePizzaGroupBox.TabIndex = 1;
            this.vrstePizzaGroupBox.TabStop = false;
            this.vrstePizzaGroupBox.Text = "Pregled vrsta pizza";
            // 
            // vrstePizzaDataGridView
            // 
            this.vrstePizzaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vrstePizzaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vrstePizzaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VrstaPizzeId,
            this.Vrsta,
            this.Opis,
            this.DatumDodavanja,
            this.SlikaThumb});
            this.vrstePizzaDataGridView.Location = new System.Drawing.Point(6, 19);
            this.vrstePizzaDataGridView.Name = "vrstePizzaDataGridView";
            this.vrstePizzaDataGridView.Size = new System.Drawing.Size(520, 491);
            this.vrstePizzaDataGridView.TabIndex = 7;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(714, 534);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 8;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // VrstaPizzeId
            // 
            this.VrstaPizzeId.DataPropertyName = "VrstaPizzeId";
            this.VrstaPizzeId.HeaderText = "ID";
            this.VrstaPizzeId.Name = "VrstaPizzeId";
            this.VrstaPizzeId.Width = 60;
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.Name = "Vrsta";
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.Width = 360;
            // 
            // DatumDodavanja
            // 
            this.DatumDodavanja.DataPropertyName = "DatumDodavanja";
            this.DatumDodavanja.HeaderText = "Datum Dodavanja";
            this.DatumDodavanja.Name = "DatumDodavanja";
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "Slika";
            this.SlikaThumb.Name = "SlikaThumb";
            // 
            // VrstePizzaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 568);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.vrstePizzaGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VrstePizzaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vrste pizza";
            this.Load += new System.EventHandler(this.VrstePizzaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaPizzePictureBox)).EndInit();
            this.vrstePizzaGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vrstePizzaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox sastojciCheckedListBox;
        private System.Windows.Forms.Label sastojciLabel;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Label opisLabel;
        private System.Windows.Forms.TextBox vrstaTextBox;
        private System.Windows.Forms.Label vrstaLabel;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.GroupBox vrstePizzaGroupBox;
        private System.Windows.Forms.DataGridView vrstePizzaDataGridView;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Label slikaLabel;
        private System.Windows.Forms.TextBox slikaTextBox;
        private System.Windows.Forms.Button dodajSlikuButton;
        private System.Windows.Forms.PictureBox vrstaPizzePictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaPizzeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumDodavanja;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
    }
}