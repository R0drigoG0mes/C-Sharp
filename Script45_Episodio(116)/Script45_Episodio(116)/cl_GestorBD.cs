using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace Script45_Episodio_116_
{
    class cl_GestorBD
    {


        SqlCeConnection ligação;
        SqlCeCommand comando;
        SqlCeDataAdapter adaptador;

        SqlCeDataAdapter adaptador_temp;

        string strconne = "";
        string pasta_bd = @"C:\Users\User\Documents\Rodrigo\SQL Ce";
        string bd_password = "lork132132";

        // Cria a classe de parâmetros de SQL:
        public class SQLParametro
        {
            public string parametro { get; set; }
            public object valor { get; set; }

            public SQLParametro(string parametro, object valor)
            {
                this.parametro = parametro;
                this.valor = valor;
            }
        }
        



        //==============================================================================================

        public cl_GestorBD()
        {

        }

        //==============================================================================================

        //==============================================================================================
        public cl_GestorBD(string base_dados)
        {

            //Definir a connection string da ligação:

            bd_password = "lork132132";
            strconne = "Data source = " + pasta_bd + base_dados + ".sdf; Password = " + bd_password;

            StringBuilder str = new StringBuilder();

            //Define a base da strconne:

            str.Append("Data source = ");

            //Se existe pasta/localização definida:
            if (pasta_bd != "")
            {

                str.Append(pasta_bd);

            }

            //Acrescenta o nome da base de dados:
            str.Append(base_dados + ".sdf");

            //Adiciona a password se for necessário:
            if (bd_password != "")
            {
                str.Append("; Password = " + bd_password);
            }

            //Define a strcnne:
            strconne = str.ToString();





        }
        //==============================================================================================

        //==============================================================================================

        public void CriarBaseDados(string base_dados, List<string> instrucoes, bool verificar_ficheiro = false)
        {
            #region Criar Arquivo

            //Criar uma base de dados nova:

            #region Verificação do ficheiro da base de dados

            if (verificar_ficheiro)
            {
                if (File.Exists(base_dados))
                {
                    if (MessageBox.Show("Existe uma base de dados com o mesmo nome." + Environment.NewLine +
                                            "Deseja substituir a base de dados existente?", "Aviso",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        //Apagar o arquivo existente:
                        try
                        {

                            File.Delete(base_dados);

                        }
                        catch
                        {

                            MessageBox.Show("Não foi possível deletar o arquivo existente." + Environment.NewLine +
                                            "Tente finalizar todas as atividades que estão sendo realizadas com esse arquivo.", "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;

                        }

                    }
                }
            }

            #endregion

            //Construção da Connection String:
            StringBuilder str = new StringBuilder();
            str.Append("Data source = ");

            //nome da base de dados:
            str.Append(base_dados);

            //Verificar se tem password:
            if (bd_password != "")
            {
                str.Append("; Password =" + bd_password);
            }


            //Criação da base de dados:
            SqlCeEngine motor = new SqlCeEngine(str.ToString());
            motor.CreateDatabase();

            #endregion

            #region Criação das tabelas dentro da base de dados:

            ligação = new SqlCeConnection(str.ToString());
            ligação.Open();
            comando = new SqlCeCommand();
            comando.Connection = ligação;

            /* Executa as instruções para criar as tabelas: */

            str = null;

            foreach (string instrução in instrucoes)
            {
                if (instrução.StartsWith("CREATE TABLE"))
                {
                    //Inicia a criação da query

                    str = new StringBuilder();
                    str.Append(instrução);

                }
                else if (instrução == "FIM")
                {

                    //Fechar a criação da query e executá-la:
                    comando.CommandText = str.ToString();
                    comando.ExecuteNonQuery();
                }

                else
                {
                    //Adicionar instrução ao String Builder:
                    str.Append(instrução);
                }


            }

            //Fecha o comando e a ligação:
            ligação.Dispose();
            comando.Dispose();

            #endregion


        }

        //==============================================================================================

        //==============================================================================================

        public DataTable EXE_READER(string query, List<SQLParametro> parametros = null)
        {
            //Ler ou pesquisar informações da base de dados:
            //SELECT...

            DataTable dados = new DataTable();

            adaptador = new SqlCeDataAdapter(query, strconne);

            adaptador.SelectCommand.Parameters.Clear();

            //Executar a query:
            try
            {
                //Insere os parâmetros na query:
                if (parametros != null)
                {
                    foreach(SQLParametro p in parametros)
                    {
                        adaptador.SelectCommand.Parameters.AddWithValue(p.parametro, p.valor);
                    }
                }


                adaptador.Fill(dados);
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao preencher a DataTable do método EXE_READER da classe cl_GestorBD." + Environment.NewLine +
                                 "Verifique o texto do comando da query.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            adaptador.Dispose();
            return dados;

        }

        //==============================================================================================

        public void EXE_NON_QUERY(string query, List<SQLParametro> parametros = null)
        {
            //Executar queries do tipo INSERT, DELETE, UPDATE, CREATE TABLE e etc.
            ligação = new SqlCeConnection(strconne);
            ligação.Open();

            comando = new SqlCeCommand(query,ligação);
            comando.Parameters.Clear();

            try
            {

                //adição de parâmetros no comando
                if(parametros != null)
                {
                    foreach(SQLParametro p in parametros)
                    {
                        comando.Parameters.AddWithValue(p.parametro, p.valor);
                    }

                    //Executar a query:
                    comando.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Crítico e Destruidor de Mundos: " + ex.Message);


            }

            //Destruir a ligação e o comando:
            comando.Dispose();
            ligação.Dispose();




        }

        //==============================================================================================

        //==============================================================================================

        public int ID_DISPONIVEL(string tabela, string coluna)
        {

            //Devolve o id disponível para o próximo registro:
            int id_temp = -1;

            string query = "SELECT MAX(" + coluna + ") AS MaxID FROM " + tabela;

            DataTable dados = new DataTable();

            adaptador = new SqlCeDataAdapter(query, strconne);

;           adaptador.Fill(dados);

            //Verifica se o id é DBnull ou não:
            if (dados.Rows.Count != 0)
            {
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                {
                    id_temp = 0;
                }

                else
                {
                    id_temp = Convert.ToInt16(dados.Rows[0][0]) + 1;
                }            
            }
            
            return id_temp;

        }

        //==============================================================================================

        //==============================================================================================

        //1º preparar uma data table:
        public DataTable PREPARAR_DATATABLE(string query)
        {
            //Preparar a datatable para atualização ou inserção de dados

            adaptador_temp = new SqlCeDataAdapter(query, strconne);
            DataTable dados = new DataTable();

            try
            {

                adaptador_temp.Fill(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO CATASTRÓFICO: " + ex.Message);

            }

            return dados;
        }


        //==============================================================================================

        //==============================================================================================

        //2º atualizar a base de dados com os novos dados:
        public void GRAVAR_DATATABLE(DataTable dados)
        {

            SqlCeCommandBuilder cmd = new SqlCeCommandBuilder(adaptador_temp);

            adaptador_temp.UpdateCommand = cmd.GetUpdateCommand();

            try
            {

                adaptador_temp.Update(dados);

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO VITAL: " + ex.Message);

            }

            adaptador_temp.Dispose();
        }

        //==============================================================================================

        //==============================================================================================

        public bool COMPACTAR_BASE_DE_DADOS()
        {
            bool concluido = false;
            try
            {
                //Compacta a base de dados:
                SqlCeEngine motor = new SqlCeEngine();
                motor.LocalConnectionString = strconne;
                motor.Compact(strconne);

                concluido = true;
            }
            catch (Exception ex)
            {
                concluido = false;
                MessageBox.Show("ERRO FATAL E PERIGOSAMENTE PERIGOSO: " + ex.Message);

            }

            return concluido;

        }

        //==============================================================================================



    }
}
