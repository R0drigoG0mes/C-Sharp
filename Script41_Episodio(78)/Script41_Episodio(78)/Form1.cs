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

namespace Script41_Episodio_78_
{
    public partial class Form1 : Form
    {

        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caminho = nome_base.Text;

            //Buscar todos os dados da tabela:
            try
            {
                SqlCeConnection _liga = new SqlCeConnection
             (@"Data Source=C:\Users\User\Documents\Rodrigo\SQL Ce\" + caminho + ".sdf");
                _liga.Open();

                //Buscar os dados:

                SqlCeDataAdapter _operario = new SqlCeDataAdapter("Select * From Pessoas", _liga);

                DataTable dados = new DataTable();
                _operario.Fill(dados);

                //Apresentar dados:
                lista_dados.Items.Clear();
                foreach (DataRow linha in dados.Rows)
                {
                    lista_dados.Items.Add(linha["Nome"].ToString() + " ¨ " +
                                            linha["Moradia"].ToString() + " ¨ " +
                                                linha["Telefone"].ToString());


                }



                _liga.Close();
            }

            catch
            {
                lista_dados.Items.Clear();
                MessageBox.Show("Base de Dados não encontrada", "Caminho do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nome_base.Text = "";
                nome_base.Focus();
            
            
            
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                //Inseirir Um Novo Registro No Banco de Dados:

                string caminho = nome_base.Text;

                //Nome, Moradia, Telefone;

                SqlCeConnection _liga = new SqlCeConnection(@"Data Source=C:\Users\User\Documents\Rodrigo\SQL Ce\" + caminho + ".sdf");
                _liga.Open();

                string query = "Insert Into Pessoas Values ('Rui Daniel','Rua Das Mitocôondrias','996765675')";

                SqlCeCommand _operario = new SqlCeCommand(query, _liga);

                _operario.ExecuteNonQuery();


                //Fechar a ligação
                _liga.Close();
            }


            catch
            {
                MessageBox.Show("Ocorreu um Erro", "Erro Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            
            
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Atualizar Dados na Base de dados

                //Ligação:

                SqlCeConnection ligacao = new SqlCeConnection(@"Data Source = C:\Users\User\Documents\Rodrigo\SQL Ce\dados.sdf");
                ligacao.Open();

                //Atualização de um registro na base de dados:
                string query = "Update Pessoas Set Moradia = 'Rua dos Maníacos', Telefone = '111111111' Where Nome = 'WOOO BUFEET'";
                SqlCeCommand operario = new SqlCeCommand(query, ligacao);
                operario.ExecuteNonQuery();

                //Fecha a ligação
                ligacao.Close();


                

            }

            catch
            {
                MessageBox.Show
                    ("Aconteceu um erro, tente novamente.", 
                        "ERROR 404", 
                            MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            
            
            }
        
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Eliminação de dados:
            try
            {
                SqlCeConnection ligação = new SqlCeConnection(@"Data Source = C:\Users\User\Documents\Rodrigo\SQL Ce\dados.sdf");
                ligação.Open();

                string query = "Delete From Pessoas Where Nome = 'Rui Daniel' And Moradia = 'Rua Das Mitocôondrias'";
                
                //Eliminação de dados:
                SqlCeCommand operario = new SqlCeCommand(query, ligação);
                operario.ExecuteNonQuery();


                //Fechar a ligação
                ligação.Close();

            }
            catch
            {
                MessageBox.Show("ERROR 805", "Erro Inesperado", MessageBoxButtons.OK,MessageBoxIcon.Error);

            
            
            }
        
        
        }
    }
}
