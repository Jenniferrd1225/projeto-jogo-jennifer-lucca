using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Projeto_Jogo___Jennifer_e_Lucca
{
    public class Player : PictureBox
    {
        public List<Bullet> balas = new List<Bullet>();

        public Player(string nomeImagem)
        {
            Size = new Size(210, 200);
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Transparent;

            string caminhoImagem = Path.Combine(
                Application.StartupPath,
                "assets",
                nomeImagem
            );

            Image = Image.FromFile(caminhoImagem);
        }

        public Bullet Atirar()
        {

            Bullet bala = new Bullet(
                Left + Width - 20,
                Top + (Height / 2) - 20
            );

            balas.Add(bala);

            return bala;
        }
    }
}
