using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script26_Episódio_44_
{
    public partial class FrmPrimeiro : Form
    {
        public FrmPrimeiro()
        {
            InitializeComponent();
        }

        private void FrmPrimeiro_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            geral.nome = text_nome.Text;
            FormJanela formulario = new FormJanela();
            formulario.ShowDialog();
        }

        private void cmd_um_Click(object sender, EventArgs e)
        {
            FormPorta formulario = new FormPorta();
            formulario.ShowDialog();
        }

        private void cmd_finalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void text_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
