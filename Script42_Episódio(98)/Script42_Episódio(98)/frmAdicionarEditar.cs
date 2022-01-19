using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;

namespace Script42_Episódio_98_
{
    public partial class frmAdicionarEditar : Form
    {
        int id_contato;
        bool editar;

        //=================================================================================
        public frmAdicionarEditar(int id_contato = -1)
        {
            InitializeComponent();
            this.id_contato = id_contato;

            //Definir se vou adicionar ou editar um registro:

            editar = id_contato == -1 ? false : true;
        }
        //=================================================================================

        //=================================================================================
        private void frmAdicionarEditar_Load(object sender, EventArgs e)
        {
           //apresenta os dados do contato, se necessário:
           if(editar == true)
            {
                ApresentaContato();
            }
        }
        //=================================================================================

        private void ApresentaContato()
        {
            //Apresentar o contato que vai ser editado:
            SqlCeConnection ligacao = new SqlCeConnection("Data source = " + vars.base_dados);
            ligacao.Open();


            DataTable dados = new DataTable();
            SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT * FROM contatos WHERE id_contato = " + id_contato,ligacao);
            adaptador.Fill(dados);
            ligacao.Dispose();

            //Colocar os dados nos text box:
            text_nome.Text = dados.Rows[0]["nome"].ToString();
            text_numero.Text = dados.Rows[0]["telefone"].ToString();

        }


        //=================================================================================
        private void cmd_salvar_Click(object sender, EventArgs e)
        {
            //Salva um novo registro ou edita registro existente


            #region Verificações
            if (text_nome.Text == "" || text_numero.Text == "") 
            {
                MessageBox.Show("Preencha todos os campos para adicionar um novo contato", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SqlCeConnection ligação = new SqlCeConnection("Data source =" + vars.base_dados);
            ligação.Open();
            

            #endregion

            //=================================================================================
            #region NOVO CONTATO
            if (!editar)
            {

                //buscar o id_contato disponível:

                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT MAX(id_contato) AS maxid FROM contatos",ligação);
                
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                //Verifica se o valor na tabela é nulo:
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                {
                    id_contato = 0;
                }
                else
                {
                    id_contato = Convert.ToInt16(dados.Rows[0][0]) + 1;
                }

                //Gravar o novo contato na base de dados:

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligação;
                
                //Parâmetros:
                comando.Parameters.AddWithValue(@"id_contato", id_contato);
                comando.Parameters.AddWithValue(@"nome", text_nome.Text);
                comando.Parameters.AddWithValue(@"telefone", text_numero.Text);
                comando.Parameters.AddWithValue(@"atualização", DateTime.Now);

                //Verifica se já existe um contato com o mesmo nome e telefone:
                
                adaptador = new SqlCeDataAdapter();
                
                dados = new DataTable();
                
                adaptador.SelectCommand = comando;
                
                comando.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND telefone = @telefone";
                
                adaptador.Fill(dados);
                
                if(dados.Rows.Count != 0)
                {

                    //Já existe um registro com o mesmo nome e telefone

                    text_nome.ForeColor = Color.Red;
                    text_numero.ForeColor = Color.Red;

                    if(MessageBox.Show("Encontramos um outro contato com o mesmo nome e telefone que você enviou.", "Deseja Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        text_nome.Text = "";
                        text_nome.Focus();
                        text_numero.Text = "";
                        text_nome.ForeColor = Color.Black;
                        text_numero.ForeColor = Color.Black;
                        return;
                    }
                    


                }

                //Texto da Query:
                comando.CommandText = "INSERT INTO contatos VALUES (" + "@id_contato,@nome,@telefone,@atualização)";
                comando.ExecuteNonQuery();

                ligação.Dispose();

                MessageBox.Show("Contato adicionado com sucesso", "Contato Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                text_nome.Text = "";
                text_nome.Focus();
                text_numero.Text = "";
               
                
            }
            #endregion

            //=================================================================================

            //=================================================================================
            #region EDITAR CONTATO
            else
            {
                //Edita o contato na base de dados:


                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = ligação;

                //Parâmetros:
                comando.Parameters.AddWithValue(@"id_contato", id_contato);
                comando.Parameters.AddWithValue(@"nome", text_nome.Text);
                comando.Parameters.AddWithValue(@"telefone", text_numero.Text);
                comando.Parameters.AddWithValue(@"atualização", DateTime.Now);

                //Verifica se existe registro com o mesmo nome mas com o id_contato diferente:
                
                DataTable dados = new DataTable();
                

                comando.CommandText = "SELECT * FROM contatos WHERE nome = @nome AND id_contato <> @id_contato";


                SqlCeDataAdapter adaptador = new SqlCeDataAdapter();

                adaptador.SelectCommand = comando;

                adaptador.Fill(dados);

                if (dados.Rows.Count != 0)
                {

                    //foi encontrado um registro com o mesmo nome
                    text_nome.ForeColor = Color.BlueViolet;
                    text_numero.ForeColor = Color.BlueViolet;

                    if (MessageBox.Show("Encontramos um outro contato com o mesmo nome que você enviou.", "Deseja Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        text_nome.Text = "";
                        text_nome.Focus();
                        text_numero.Text = "";
                        text_nome.ForeColor = Color.Black;
                        text_numero.ForeColor = Color.Black;
                        return;
                    }
                }

                //Editar o registro selecionado:
                comando.CommandText = "UPDATE contatos SET nome = @nome, telefone = @telefone, atualização = @atualização WHERE id_contato = @id_contato";
                comando.ExecuteNonQuery();

                //Fecha o quadro:
                this.Close();

            }
            #endregion
            //=================================================================================

        }
        //=================================================================================

        //=================================================================================
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //Fecha o quadro:

            this.Close();
        }
        //=================================================================================
    }
}
