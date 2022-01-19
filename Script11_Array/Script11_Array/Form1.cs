using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script11_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            int[] valores = new int []
            {
                45,43,12,3453,3452,2345,56,543,5635,63,456354754

            };

            foreach (int valor in valores)
            {
                lista.Items.Add(valor);
            }
            

                 

            






        }
    }
}
