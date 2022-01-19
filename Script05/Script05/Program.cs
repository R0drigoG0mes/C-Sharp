using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script05
{
    class Program
    {
        enum opcao
        {
            criar=1, RAM, processador
        }
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opcões abaixo com um valor numérico: ");
            Console.WriteLine("1- Criar\n" + "2- Ver memória Ramn\n" + "3- Ver processador");
            int selecion = int.Parse(Console.ReadLine());
            opcao selecionada = (opcao)selecion;
            
            switch (selecionada)
            {
                case opcao.criar:
                    Console.WriteLine("Você deseja criar");
                    break;

                case opcao.RAM:
                    Console.WriteLine("Você quer checar a sua memória RAM!!");
                    break;

                case opcao.processador:
                    Console.WriteLine("Você quer checar o seu processador");
                    break;
                default:
                    Console.WriteLine("opção desconhecida ERROR 777");
                    break;

                    

            }

            Console.ReadLine();
        
        
        
        }
    }
}
