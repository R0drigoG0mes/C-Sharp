using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script03
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] produtos = new string[3]
          { "Azul", "Vermelho", "verde" };


            Console.WriteLine(produtos[1]);


            Console.WriteLine("Escreva o seu nominhozinho: ");
            string nomes = Console.ReadLine();

            switch (nomes)
            {

                case "Antonia":
                    Console.WriteLine("Você é Antonia Risomar Gomes, Certo?");
                    
                    break;

                case "Lia":
                    Console.WriteLine("Você é Maria Helena, certo?");
                  
                    break;

                case "Rodrigo":
                    Console.WriteLine("Você é Rodrigo Goku, certo?");
                    string rodrigo = Console.ReadLine();
                    if (rodrigo == "não")
                        Console.WriteLine("Então eu sou o Vegeta");
                    Console.ReadLine();
                     
                    
                    
                    break;

                default:


                    Console.WriteLine("Esse nome eu não conheço, mó triste ;-;");
                    break;


            }


            Console.WriteLine("Qual é seu país natal?");
            string paises = Console.ReadLine();

            switch (paises)
            {
                case "Brasil":
                        Console.WriteLine("Então você é meu conterrâneo!!!");
                    break;

                case "África":

                    Console.WriteLine("Ai que buroooo da 0000 para ele akka ");
                    break;

                case "Alemanha":
                    Console.WriteLine("Xucruteeeee Avistado");
                    break;


                default:
                    Console.WriteLine("Esse país não existe, você é uma ILUSÃO");
                    break;
                    
                    




            }

            

  
            



        }


       
    
    
    
    
    
}
