using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Script42_Episódio_98_
{
    public partial class frmMenu : Form
    {
     

        //==================================================================
        public frmMenu()
        {
            InitializeComponent();

            //Apresenta a versão:
            label_versao.Text = vars.versao;
        }

        //==================================================================

        //==================================================================
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //==================================================================

        //==================================================================
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        //==================================================================
        private void cmd_sair_Click(object sender, EventArgs e)
        {
            //Sair da Aplicação
            if(MessageBox.Show("Deseja realmente sair da agenda?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;

            }

            Application.Exit();

        }
        
        //==================================================================
        private void cmd_adicionar_Click(object sender, EventArgs e)
        {
            //Abre o quadro para adicionar novos registros
            frmAdicionarEditar f = new frmAdicionarEditar();
            f.ShowDialog();
        
        
        }

        //==================================================================
        private void cmd_ver_tudo_Click(object sender, EventArgs e)
        {
            //Abrir um quadro para a apresentação de todos os resultados:
            frmResultados f = new frmResultados();
            f.ShowDialog();


        }

        //==================================================================
        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisa f = new frmPesquisa();
            f.ShowDialog();

            //Executa apesquisa, se o quadro não foi cancelado:

            if (f.cancelado)
            {
                f.Dispose();
                return;
            }

            //Executar a pesquisa
            string query = "";
            frmResultados ff = new frmResultados(f.texto_pesquisa);
            ff.ShowDialog();

            






        }
        //==================================================================

        //==================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            //Apaga todos os registros da base de dados:
            
            
            if(MessageBox.Show("Apagar TODOS os contatos?","Limpar dados dos contatos",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.No)
            {
                return;
            }

            //Elimina todos os registros da base de dados:
            SqlCeConnection ligação = new SqlCeConnection("Data source = " + vars.base_dados);
            ligação.Open();

            SqlCeCommand comando = new SqlCeCommand("DELETE FROM contatos",ligação);
 
            comando.ExecuteNonQuery();
            
            ligação.Dispose();

            //Mensagem informando que todos os contatos foram excluídos:
            MessageBox.Show("Todos os contatos foram excluídos com sucesso", "Tarefa concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);



          

        }

        private void label_versao_Click(object sender, EventArgs e)
        {

        }
        //==================================================================
    }
}
