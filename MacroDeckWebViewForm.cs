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

        private async void WebView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            string WSURL = ConfigurationManager.AppSettings["WSURL"];
            //Run Javascript + CSS to remove web.macrodeck.org buttons at the top of the page + auto connect to WSURL (Settable in app.config)
            string v1 = await webView21.CoreWebView2.ExecuteScriptAsync("document.getElementById('btn-fullscreen').style.visibility='hidden'; document.getElementById('btn-back').style.visibility='hidden'; connect('"+WSURL+ "'); var style = document.createElement('style'); style.innerHTML = ` body{ image-rendering: -webkit-optimize-contrast; } `; document.head.appendChild(style);");
        }

        private void MacroDeckWebViewForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                try
                {
                    var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var settings = configFile.AppSettings.Settings;
                    if (settings["windowwidth"] == null)
                    {
                        settings.Add("windowwidth", this.Width.ToString());
                    }
                    else
                    {
                        settings["windowwidth"].Value = this.Width.ToString();
                    }
                    if (settings["windowheight"] == null)
                    {
                        settings.Add("windowheight", this.Height.ToString());
                    }
                    else
                    {
                        settings["windowheight"].Value = this.Height.ToString();
                    }
                    configFile.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                }
                catch (ConfigurationErrorsException)
                {
                    Console.WriteLine("Error writing app settings");
                }
            }
        }

        private void MacroDeckWebViewForm_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MacroDeckWebViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
