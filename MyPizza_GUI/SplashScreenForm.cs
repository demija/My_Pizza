using System;
using System.Windows.Forms;

namespace MyPizza_GUI
{
    public partial class SplashScreenForm : Form
    {
        private Timer closeTimer = new Timer();

        public SplashScreenForm()
        {
            InitializeComponent();

            closeTimer.Interval = 3000;
            closeTimer.Tick += new EventHandler(closeTimer_Tick);
            closeTimer.Start();
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            closeTimer.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            splashPictureBox.ImageLocation = "../splash.jpg";
            splashPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
