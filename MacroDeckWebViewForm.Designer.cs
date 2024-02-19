using System.Configuration;

namespace MacroDeckWebView
{
    partial class MacroDeckWebViewForm
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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Source = new System.Uri(ConfigurationManager.AppSettings["WebClientURL"]);
            this.webView21.Size = new System.Drawing.Size(703, 441);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 0.5D;
            this.webView21.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.WebView21_NavigationCompleted);
            // 
            // MacroDeckWebViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 440);
            this.ControlBox = false;
            this.Controls.Add(this.webView21);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MacroDeckWebViewForm";
            this.Deactivate += new System.EventHandler(this.ExamepleForm_Deactivate);
            this.Load += new System.EventHandler(this.MacroDeckWebViewForm_Load);
            this.DpiChanged += new System.Windows.Forms.DpiChangedEventHandler(this.MacroDeckWebViewForm_DpiChanged);
            this.ResizeEnd += new System.EventHandler(this.MacroDeckWebViewForm_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

