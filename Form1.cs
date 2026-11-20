namespace Projeto_Jogo___Jennifer_e_Lucca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Jogar_Click(object sender, EventArgs e)
        {
            Game joguinho = new Game();
            joguinho.IniciarJogo();
            joguinho.Show();
            this.Hide();
        }
    }
}
