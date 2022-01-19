using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Windows.Forms;


namespace Meu_Progresso
{
    public static class cl_Métodos
    {
        public static void CriarBaseDados()
        {
            
            MessageBox.Show("Bem vindo ao programa Meu Progresso, por favor escolha uma localidade para o armazenamento de dados", "Escolher Diretório",MessageBoxButtons.OK,MessageBoxIcon.Information);
            OpenFileDialog selecionar = new OpenFileDialog();

            

            selecionar.ShowDialog();
            
            
            
            
        }
        

    }
}
