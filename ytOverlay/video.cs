using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ytOverlay
{
    public partial class video : Form
    {
        string url;
        int height;
        int width;
        int pos;

        public video(string u, int h, int w, int p)
        {
            InitializeComponent();
            url = u;
            height = h;
            width = w;
            pos = p;

            this.TopMost = true;
            this.Activate();
        }

        //https://stackoverflow.com/questions/66550671/ensurecorewebview2async-not-ready-even-after-corewebview2initializationcompleted
        private async Task InitializeAsync()
        {
            Debug.WriteLine("InitializeAsync");
            await wVPlayer.EnsureCoreWebView2Async(null);
            Debug.WriteLine("WebView2 Runtime version: " + wVPlayer.CoreWebView2.Environment.BrowserVersionString);
        }

        //https://stackoverflow.com/questions/73795000/how-do-i-display-a-youtube-video-in-webviewer
        private async void video_Load(object sender, EventArgs e)
        {
            this.Width = width;
            this.Height = height;

            wVPlayer.Width = width;
            wVPlayer.Height = height;

            this.StartPosition = FormStartPosition.Manual;

            if (pos == 0)
            {
                this.Location = new Point(0, 0);
            }
            if (pos == 1)
            {
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            }
            if (pos == 2)
            {

                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                   Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            }
            if (pos == 3)
            {
                this.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            }

            this.Show();

            try
            {
                // Play YouTube video in webBrowser1
                string uniRL = url;
                string html = "<html style='width: 100%; height: 100%; margin: 0; padding: 0;'><head>";
                html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
                html += "</head><body style='width: 100%; height: 100%; margin: 0; padding: 0;'>";
                html += "<iframe id='video' src='http://www.youtube.com/embed/{0}' style=\"padding: 0px; width: 100%; height: 100%; border: none; display: block;\" allowfullscreen></iframe>";
                html += "</body></html>";

                await InitializeAsync();
                wVPlayer.NavigateToString(string.Format(html, uniRL.Split('=')[1]));
            }
            catch
            {
                MessageBox.Show("Invalid Youtube link.");
                this.Close();
            }
        }

        private void wVPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (Application.OpenForms.OfType<video>().ToList().Count == 1)
            {
                this.Close();
            }
        }
    }
}
