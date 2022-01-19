using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Script34_Episodio_55_
{
    public partial class Form1 : Form
    {
        string pasta_config;
        string ficheiro_config = "config.dat";
        
        
        public Form1()
        {
            InitializeComponent();

            pasta_config = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\config\";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // verifica se a pasta config existe
            // se não existir criar a pasta
            GravarConfiguracoes();

            MessageBox.Show("Configurações gravadas com sucesso");




        
        
        
        }

        private void GravarConfiguracoes()
        {

            // verifica se a pasta config existe
            // se não existir criar a pasta
            if (!Directory.Exists(pasta_config))
            {
                Directory.CreateDirectory(pasta_config);

            }

            StreamWriter ficheiro = new StreamWriter(pasta_config + ficheiro_config, false, Encoding.Default);
            ficheiro.WriteLine(text_nome.Text);
            ficheiro.WriteLine(data_hora.Value.ToShortDateString());

            ficheiro.Dispose();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(pasta_config + ficheiro_config))
            {
                GravarConfiguracoes();
            }
            
            StreamReader ficheiro = new StreamReader(pasta_config + ficheiro_config, Encoding.Default);

            text_nome.Text = ficheiro.ReadLine();
            data_hora.Value = Convert.ToDateTime(ficheiro.ReadLine());
            
            ficheiro.Dispose();
        
        
        }
    }
}
