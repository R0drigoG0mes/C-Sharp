using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Script55_Episodio181
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static bool VerificarPermissao(cl_Utilizador user, int opcao )
        {

            //Verifica se o utilizador tem permissão para aceder à funcionalidade

            bool resultado = true;
            if(user.permissoes[opcao] == '0')
                resultado = false;
                
            return resultado;
            


        } 

    }
}
