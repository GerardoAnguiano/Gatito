using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gatito
{
    public partial class Form1 : Form
    {
        int turno = 1;
        int[,] Gato;
        int PuntosPlayer1 = 0;
        int PuntosPlayer2 = 0;
        bool YaHayGanador;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PicReiniciar_Click(object sender, EventArgs e)
        {

        }
        public void IniciarJuego()
        {
            //iniciar valores de juego 
            turno = 1;
            Gato = new int[3, 3];
            YaHayGanador = false;

            PicGanador.Image = Properties.Resources.f_0;
            FichasGato.Controls.Clear();

            //
            for(var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    //asignamos una variable de tipo picturebox
                    var FichaJuego = new PictureBox();
                    //asignamos la imagen de pokebola a todas las celdas 
                    FichaJuego.Image = Properties.Resources.f_0;
                    FichaJuego.Name = string.Format("{0}", i + "_" + j);
                    FichaJuego.Cursor = Cursors.Hand;
                    FichaJuego.SizeMode = PictureBoxSizeMode.StretchImage;

                    FichasGato.Controls.Add(FichaJuego, j, i);
                    Gato[i, j] = 0;
                }
            }
        }
    }
}
