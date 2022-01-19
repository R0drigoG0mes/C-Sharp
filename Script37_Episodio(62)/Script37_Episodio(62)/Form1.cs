using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script37_Episodio_62_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Array

            string[] nomes;
            nomes = new string[5];

            nomes[0] = "Jõao";
            nomes[1] = "Antonio";
            nomes[2] = "Ednaldo";
            nomes[3] = "Pereira";
            nomes[4] = "Preá";

            lista.Items.AddRange(nomes);

            //Coleção do tipo - LIST

            List<string> Namae = new List<string>();
            Namae.Add("Ednaldo");
            Namae.Add("Pereira");
            Namae.Add("One Punch");
            Namae.Add("Scrath");
            Namae.Add("Ednaldo");
            Namae.Add("Pereira");
            Namae.Add("One Punch");
            Namae.Add("Scrath");
            Namae.Add("Ednaldo");
            Namae.Add("Pereira");
            Namae.Add("One Punch");
            Namae.Add("Scrath");
            Namae.Add("Ednaldo");
            Namae.Add("Pereira");
            Namae.Add("One Punch");
            Namae.Add("Scrath");
            Namae.Add("Ednaldo");
            Namae.Add("Pereira");
            Namae.Add("One Punch");
            Namae.Add("Scrath");

            Namae.Remove("Scrath");
            
            foreach (string Item in Namae)
            {
                lista.Items.Add(Item);
            
            
            }

            
            MessageBox.Show(Namae.Count.ToString());

            if (Namae.Contains("Ednaldu"))
            {
                MessageBox.Show("Contém");
            }
            else
            {
                MessageBox.Show("Não Contém");
            }

            MessageBox.Show(Namae.LastIndexOf("Ednaldo").ToString());





        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> inteiros = new List<int>() { 10, 20, 30 };
            foreach (int item in inteiros)
            {
                lista.Items.Add(item);
            }

            



        
        
        
        
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HashSet<string> lista_nomes = new HashSet<string>() 
            {
                "João", "Carlos", "Marco", "Ednaldo",
            
            };

            if (!lista_nomes.Add("Carlos"))
            {
                MessageBox.Show("ERRO");
            }
            
            foreach (string item in lista_nomes)
            {
                lista.Items.Add(item);
            }
            
            MessageBox.Show(lista_nomes.Count.ToString());
        
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> _nomes = new Dictionary<string, string>()
            {
                ["Capacho"] = "Brigaderu",
                ["Tombo"] = "Karol Konka",
            
            
            
            };

            _nomes.Add("Pãozim", "Bercoule");
            _nomes.Add("Pão", "Street Kiker");

            MessageBox.Show(_nomes["Tombo"]);

            foreach (KeyValuePair<string,string> item in _nomes)
            {
                lista.Items.Add(item.Value);


            }

            if (_nomes.ContainsKey("Capacho"))
            {
                MessageBox.Show("Cara Eu Não Suporto Tanto CAaAAALOOOOOOOOOOR");

            }

            else
            {
                MessageBox.Show("Não tem cara");


            }
            


        
        
        
        }
    }
}
