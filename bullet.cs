
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projeto_Jogo___Jennifer_e_Lucca
{
    public class Bullet : PictureBox
    {
        private int velocidade = 10;

        public Bullet(int x, int y)
        {

            Location = new Point(x, y);

            Size = new Size(40, 40);

            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Transparent;

            string caminhoImagem = Path.Combine(
                Application.StartupPath,
                "assets",
                "bullet.png"
            );

            Image = Image.FromFile(caminhoImagem);
        }

        public void Mover()
        {
            Left += velocidade;
        }

        public bool SaiuDaTela(int larguraTela)
        {
            return Left > larguraTela;
        }
    }
}
