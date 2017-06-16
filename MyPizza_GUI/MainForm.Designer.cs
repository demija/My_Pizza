namespace MyPizza_GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vrstePizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sastojciPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veličinePizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusiPizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cijeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.upravljanjeKorisnicimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.aktivneNaruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myPizzaToolStripMenuItem,
            this.administracijaToolStripMenuItem,
            this.prodajaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1164, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myPizzaToolStripMenuItem
            // 
            this.myPizzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.myPizzaToolStripMenuItem.Name = "myPizzaToolStripMenuItem";
            this.myPizzaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.myPizzaToolStripMenuItem.Text = "MyPizza";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click_1);
            // 
            // administracijaToolStripMenuItem
            // 
            this.administracijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzeToolStripMenuItem,
            this.korisniciToolStripMenuItem1});
            this.administracijaToolStripMenuItem.Name = "administracijaToolStripMenuItem";
            this.administracijaToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administracijaToolStripMenuItem.Text = "Administracija";
            // 
            // pizzeToolStripMenuItem
            // 
            this.pizzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPizzaToolStripMenuItem,
            this.toolStripSeparator2,
            this.vrstePizzaToolStripMenuItem,
            this.sastojciPizzaToolStripMenuItem,
            this.veličinePizzaToolStripMenuItem,
            this.statusiPizzaToolStripMenuItem,
            this.cijeneToolStripMenuItem});
            this.pizzeToolStripMenuItem.Name = "pizzeToolStripMenuItem";
            this.pizzeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pizzeToolStripMenuItem.Text = "Pizze";
            // 
            // novaPizzaToolStripMenuItem
            // 
            this.novaPizzaToolStripMenuItem.Name = "novaPizzaToolStripMenuItem";
            this.novaPizzaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.novaPizzaToolStripMenuItem.Text = "Nova pizza";
            this.novaPizzaToolStripMenuItem.Click += new System.EventHandler(this.novaPizzaToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(128, 6);
            // 
            // vrstePizzaToolStripMenuItem
            // 
            this.vrstePizzaToolStripMenuItem.Name = "vrstePizzaToolStripMenuItem";
            this.vrstePizzaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.vrstePizzaToolStripMenuItem.Text = "Vrste";
            this.vrstePizzaToolStripMenuItem.Click += new System.EventHandler(this.vrstePizzaToolStripMenuItem_Click);
            // 
            // sastojciPizzaToolStripMenuItem
            // 
            this.sastojciPizzaToolStripMenuItem.Name = "sastojciPizzaToolStripMenuItem";
            this.sastojciPizzaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sastojciPizzaToolStripMenuItem.Text = "Sastojci";
            this.sastojciPizzaToolStripMenuItem.Click += new System.EventHandler(this.sastojciPizzaToolStripMenuItem_Click);
            // 
            // veličinePizzaToolStripMenuItem
            // 
            this.veličinePizzaToolStripMenuItem.Name = "veličinePizzaToolStripMenuItem";
            this.veličinePizzaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.veličinePizzaToolStripMenuItem.Text = "Veličine";
            this.veličinePizzaToolStripMenuItem.Click += new System.EventHandler(this.veličinePizzaToolStripMenuItem_Click);
            // 
            // statusiPizzaToolStripMenuItem
            // 
            this.statusiPizzaToolStripMenuItem.Name = "statusiPizzaToolStripMenuItem";
            this.statusiPizzaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.statusiPizzaToolStripMenuItem.Text = "Statusi";
            this.statusiPizzaToolStripMenuItem.Click += new System.EventHandler(this.statusiPizzaToolStripMenuItem_Click);
            // 
            // cijeneToolStripMenuItem
            // 
            this.cijeneToolStripMenuItem.Name = "cijeneToolStripMenuItem";
            this.cijeneToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.cijeneToolStripMenuItem.Text = "Cijene";
            this.cijeneToolStripMenuItem.Click += new System.EventHandler(this.cijeneToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem1
            // 
            this.korisniciToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upravljanjeKorisnicimaToolStripMenuItem});
            this.korisniciToolStripMenuItem1.Name = "korisniciToolStripMenuItem1";
            this.korisniciToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.korisniciToolStripMenuItem1.Text = "Korisnici";
            // 
            // upravljanjeKorisnicimaToolStripMenuItem
            // 
            this.upravljanjeKorisnicimaToolStripMenuItem.Name = "upravljanjeKorisnicimaToolStripMenuItem";
            this.upravljanjeKorisnicimaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.upravljanjeKorisnicimaToolStripMenuItem.Text = "Pregled korisnika";
            this.upravljanjeKorisnicimaToolStripMenuItem.Click += new System.EventHandler(this.upravljanjeKorisnicimaToolStripMenuItem_Click);
            // 
            // prodajaToolStripMenuItem
            // 
            this.prodajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aktivneNaruToolStripMenuItem});
            this.prodajaToolStripMenuItem.Name = "prodajaToolStripMenuItem";
            this.prodajaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.prodajaToolStripMenuItem.Text = "Prodaja";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // aktivneNaruToolStripMenuItem
            // 
            this.aktivneNaruToolStripMenuItem.Name = "aktivneNaruToolStripMenuItem";
            this.aktivneNaruToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aktivneNaruToolStripMenuItem.Text = "Aktivne narudžbe";
            this.aktivneNaruToolStripMenuItem.Click += new System.EventHandler(this.aktivneNaruToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 750);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Pizza";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vrstePizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sastojciPizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veličinePizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem statusiPizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cijeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem upravljanjeKorisnicimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myPizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodajaToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem aktivneNaruToolStripMenuItem;
    }
}