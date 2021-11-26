using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        Random randcomida = new Random();

        Graphics papel;
        Snake Snakes = new Snake();
        Comida comida;
        bool izquierda = false;
        bool derecha = false;
        bool arriba = false;
        bool abajo = false;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            comida = new Comida(randcomida);
        }

        private void Form1_Load(object sender, EventArgs e)

        {
           
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            papel = e.Graphics;
            comida.dibujodecomida(papel);
            Snakes.dibujasnake(papel);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                player.SoundLocation =
                player.Play();

                timer1.Enaabled = true;
            }
        }

        private void Pausa_Click(object sender, EventArgs e)
        {

        }
    }
}
