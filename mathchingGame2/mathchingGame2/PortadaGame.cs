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
    public partial class PortadaGame : Form
    {
        public PortadaGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoJuego videoJuego = new VideoJuego();
            videoJuego.Show();
        }
    }
}
