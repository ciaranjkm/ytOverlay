using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;

namespace ytOverlay
{
    public partial class youtubeOverlay : Form
    {
        bool isVideoOpen;
        video v;

        public youtubeOverlay()
        {
            InitializeComponent();
            isVideoOpen = false;

            sizeComboBox.SelectedIndex = 0;
            posComboBox.SelectedIndex = 0;
        }

        private void openVideoButton_Click(object sender, EventArgs e)
        {
            string url = linkToVideoTextBox.Text;
            if (Application.OpenForms.OfType<video>().ToList().Count == 0)
            {
                int width = 512; //defaults size works best 
                int height = 288;

                try
                {
                    var d = sizeComboBox.SelectedItem.ToString().Split('x');
                    width = int.Parse(d[0]);
                    height = int.Parse(d[1]);
                }
                catch
                { }

                int pos = posComboBox.SelectedIndex;
                v = new video(url, height, width, pos);
                v.Show();
            }
            else
            {
                v.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sizeComboBox.SelectedIndex = 0;
            posComboBox.SelectedIndex = 0;
        }
    }
}
