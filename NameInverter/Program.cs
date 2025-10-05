using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("==Menu==");
            Console.WriteLine("1.Adcionar");
            Console.WriteLine("2.Atualizar");
            Console.WriteLine("3.Deletar");
            Console.WriteLine("4.Listar");
            Console.Write("Escolha: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    break;
            }

            




        }
    }
}
