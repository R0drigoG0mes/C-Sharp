using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script04
{
    class Program
    {
        
        enum cor
        {

        Vermelho, Azul, Rosa, Verde, Amarelo, Branco, Preto
        
        }

        enum nome
        {

        Antonia, Rodrigo, Maria, Alex, Bruno, Waldisney
        
        }

        
        
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome ?");
            
            string nomes = Console.ReadLine();

            switch(nomes)
            {
                case "Rodrigo":
                    Console.WriteLine("Rodrigo eu te conheço");
                    string conheço = Console.ReadLine();
                    if (conheço == "Eu que te criei")
                        Console.WriteLine("Pai? Paiiiii");
                    Console.ReadLine();
                    break;

                case "Antonia":
                    Console.WriteLine("Você é a mumãe!!!");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Nunca te conheci");
                    Console.ReadLine();
                    break;



            }

            cor cores0 = cor.Preto;
            cor cores01 = cor.Amarelo;
            nome Lia = nome.Maria;
            nome Mamae = nome.Antonia;
            


            Console.WriteLine("Fase 01 do Quiz" +
                "------------------------------------------------------------------------------------------------------"
               );
            Console.WriteLine("Qual é a cor?");
            string pergunt0 = Console.ReadLine();

            if (pergunt0 == "Preto")
            {
                Console.WriteLine("Você acertou!!!: " + cores0);
            }

            else if (pergunt0 == "Amarelo")
            {
                Console.WriteLine("Você acertou!!!: " + cores01);

            }

            else
            {
                Console.WriteLine("Você errou ;-;");

                
            }

            Console.WriteLine("Fase 02 do Quiz" +
                "------------------------------------------------------------------------------------------------------"
               );

            Console.WriteLine("Qual é o Nome?");
            string pergunt1 = Console.ReadLine();

            if (pergunt1 == "Maria")
            {
                Console.WriteLine("Você acertou de novo!!!: " + Lia);
            }
            else if(pergunt1 == "Antonia")
            {
                Console.WriteLine("Você acertou de novo!: " + Mamae);
            }
            else
            {
                Console.WriteLine("Você errou ;-;");
                Console.ReadLine();
            }

            Console.WriteLine((int)Lia);
            Console.ReadLine();


        }
    }
}
