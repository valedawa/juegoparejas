﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathchingGame2
{
    public partial class VideoJuego : Form
    {
        int NumeroMarmotaActual = 1;
        int TiempoNivel = 20;
        int Puntuacion = 0;
        int Fallas = 0;
        int LimiteFallas = 5;
        Random rnd = new Random();

        public VideoJuego()
        {
            InitializeComponent();
            IniciarJuego();
        }
        public void IniciarJuego()
        {

            NumeroMarmotaActual = 1;
            TiempoNivel = 20;
            Puntuacion = 0;
            Fallas = 0;
            LimiteFallas = 5;
            lblPuntos.Text = "0";
            lblFallas.Text = "0";
            panelJuego.Controls.Clear();
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var FichaJuego = new PictureBox();
                    FichaJuego.Image = Properties.Resources.AgujeroVacio;
                    FichaJuego.Name = string.Format("{0}", i + "_" + j);
                    FichaJuego.Dock = DockStyle.Fill;
                    FichaJuego.Cursor = Cursors.Hand;
                    FichaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    FichaJuego.Click += Jugar;
                    FichaJuego.Tag = "No";
                    panelJuego.Controls.Add(FichaJuego, j, i);
                }
            }
            timer1.Start();
            timer2.Start();
        }
        private void Jugar(object sender, EventArgs e)
        {
            var FichaSeleccionadaUsuario = (PictureBox)sender;
            if (FichaSeleccionadaUsuario.Tag.ToString() != "No")
            {

                if (FichaSeleccionadaUsuario.Tag.ToString() == "marmota_" + NumeroMarmotaActual)
                {
                    Sonido("bien");
                    Puntuacion++;
                    lblPuntos.Text = Puntuacion.ToString();
                    timer1.Interval = timer1.Interval - TiempoNivel;
                }
                else
                {

                    Fallas++;
                    lblFallas.Text = Fallas.ToString();
                    Sonido("falla");

                }
            }
            else
            {
                Sonido("error");

            }

        }
        public void Sonido(String NombreSonido)             
        {
         var sonido = (Stream)Properties.Resources.ResourceManager.GetObject(NombreSonido);
        SoundPlayer SonidoCargado = new SoundPlayer(sonido);
         SonidoCargado.Play();
        }

        private void VideoJuego_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    PictureBox pbOcultar = this.Controls.Find(i + "_" + j, true).FirstOrDefault() as PictureBox;
                    pbOcultar.Image = Properties.Resources.AgujeroVacio;
                    pbOcultar.Tag = "No";
                }
            }

            int rndColor = rnd.Next(1, 5);
            int rndi = rnd.Next(0, 3);
            int rndj = rnd.Next(0, 3);

            PictureBox pbx = this.Controls.Find(rndi + "_" + rndj, true).FirstOrDefault() as PictureBox;
            pbx.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("marmota_" + rndColor);

            pbx.Tag = "marmota_" + rndColor;

            if (Fallas == LimiteFallas)
            {
                timer1.Stop();
                MessageBox.Show("Juego terminado puntos = " + lblPuntos.Text);
                timer2.Stop();
                IniciarJuego();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int NumeroMarmota = rnd.Next(1, 5);
            NumeroMarmotaActual = NumeroMarmota;
            pbxatrapame.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("a" + NumeroMarmotaActual);
        }
    }
}
