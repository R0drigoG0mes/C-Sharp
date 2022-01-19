using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlServerCe;
namespace Script42_Episódio_98_
{
    //==================================================================
    public static partial class vars
    {
        public static string versao = "v.1.0.0";
        public static string pasta_dados;
        public static string base_dados;

        public static void Iniciar()
        {
            // Proceder aos mecanismos de iniciação da aplicação
            pasta_dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AgendaSQL\";

            //Verifica se a pasta de dados existe. Se não existir, cria a pasta de dados.
            if (!Directory.Exists(pasta_dados))
            {
                Directory.CreateDirectory(pasta_dados);
            }

            //Verifica se a base de dados existe:
            base_dados = pasta_dados + "dados.sdf; Password = 'lork132132'";

            if (!File.Exists(pasta_dados + "dados.sdf"))
            {
                CriarBaseDados();
            }


        }

        public static void CriarBaseDados()
        {
            //Criação da base de dados
            SqlCeEngine motor = new SqlCeEngine("Data Source = " + base_dados);
            motor.CreateDatabase();

            //Criar a estrutura da base de dados:
            SqlCeConnection ligação = new SqlCeConnection("Data Source = " + base_dados);
            ligação.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "CREATE TABLE contatos(" +
                "id_contato             int not null primary key, " +
                "nome                   nvarchar(50), " +
                "telefone               nvarchar(15)," +
                "atualização            datetime)";

            comando.Connection = ligação;
            comando.ExecuteNonQuery();
            comando.Dispose();
            ligação.Dispose();
        }





    }
    //==================================================================
}
