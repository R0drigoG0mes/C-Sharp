using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script40_Episodio_69_
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            // Carrega os contatos:
            cl_geral.ConstruirListaContatos();

            // Apresenta a versão do Programa
            label_versão.Text = cl_geral.versão;

        }

        private void cmd_inserir_editar_Click(object sender, EventArgs e)
        {
            // Abre o formulário Inserir e Editar
            frmInserirEditar formulario = new frmInserirEditar();

            formulario.ShowDialog();
             
        
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //Sair da Aplicação

            //Pergunta se pretende mesmo sair

            if (MessageBox.Show("Deseja sair e fechar a agenda?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            //Sair da aplicação definitivamente
            Application.Exit();
            
        
        
        }

        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            //Abrir o quadro de pesquisa:

            frmTexto f = new frmTexto();
            f.ShowDialog();

            //Quando fecha o quadro, verifica se foi cancelado:
            if (f.Cancelado) return;

            // Abrir o quadro com resultados da pesquisa:
            frmResultados ff = new frmResultados(f.pesquisa);
            ff.ShowDialog();



        
        
        }
    }
}
