using System;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data;

namespace Script42_Episódio_98_
{
    //=================================================================================
    public partial class frmResultados : Form
    {
        int id_contato;
        string item_pesquisa;
        //=================================================================================
        public frmResultados(string item_pesquisa = "")
        {
            InitializeComponent();
            this.item_pesquisa = item_pesquisa;
            
        }
        //=================================================================================

        //=================================================================================

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        //=================================================================================
        
        //=================================================================================
        private void ConstruirGrelha()
        {
            //Constroi a grelha de registros:

            //Ligar à BD:
            SqlCeConnection ligaçao = new SqlCeConnection("Data source =" + vars.base_dados);
            ligaçao.Open();

            string query = "SELECT* FROM contatos";

            if (item_pesquisa != "")
            {
                query = "SELECT * FROM contatos WHERE nome like @item OR telefone LIKE @item";
            }

            SqlCeCommand comando = new SqlCeCommand();
            comando.Connection = ligaçao;
            comando.Parameters.AddWithValue(@"item", "%" + item_pesquisa + "%");

            comando.CommandText = query;

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter();
            adaptador.SelectCommand = comando;
            

            DataTable dados = new DataTable();
            
            adaptador.Fill(dados);

            grelha_resultados.DataSource = dados;

            //Apresenta o número de registros na Base de Dados:
            label_resultados.Text = "Total de registros: " + grelha_resultados.Rows.Count.ToString();

            //Esconder Colunas:
            // id_contato || atualização
            grelha_resultados.Columns[0].Visible = false;
            grelha_resultados.Columns[3].Visible = false;

            //Alterar as dimensãoes das colunas:
            
            grelha_resultados.Columns["nome"].Width = CalcularLargura(60);
            grelha_resultados.Columns["telefone"].Width = CalcularLargura(40);

            //controla a disponibilidade dos comandos:

            cmd_apagar.Enabled = false;
            cmd_editar.Enabled = false;



        }
        //=================================================================================

        //=================================================================================
        private void frmResultados_Load(object sender, EventArgs e)
        {
            ConstruirGrelha();
        }
        //=================================================================================

        //=================================================================================
        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //eliminar a linha selecionada:

            SqlCeConnection ligação = new SqlCeConnection("Data source = " + vars.base_dados);
            ligação.Open();

            SqlCeCommand comando = new SqlCeCommand("DELETE FROM contatos WHERE id_contato = " + id_contato,ligação);
            comando.ExecuteNonQuery();


            comando.Dispose();
            ligação.Dispose();

            //reconstruir a grelha de contatos:
            ConstruirGrelha();



        }
        //=================================================================================

        //=================================================================================
        private void grelha_resultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_contato = Convert.ToInt16(grelha_resultados.Rows[e.RowIndex].Cells["id_contato"].Value);
            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;
        }
        //=================================================================================

        //=================================================================================
        private void label_resultados_Click(object sender, EventArgs e)
        {

        }
        //=================================================================================

        //=================================================================================
        private void cmd_editar_Click(object sender, EventArgs e)
        {
            //Edita o registro selecionado:
            frmAdicionarEditar f = new frmAdicionarEditar(id_contato);
            f.ShowDialog();

            //atualiza a grelha de resultados:
            ConstruirGrelha();


        }
        //=================================================================================

        //=================================================================================
        private void cmd_ver_tudo_Click(object sender, EventArgs e)
        {
            //Volta a apresentar todos os itens de contatos:
            item_pesquisa = "";
            ConstruirGrelha();


        }
        //=================================================================================

        private int CalcularLargura(int percentagem)
        {
            int largura_grelha = grelha_resultados.Width - 20;
            int resultado = (largura_grelha * percentagem) / 100;
            return resultado;
        }
    }
    //=================================================================================
}
