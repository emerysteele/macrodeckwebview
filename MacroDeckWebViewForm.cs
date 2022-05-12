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
            this.Text = Resources.FORM_TITLE;
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
            string WSURL = ConfigurationManager.AppSettings["WSURL"];
            string v1 = await webView21.CoreWebView2.ExecuteScriptAsync("document.getElementById('btn-fullscreen').style.visibility='hidden'; document.getElementById('btn-back').style.visibility='hidden'; connect('"+WSURL+"')");
        }

        private void ExamepleForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                
            }
        }

        private void ExamepleForm_Deactivate(object sender, EventArgs e)
        {
            
            this.Hide();
        }


    }
}
