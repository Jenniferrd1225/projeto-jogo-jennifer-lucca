namespace Projeto_Jogo___Jennifer_e_Lucca
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            timerJogo = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timerJogo
            // 
            timerJogo.Enabled = true;
            timerJogo.Tick += timerJogo_Tick;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Margin = new Padding(2);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Load += Game_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerJogo;
    }
}