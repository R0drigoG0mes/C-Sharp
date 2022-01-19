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
    public partial class frmTexto : Form
    {
        //===================================================================================
        //Propriedade de controle:
        public bool Cancelado { get; set; }
        public string pesquisa { get; set; }
        //===================================================================================

        //===================================================================================
        public frmTexto()
        {
            InitializeComponent();
        }
        //===================================================================================

        //===================================================================================
        private void text_pesquisa_TextChanged(object sender, EventArgs e)
        {

        }
        //===================================================================================

        //===================================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            //Cancela o quadro:
            Cancelado = true;
            this.Close();
        
            
        
        
        }
        //===================================================================================

        //===================================================================================
        private void cmd_pesquisar_Click(object sender, EventArgs e)
        {
            //Define o texto da pesquisa:
            if (text_pesquisa.Text == "") return;
            pesquisa = text_pesquisa.Text;
            Cancelado = false;
            this.Close();
        
        
        }
        //===================================================================================

        //===================================================================================
        private void text_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                cmd_pesquisar_Click(cmd_pesquisar, EventArgs.Empty);
            
            
            }
        
        
        }
        //===================================================================================
    }
}
