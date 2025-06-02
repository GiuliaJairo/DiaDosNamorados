using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiaDosNamorados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int distancia = 100; // distância mínima pra ele fugir

            int dx = e.X - btnNao.Location.X;
            int dy = e.Y - btnNao.Location.Y;

            if (Math.Abs(dx) < distancia && Math.Abs(dy) < distancia)
            {
                Random aleatorio = new Random();
                int novaX = aleatorio.Next(this.ClientSize.Width - btnNao.Width);
                int novaY = aleatorio.Next(this.ClientSize.Height - btnNao.Height);

                btnNao.Location = new Point(novaX, novaY);

            }
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
    "Eu sabia que era sim, te amo pra sempre.💜 \nFeliz Dia dos Namorados!","hihihihi", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void llbMusica_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=cxkSy7drF_U");
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Como assim?? \ntudo bem então... sai do meu app!",
                "Ei!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
