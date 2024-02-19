using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MacroDeckWebView.Properties;
using DarkUI.Forms;
using System.Configuration;

namespace MacroDeckWebView
{
    public partial class MacroDeckWebViewForm : DarkForm
    {
        public MacroDeckWebViewForm()
        {
            InitializeComponent();
            this.Icon = Icon.FromHandle(Resources.ICON.GetHicon());
            this.Text = Resources.FORM_TITLE + " v" + Resources.VERSION;
        }

        private void btnRepository_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Resources.REPOSITORY_URL);
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
      
        }

        private async void WebView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            //string v1 = await webView21.CoreWebView2.ExecuteScriptAsync("document.getElementById('btn-fullscreen').style.visibility='hidden'; document.getElementById('btn-back').style.visibility='hidden'; document.getElementById('btn-dark').style.visibility='hidden';");
        }


        private void ExamepleForm_Deactivate(object sender, EventArgs e)
        {
            //Hide application on Defocus
            //Add logic here to prevent reshowing when clicking the taskbar icon?
            TrayLockVar = true;
            this.Hide();
            ResetTrayLock();
            
        }

        private static bool _trayLockVar = false;

        public static bool TrayLockVar
        {
            get { return _trayLockVar; }
            set { _trayLockVar = value; }
        }

        public async void ResetTrayLock()
        {
            await Task.Delay(500);
            TrayLockVar = false;
        }

        private void MacroDeckWebViewForm_Load(object sender, EventArgs e)
        {
            Int32 widthVar = Int32.Parse(ConfigurationManager.AppSettings["viewWidth"]);
            Int32 heightVar = Int32.Parse(ConfigurationManager.AppSettings["viewHeight"]) + 23;
            this.Size = new Size(widthVar,heightVar);

            this.Left = Screen.FromPoint(Cursor.Position).WorkingArea.Right - widthVar;
            this.Top = Screen.FromPoint(Cursor.Position).WorkingArea.Bottom - heightVar;
        }

        private void MacroDeckWebViewForm_ResizeEnd(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {

            }
            else
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                Int32 widthVar = this.Size.Width;
                Int32 heightVar = this.Size.Height - 23;
                // ConfigurationManager.AppSettings["viewWidth"] = widthVar.ToString();
                // ConfigurationManager.AppSettings["viewHeight"] = heightVar.ToString();
                config.AppSettings.Settings["viewWidth"].Value =widthVar.ToString();
                config.AppSettings.Settings["viewHeight"].Value = heightVar.ToString();
                config.Save(ConfigurationSaveMode.Modified);
            }
        }

        private void MacroDeckWebViewForm_DpiChanged(object sender, DpiChangedEventArgs e)
        {
            
        }
    }
}
