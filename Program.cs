using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MacroDeckWebView.Properties;

namespace MacroDeckWebView
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
            try
            {
                var applicationContext = new TrayIconContext();
                Application.Run(applicationContext);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.MAIN_UNKNOW_EXCEPTION,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
