using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script23_polimorfismo
{
   
    //============================================================
    abstract class forma_geometrica
    {
        int _largura;
        int _altura;
        //==============================================
        public int Largura
        {
            get { return _largura; }
            set { _largura = value; }

        }
        
        //==============================================
        
        public int Altura
        {
            get { return _altura;}
            set { _altura = value;   }
        
        
        }
        //==============================================
        public void ApresentarSe()
        {
            System.Windows.Forms.MessageBox.Show("este método é da classe base.");   
        }
        //=============================================

        public abstract void Desenhar();
        //==============================================
        public virtual void Desenhar_outro()
        {
            System.Windows.Forms.MessageBox.Show("Método virtual da classe base");
        
        
        }
        //================================================

    
    }

    //=================================================

    class rectangulo : forma_geometrica
    {
        public override void Desenhar()
        {
            System.Windows.Forms.MessageBox.Show("Desenhar rectangulo com as dimensões: " + Largura + "X" + Altura );
        }

        public override void Desenhar_outro()
        {
            System.Windows.Forms.MessageBox.Show("ESte é um método substituído na classe derivada.");
        }





    }
    //=================================================

    class triangulo : forma_geometrica
    {
        public override void Desenhar()
        {
            System.Windows.Forms.MessageBox.Show("Desenhar triângulo com as dimensões: " + Largura + "X" + Altura);
        }
    }

    //=================================================

    class circunferencia : forma_geometrica
    {
        public override void Desenhar()
        {
            System.Windows.Forms.MessageBox.Show("Desenhar circunferencia com as dimensões: " + Largura + "X" + Altura);
        }
    }






}



