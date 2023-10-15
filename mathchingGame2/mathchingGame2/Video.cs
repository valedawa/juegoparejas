using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathchingGame2
{
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void Video_Load(object sender, EventArgs e)
        {
            string VideoUrl = "https://drive.google.com/file/d/1ISkUlzyTL7uhHkrs391U-l5bq3ppKg_8/view?usp=sharing";
            webBrowser1.Navigate(VideoUrl);
        }
    }
}
