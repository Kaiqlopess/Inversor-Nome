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
            Dictionary<Guid, string> nameCollections = new Dictionary<Guid, string>();

            bool executar = true;

            while(executar)
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

                var funcao = new FuncionalidadeMenu();
                

                switch (escolha)
                {
                    case "1":
                        Name names;
                        names = funcao.Adicionar();
                        nameCollections.Add(names.Id, names.name);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        Console.WriteLine("Programa finalizado!");
                        Console.WriteLine("Preciosne ENTER");
                        executar = false;
                        break;
                    default:
                        break;
                }
            }
            

            foreach(var nomes in nameCollections)
            {
                Console.WriteLine(nomes.Value);
            }

            




        }
    }
}
