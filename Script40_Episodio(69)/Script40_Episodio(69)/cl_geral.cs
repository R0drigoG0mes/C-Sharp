using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Script40_Episodio_69_
{
    public static class cl_geral
    {
        public static string versão = "v 1.0.0";

        // Lista de contatos
        public static List<cl_contato> _Contatos_;

        public static void ConstruirListaContatos()
        {
            //=======================================================
            //método para o carregamento da lista de contatos:

            //Verificar se o arquivo existe:

            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\Arquivo_Contatos.txt";

            //Cria a Lista vazia
            _Contatos_ = new List<cl_contato>();

            if (File.Exists(nome_ficheiro))
            {
                StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);
                

                //Carregar todos os contatos do ficheiro
                while (!ficheiro.EndOfStream)
                {
                    //Carrega Nome:
                    string nome = ficheiro.ReadLine();
                    //Carrega Número:
                    string numero = ficheiro.ReadLine();

                    // Adicionar à lista de contatos o contato carregado
                    cl_contato novo_contato = new cl_contato();
                    novo_contato._nome = nome;
                    novo_contato._numero = numero;
                    _Contatos_.Add(novo_contato);




                }
                
                
                
                ficheiro.Dispose();
            }

        
        
        }
        //=======================================================

        public static void SalvarNovoRegistro(string nome, string numero)
        {
            //=======================================================
            // Salvar um novo registro (na lista e no ficheiro)

            //Salvar na lista: (Jeito Rápido)
            _Contatos_.Add(new cl_contato() {_nome = nome, _numero = numero });

            //Jeito demorado:

            //cl_contato novo = new cl_contato();
            //novo._numero = nome;
            //novo._numero = numero;
            //_Contatos_.Add(novo);

            //Atualiza o Ficheiro/Arquivo
            SalvarArquivo();
            //=======================================================


        }

        public static void SalvarArquivo()
        //=======================================================
        {

            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\Arquivo_Contatos.txt";

            StreamWriter ficheiro = new StreamWriter(nome_ficheiro, false, Encoding.Default);
            
            foreach(cl_contato contatos in _Contatos_)
            {
                ficheiro.WriteLine(contatos._nome);
                ficheiro.WriteLine(contatos._numero);

            }
            
            ficheiro.Dispose();
        }
        //=======================================================

    }
}
