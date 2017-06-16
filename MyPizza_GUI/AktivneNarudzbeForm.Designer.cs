namespace MyPizza_GUI
{
    partial class AktivneNarudzbeForm
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
            this.aktivneNarudzbeDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.aktivneNarudzbeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aktivneNarudzbeDataGridView
            // 
            this.aktivneNarudzbeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aktivneNarudzbeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aktivneNarudzbeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.aktivneNarudzbeDataGridView.Name = "aktivneNarudzbeDataGridView";
            this.aktivneNarudzbeDataGridView.Size = new System.Drawing.Size(862, 472);
            this.aktivneNarudzbeDataGridView.TabIndex = 0;
            this.aktivneNarudzbeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aktivneNarudzbeDataGridView_CellDoubleClick);
            // 
            // AktivneNarudzbeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 496);
            this.Controls.Add(this.aktivneNarudzbeDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AktivneNarudzbeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktivne Narudzbe";
            this.Load += new System.EventHandler(this.AktivneNarudzbeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aktivneNarudzbeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView aktivneNarudzbeDataGridView;
    }
}