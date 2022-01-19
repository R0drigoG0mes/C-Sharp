using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script06
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] palavras = { "óculos", "lupa", "galileu" };
            int[] números = { 1, 2222, 3};
            bool[] sim = { 10 > 1, 11 < 12, 15 > 2};
            string[] objetos = { "chave", "luva", "meia", "caneta", "lâmpada" };

            /*foreach (string palav in palavras) 
            {
                Console.WriteLine(palavras[0]);
                Console.WriteLine(palav);
            }

            foreach (int nume in números)
            {
                Console.WriteLine(números[1]);
                Console.WriteLine(nume);
            }

            foreach (bool boleanu in sim)
            {
                Console.WriteLine(sim[2]);
                Console.WriteLine(sim[0]);
                Console.WriteLine(sim[0]);
                Console.WriteLine(boleanu);
            }*/

            
            
            
            for (int objet = 0; objet < objetos.Length ; objet++ )
            {

                Console.WriteLine(objet);
                Console.WriteLine(objetos[objet]);
                    
            }


            for (int palav = 0; palav < palavras.Length; palav++)
            {
                Console.WriteLine(palav);
                Console.WriteLine(palavras[palav]);
            }


            for (int yes = 0; yes<sim.Length; yes++)
            {
                Console.WriteLine(yes);
                Console.WriteLine(sim[yes]);
            }



            Console.WriteLine("\n\nCaboooo ;-;");
            Console.ReadLine();



        
        
        }   
    }
}
