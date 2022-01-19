using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Script44_Episodio_112_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criar a base de dados:



            //SQLiteConnection.CreateFile(@"C:\Users\User\Documents\Teste Sqlite\dados.db");


            //Estabelecer a conexão com  a base de dados:

            SQLiteConnection ligaçao = new SQLiteConnection(@"Data source = C:\Users\User\Documents\Teste Sqlite\dados.db; Version = 3;");


            ligaçao.Open();

            //Criar uma tabela na base de dados:
            string query = "CREATE TABLE contatos(" +
                            "id_contato     int, primary key," +
                            "nome           varchar(50)" +
                            "telefone       varchar(15))";

            SQLiteCommand comando = new SQLiteCommand(query,ligaçao);
            comando.ExecuteNonQuery();

            MessageBox.Show("tu tata tu tu ta");

           
        }
    }
}
