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
    public partial class frmInserirEditar : Form
    {
        int indice;
        
        //=======================================================
        public frmInserirEditar()
        {
            InitializeComponent();
            ConstroiLista();
        }
        //=======================================================

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //=======================================================

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            //Fechar formulário
            this.Close();
        }
        //=======================================================
        private void frmInserirEditar_Load(object sender, EventArgs e)
        {

        }
        //=======================================================

        private void ConstroiLista()
        {
            // Adiciona alista de contatos os contatos registrados
            lista_contatos.Items.Clear();
            foreach(cl_contato contato in cl_geral._Contatos_)
            {
                lista_contatos.Items.Add(contato.Nome +" - Número: " + contato.Numero);
                label_número_registros.Text = "Total de Registros: " + lista_contatos.Items.Count;
            
            }

            //Impedir a edição e eliminação de registros:

            cmd_editar.Enabled = false;
            cmd_apagar.Enabled = false;
            
        
        }
        //=======================================================

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            //Insere um novo registro na lista

            //Verifica se todos os campos estão preenchidos
            if(text_nome.Text == "" || text_numero.Text == "")
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Verifica se tem algum registro igual na lista:
            foreach(cl_contato contatos in cl_geral._Contatos_)
            {
                if(contatos._nome == text_nome.Text &&
                    contatos._numero == text_numero.Text)
                {
                    MessageBox.Show("Esse contato já está registrado", 
                                    "Contato Duplicado", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Stop);
                    text_numero.Text = "";
                    text_nome.Text = "";
                    text_nome.Focus();
                    return;
                
                
                }
            
            
            }
            
            
            //Salvar o novo arquivo

            cl_geral.SalvarNovoRegistro(text_nome.Text, text_numero.Text);

            // Atualiza a lista de contatos
            ConstroiLista();

            //Prepara o quadro para um novo registro
            text_nome.Text = "";
            text_numero.Text = "";
            text_nome.Focus();
        
        
        }


        //=======================================================
        private void lista_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Selecionar um contato

            //Verifica indice -1:
            if (lista_contatos.SelectedIndex == -1) return;

            //Seleciona um indice da lista:

            indice = lista_contatos.SelectedIndex;
            cmd_apagar.Enabled = true;
            cmd_editar.Enabled = true;


        
        }
        //=======================================================
        private void cmd_apagar_Click(object sender, EventArgs e)
        {
            //Apaga o registro selecionado:

            //1° Eliminar o contato da lista
            cl_geral._Contatos_.RemoveAt(indice);

            //2° Renovar o registro
            cl_geral.SalvarArquivo();

            //3° Reconstruir a lista de contatos
            ConstroiLista();


        
        
        
        }
        //=======================================================
    }
}
