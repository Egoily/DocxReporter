using System;
using System.Windows.Forms;

namespace DocxSearcher
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalSettings.Management.Load();
            Application.Run(new MainForm());
        }
    }
}
