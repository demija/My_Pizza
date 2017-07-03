using System;
using System.Windows.Forms;

namespace MyPizza_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashScreenForm splash = new SplashScreenForm();
            splash.ShowDialog();

            if(splash.DialogResult == DialogResult.OK)
            {
                LoginForm login = new LoginForm();
                login.ShowDialog();

                if (login.DialogResult == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
            }
        }
    }
}
