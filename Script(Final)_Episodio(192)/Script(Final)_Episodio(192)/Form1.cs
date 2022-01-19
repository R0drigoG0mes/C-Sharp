using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Script_Final__Episodio_192_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //Fechar a aplicação:

            if (MessageBox.Show("Deseja sair da aplicação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            else
            {
                Application.Exit();
            }

        }

        private void cmd_carregar_Click(object sender, EventArgs e)
        {
            //Carrega a imagem:

            pic_imagem.BackgroundImage = Image.FromFile(Application.StartupPath + @"/Imagens/Mamãe.jpg");

        }
    }
}
