
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Jogo___Jennifer_e_Lucca
{
    public partial class Game : Form
    {
        private Player? jogador;
        private Player? personagem2;

        public Game()
        {
            InitializeComponent();

            KeyPreview = true;

            timerJogo.Interval = 100;
            timerJogo.Enabled = false;

            KeyDown += Game_KeyDown;
        }

        public void IniciarJogo()
        {
            jogador = new Player("player.png");
            jogador.Location = new Point(200, 480);
            Controls.Add(jogador);

            personagem2 = new Player("player2.png");
            personagem2.Location = new Point(700, 400);
            Controls.Add(personagem2);

            jogador.BringToFront();
            personagem2.BringToFront();

            timerJogo.Enabled = true;
        }

        private void Game_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (jogador == null)
                    return;

                Bullet bala = jogador.Atirar();

                Controls.Add(bala);

                bala.BringToFront();

                e.SuppressKeyPress = true;
            }
        }


        private void timerJogo_Tick(object? sender, EventArgs e)
        {
            if (jogador == null)
                return;

            for (int i = jogador.balas.Count - 1; i >= 0; i--)
            {
                Bullet bala = jogador.balas[i];

                bala.Mover();

                if (bala.SaiuDaTela(ClientSize.Width))
                {
                    Controls.Remove(bala);

                    jogador.balas.RemoveAt(i);

                    bala.Dispose();
                }
            }
        }


        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
