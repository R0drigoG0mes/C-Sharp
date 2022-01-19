using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;

namespace Script45_Episódio_116_
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
{
    //==============================================================================================
    public class cl_GestorBD
    {

        SqlCeConnection ligação;
        SqlCeCommand comando;
        SqlCeDataAdapter adaptador;

        string strconne = "";
        string pasta_bd = "";
        string bd_password = "";

        //==============================================================================================

        public cl_GestorBD()
        {

        }

        //==============================================================================================

        //==============================================================================================
        public cl_GestorBD(string base_dados)
        {

            //Definir a connection string da ligação:

            //bd_password = "lork132132";
            //strconne = "Data source = " + pasta_bd + base_dados + ".sdf; Password = " + bd_password;

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

        public void CriarBaseDados(string base_dados, List<string> instrucoes,bool verificar_ficheiro = false)
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
                                            "Tente finalizar todas as atividades que estão sendo realizadas com esse arquivo.","Algo deu errado",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            if(bd_password != "")
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

            foreach(string instrução in instrucoes)
            {
              if(instrução.StartsWith("CREATE TABLE"))
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



    }
    //==============================================================================================
}
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
