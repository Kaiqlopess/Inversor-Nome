using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class Program
    {
        static void Main(string[] args)
        {

            var funcao = new FuncionalidadeMenu();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==Menu==");
                Console.WriteLine("1.Adcionar");
                Console.WriteLine("2.Atualizar");
                Console.WriteLine("3.Deletar");
                Console.WriteLine("4.Listar");
                Console.WriteLine("5.sair");
                Console.Write("Escolha: ");
                string escolha = Console.ReadLine();

                if (escolha == "5")
                {
                    break;
                }

                funcao.menu(escolha);
                
            }
            

            
    
        }
    }
}
