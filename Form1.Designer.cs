namespace Projeto_Jogo___Jennifer_e_Lucca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_Jogar = new Button();
            lbl_Titulo = new Label();
            SuspendLayout();
            // 
            // btn_Jogar
            // 
            btn_Jogar.BackColor = Color.FromArgb(128, 128, 255);
            btn_Jogar.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Jogar.ForeColor = Color.FromArgb(64, 0, 64);
            btn_Jogar.Location = new Point(602, 635);
            btn_Jogar.Margin = new Padding(2);
            btn_Jogar.Name = "btn_Jogar";
            btn_Jogar.Size = new Size(175, 59);
            btn_Jogar.TabIndex = 0;
            btn_Jogar.Text = "JOGAR";
            btn_Jogar.UseVisualStyleBackColor = false;
            btn_Jogar.Click += btn_Jogar_Click;
            // 
            // lbl_Titulo
            // 
            lbl_Titulo.AutoSize = true;
            lbl_Titulo.BackColor = Color.Transparent;
            lbl_Titulo.Font = new Font("Monotype Corsiva", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Titulo.ForeColor = Color.Teal;
            lbl_Titulo.Location = new Point(498, 131);
            lbl_Titulo.Margin = new Padding(2, 0, 2, 0);
            lbl_Titulo.Name = "lbl_Titulo";
            lbl_Titulo.Size = new Size(373, 79);
            lbl_Titulo.TabIndex = 1;
            lbl_Titulo.Text = "WINX CLUB";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1370, 749);
            Controls.Add(lbl_Titulo);
            Controls.Add(btn_Jogar);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JOGO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Jogar;
        private Label lbl_Titulo;
    }
}
