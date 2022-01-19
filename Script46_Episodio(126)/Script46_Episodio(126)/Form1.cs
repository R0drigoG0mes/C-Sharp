using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Script46_Episodio_126_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> lista_nomes = new List<string>();

            #region Nomes da lista
            lista_nomes.Add("Pedro");
            lista_nomes.Add("Jeroboão");
            lista_nomes.Add("João");
            lista_nomes.Add("Matias");
            lista_nomes.Add("Barnabé");
            lista_nomes.Add("Alma");
            lista_nomes.Add("Alakazam");
            lista_nomes.Add("Woobufet");
            lista_nomes.Add("Dragonite");
            lista_nomes.Add("Rayquaza");
            lista_nomes.Add("Charizard");
            lista_nomes.Add("Mew");
            #endregion

            #region Anotações Gerais



            #endregion

            //Utilizar LINQ:

            List<string> lista_final = (from i in lista_nomes where i.StartsWith("M") select i).ToList();

            lista.Items.Add(lista_final[0]);

            //foreach(string nome in lista_nomes)
            //{
            //    if (nome.StartsWith("J"))
            //    {
            //        lista.Items.Add(nome);
            //    }
            //}

        }
    }
}
