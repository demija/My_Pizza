namespace MyPizza_GUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.korisnickoImeLabel = new System.Windows.Forms.Label();
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.lozinkaLabel = new System.Windows.Forms.Label();
            this.lozinkaTextBox = new System.Windows.Forms.TextBox();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.prijavaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // korisnickoImeLabel
            // 
            this.korisnickoImeLabel.AutoSize = true;
            this.korisnickoImeLabel.Location = new System.Drawing.Point(32, 27);
            this.korisnickoImeLabel.Name = "korisnickoImeLabel";
            this.korisnickoImeLabel.Size = new System.Drawing.Size(78, 13);
            this.korisnickoImeLabel.TabIndex = 0;
            this.korisnickoImeLabel.Text = "Korisničko ime:";
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(116, 24);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(170, 20);
            this.korisnickoImeTextBox.TabIndex = 1;
            // 
            // lozinkaLabel
            // 
            this.lozinkaLabel.AutoSize = true;
            this.lozinkaLabel.Location = new System.Drawing.Point(32, 53);
            this.lozinkaLabel.Name = "lozinkaLabel";
            this.lozinkaLabel.Size = new System.Drawing.Size(47, 13);
            this.lozinkaLabel.TabIndex = 0;
            this.lozinkaLabel.Text = "Lozinka:";
            // 
            // lozinkaTextBox
            // 
            this.lozinkaTextBox.Location = new System.Drawing.Point(116, 50);
            this.lozinkaTextBox.Name = "lozinkaTextBox";
            this.lozinkaTextBox.Size = new System.Drawing.Size(170, 20);
            this.lozinkaTextBox.TabIndex = 2;
            this.lozinkaTextBox.UseSystemPasswordChar = true;
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(211, 76);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 23);
            this.odustaniButton.TabIndex = 4;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // prijavaButton
            // 
            this.prijavaButton.Location = new System.Drawing.Point(116, 76);
            this.prijavaButton.Name = "prijavaButton";
            this.prijavaButton.Size = new System.Drawing.Size(75, 23);
            this.prijavaButton.TabIndex = 3;
            this.prijavaButton.Text = "Prijava";
            this.prijavaButton.UseVisualStyleBackColor = true;
            this.prijavaButton.Click += new System.EventHandler(this.prijavaButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 121);
            this.Controls.Add(this.prijavaButton);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.lozinkaTextBox);
            this.Controls.Add(this.lozinkaLabel);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.Controls.Add(this.korisnickoImeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Pizza - Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label korisnickoImeLabel;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.Label lozinkaLabel;
        private System.Windows.Forms.TextBox lozinkaTextBox;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button prijavaButton;
    }
}