namespace MyPizza_GUI
{
    partial class SplashScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            this.splashPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splashPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splashPictureBox
            // 
            this.splashPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splashPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("splashPictureBox.ErrorImage")));
            this.splashPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("splashPictureBox.InitialImage")));
            this.splashPictureBox.Location = new System.Drawing.Point(0, 0);
            this.splashPictureBox.Name = "splashPictureBox";
            this.splashPictureBox.Size = new System.Drawing.Size(505, 505);
            this.splashPictureBox.TabIndex = 0;
            this.splashPictureBox.TabStop = false;
            // 
            // SplashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 505);
            this.ControlBox = false;
            this.Controls.Add(this.splashPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreenForm";
            this.Load += new System.EventHandler(this.SplashScreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splashPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox splashPictureBox;
    }
}