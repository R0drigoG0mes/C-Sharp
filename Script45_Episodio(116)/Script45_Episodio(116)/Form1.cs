using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Script45_Episodio_116_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl_GestorBD gestor = new cl_GestorBD();

            //Define as instruções das tabelas:

            List<string> instrucoes = new List<string>()
            {
                //Tabela Clientes

                "CREATE TABLE clientes(",
                "id_cliente         int not null primary key,",
                "nome               nvarchar(50),",
                "telefone           nvarchar(15),",
                "atualização        datetime)",
                "FIM",

                //Tabela Compras

                "CREATE TABLE compras(",
                "id_compra         int not null primary key,",
                "id_cliente               int,",
                "produto           nvarchar(50),",
                "quantidade        int,",
                "preço_unidade     int,",
                "atualização       datetime,",
                "FOREIGN KEY(id_cliente) REFERENCES clientes(id_cliente) ON DELETE CASCADE)",
                "FIM",


            };



            gestor.CriarBaseDados(@"C:\Users\User\Documents\Rodrigo\SQL Ce\loja", instrucoes, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abertura da base de dados:
            cl_GestorBD gestor = new cl_GestorBD("loja");

            //construção da lista de parâmetros:
            List<cl_GestorBD.SQLParametro> parametros = new List<cl_GestorBD.SQLParametro>();

            parametros.Add(new cl_GestorBD.SQLParametro("@nome", textpesquisa.Text));

            //Executa a query:
            DataTable dados = gestor.EXE_READER("SELECT * FROM clientes WHERE nome = @nome", parametros);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Abertura da base de dados:
            cl_GestorBD gestor = new cl_GestorBD("loja");

            //Executa a query:
            DataTable dados = gestor.EXE_READER("SELECT * FROM clientes WHERE nome = '" + textpesquisa.Text + "'");


        }

        private void button4_Click(object sender, EventArgs e)
        {

            cl_GestorBD gestor = new cl_GestorBD("loja");

            //gestor.EXE_NON_QUERY("INSERT INTO clientes VALUES (" +
            //    1 + "," + "'Carlos'," + "'41982763981'," + "'" + DateTime.Now + "')");

            //Criar a lista de parâmetros:
            List<cl_GestorBD.SQLParametro> parametros = new List<cl_GestorBD.SQLParametro>();
            parametros.Add(new cl_GestorBD.SQLParametro("@id_cliente", 1));
            parametros.Add(new cl_GestorBD.SQLParametro("@nome", "Carlos"));
            parametros.Add(new cl_GestorBD.SQLParametro("@numero", "4199872031"));
            parametros.Add(new cl_GestorBD.SQLParametro("@atualização", DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString()));

            gestor.EXE_NON_QUERY("INSERT INTO clientes VALUES(" +
                                 "@id_cliente, @nome, @numero, @atualização)", parametros);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //verifica se os campos estão preenchidos:
            if(text_nome.Text == "" || text_telefone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos de texto","Campo vazio",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }



            //Gravação do novo cliente na base de dados:
            cl_GestorBD gestor = new cl_GestorBD("loja");

            //Busca o id_cliente disponível:
            int id_cliente = gestor.ID_DISPONIVEL("clientes","id_cliente");

            //Parâmetros:
            List<cl_GestorBD.SQLParametro> parametros = new List<cl_GestorBD.SQLParametro>();

            parametros.Add(new cl_GestorBD.SQLParametro("@id_cliente",id_cliente));
            parametros.Add(new cl_GestorBD.SQLParametro("@nome", text_nome.Text));
            parametros.Add(new cl_GestorBD.SQLParametro("@numero", text_telefone.Text));
            parametros.Add(new cl_GestorBD.SQLParametro("@atualização", DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString()));

            gestor.EXE_NON_QUERY("INSERT INTO clientes VALUES(" +
                                 "@id_cliente, @nome, @numero, @atualização)", parametros);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Prepara uma datatable:
            cl_GestorBD gestor = new cl_GestorBD("loja");

            DataTable dados = gestor.PREPARAR_DATATABLE("SELECT * FROM clientes");

            //.... alterações que achar necessário:
            foreach(DataRow linha in dados.Rows)
            {
                //Alterar o telefone:
                string novo_telefone = "(41)" + linha["telefone"].ToString();
                linha["telefone"] = novo_telefone;


            }

            gestor.GRAVAR_DATATABLE(dados);



        }

        private void button7_Click(object sender, EventArgs e)
        {
            //inserir novos clientes na base de dados:

            List<string> lista_nomes = new List<string>();

            lista_nomes.Add("nome 1");
            lista_nomes.Add("nome 2");
            lista_nomes.Add("nome 3");
            lista_nomes.Add("nome 4");
            lista_nomes.Add("nome 5");

            List<string> telefones = new List<string>();

            telefones.Add("7498375");
            telefones.Add("30953430");
            telefones.Add("348509348");
            telefones.Add("10378364");
            telefones.Add("109263563");

            cl_GestorBD gestor = new cl_GestorBD("loja");

            DataTable dados = gestor.PREPARAR_DATATABLE("SELECT * FROM clientes WHERE id_cliente = -1");

            int id_temp = gestor.ID_DISPONIVEL("clientes","id_clientes");

            //Percorrer todos os nomes e adicionar à DataTable:

            for (int index = 0; index < lista_nomes.Count; index++)
            {
                DataRow nova_linha = dados.NewRow();
                nova_linha["id_cliente"] = id_temp;
                nova_linha["nome"] = lista_nomes[index];
                nova_linha["telefone"] = telefones[index];
                dados.Rows.Add(nova_linha);
                id_temp++;

            }

            gestor.GRAVAR_DATATABLE(dados);


        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Compactar a base de dados:
            cl_GestorBD gestor = new cl_GestorBD("loja");

            if(gestor.COMPACTAR_BASE_DE_DADOS() == true)
            {
                MessageBox.Show("A base de dados foi compactada com sucesso", "Ação completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
