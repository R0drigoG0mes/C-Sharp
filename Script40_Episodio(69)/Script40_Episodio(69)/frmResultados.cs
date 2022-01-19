using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script40_Episodio_69_
{
    public partial class frmResultados : Form
    {
        string _pesquisa;
        //=================================================================================================
        public frmResultados(string pesquisa)
        {
            InitializeComponent();

            //Definir o texto de pesquisa:
            _pesquisa = pesquisa.ToUpper();


        }
        //=================================================================================================

        //=================================================================================================
        private void label_número_registros_Click(object sender, EventArgs e)
        {

        }
        //=================================================================================================

        //=================================================================================================
        private void frmResultados_Load(object sender, EventArgs e)
        {
            //Executa a pesquisa e constroi lista:
            ExecutaPesquisa();
        
        
        
        }
        //=================================================================================================

        //=================================================================================================
        private void ExecutaPesquisa()
        {
            //Realiza a pesquisa e apresenta dados:
            List<cl_contato> lista_resultados = new List<cl_contato>();
            foreach(cl_contato contato in cl_geral._Contatos_)
            {
                if(contato._nome.ToUpper().Contains(_pesquisa) ||
                    contato._numero.ToUpper().Contains(_pesquisa))
                {
                    lista_resultados.Add(contato);
                
                
                
                
                }
            
            
            
            }

            //Apresenta os resultados:
            lista_final.Items.Clear();
            foreach(cl_contato contato in lista_resultados)
            {
                lista_final.Items.Add("Nome: " + contato._nome + " - " + contato._numero);
                label_número_registros.Text = "Registros Encontrados: " + lista_final.Items.Count;
            }




        }
        //=================================================================================================

        //=================================================================================================
        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //=================================================================================================

        //=================================================================================================
        private void cmd_nova_pesquisa_Click(object sender, EventArgs e)
        {
            //Pedir novo texto:
            frmTexto f = new frmTexto();
            f.ShowDialog();

            //Quando o quadro é fechado...
            if (f.Cancelado) return;

            _pesquisa = f.pesquisa.ToUpper();

            ExecutaPesquisa();
        
        
        
        }
        //=================================================================================================
    }
}
