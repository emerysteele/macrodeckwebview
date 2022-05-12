using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MacroDeckWebView.Properties;

namespace MacroDeckWebView
{
    class TrayIconContext : ApplicationContext
    {
        private System.ComponentModel.IContainer components;	// a list of components to dispose when the context is disposed
        private NotifyIcon _notifyIcon;				            // the icon that sits in the system tray
        private MacroDeckWebViewForm _exampleForm;

        public TrayIconContext()
        {
            InitializeContext();

        }
        private void InitializeContext()
        {
            components = new System.ComponentModel.Container();

            _notifyIcon = new NotifyIcon(components)
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Icon = Icon.FromHandle(Resources.ICON.GetHicon()),
                Text = Resources.NOTIFY_TOOLTIP,
                Visible = true
            };
            // Menus
            _notifyIcon.ContextMenuStrip.Items.Add(ToolStripMenuItemWithHandler(Resources.NOTIFY_MENU_1, showLogsItem_Click));
            _notifyIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            _notifyIcon.ContextMenuStrip.Items.Add(ToolStripMenuItemWithHandler(Resources.NOTIFY_EXIT_MENU, exitSystem_Click));
            _notifyIcon.ContextMenuStrip.Opening += ContextMenuStrip_Opening;
            _notifyIcon.DoubleClick += notifyIcon_DoubleClick;
            _notifyIcon.MouseUp += notifyIcon_MouseUp;
            _notifyIcon.ShowBalloonTip(5000, Resources.BALLOON_TITLE , Resources.BALLOON_TEXT, ToolTipIcon.Info);
        }

        /// <summary>
        /// When the application context is disposed, dispose things like the notify icon.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
                if (_exampleForm != null)
                    _exampleForm.Dispose();
                if (_notifyIcon != null)
                    _notifyIcon.Dispose();
            }
        }

        private void ContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = false;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
           
        }


        private void notifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_exampleForm == null)
                {
                    ShowLogsForm();
                }
                else
                {
                    
                    if (_exampleForm.Visible == false)
                    {
                        _exampleForm.Show();
                        _exampleForm.Activate();
                        _exampleForm.ShowInTaskbar = false;
                    }
                    else if (_exampleForm.Visible == true)
                    {
                        _exampleForm.Hide();
                    }
                }
                
            }
            else
            {
                MethodInfo mi = typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic);
                mi.Invoke(_notifyIcon, null);
            }
        }

        private ToolStripMenuItem ToolStripMenuItemWithHandler(string displayText, EventHandler eventHandler)
        {
            var item = new ToolStripMenuItem(displayText);
            if (eventHandler != null) { item.Click += eventHandler; }
            return item;
        }

        private void showLogsItem_Click(object sender, EventArgs e) { ShowLogsForm(); }

        private void ShowLogsForm()
        {
            if (_exampleForm == null)
            {
                _exampleForm = new MacroDeckWebViewForm();
                _exampleForm.Closed += logsForm_Closed; // avoid reshowing a disposed form
                _exampleForm.StartPosition = FormStartPosition.Manual;
                _exampleForm.Left = Cursor.Position.X - _exampleForm.Width;
                _exampleForm.Top = Screen.PrimaryScreen.WorkingArea.Bottom - _exampleForm.Height;
                _exampleForm.Show();
                _exampleForm.Activate();
            }
            else
            {
                _exampleForm.Show();
                _exampleForm.Activate();
            }
        }

        // null out the forms so we know to create a new one.
        private void logsForm_Closed(object sender, EventArgs e)
        {
            _exampleForm = null;
        }

        private void exitSystem_Click(object sender, EventArgs e)
        {
            this.ExitThread();
        }

    }
}
