using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script28_Episodio_47_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnu_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmd_falso_Click(object sender, EventArgs e)
        {
            mnu_combo_1.Items.Add("Cokie");
            mnu_combo_1.Items.Add("Cokie de Baunilha");
            mnu_combo_1.Items.Add("Cokie de Nutela");
            mnu_combo_1.Items.Add("Cokie de Chocolate Branco");
        }

        private void mnu_open_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OPEN");
        }

        private void mnu_combo_1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mnu_combo_1.Items.Add("Cokie Radiotivo");
            mnu_combo_1.Items.Add("Cokie do Esgoto");
            mnu_combo_1.Items.Add("Cokie de Abacaxi");
            mnu_combo_1.Items.Add("Cokie de Banófli");
        }

        private void mnu_combo_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mnu_combo_1.Text == "Cokie Radiotivo")
            {
                MessageBox.Show("Cherno Foods".ToUpper());
            }
        }
    }
}
