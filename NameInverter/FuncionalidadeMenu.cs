using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    internal class FuncionalidadeMenu : IFuncionaldiadeMenu
    {
        public Dictionary<Guid, string> Adicionar(Dictionary<Guid, string> dicionario)
        {
            Console.Clear();
            Console.WriteLine("==Adicionar==");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Name name = new CommonName(nome);

            if (dicionario.ContainsValue(nome))
            {
                Console.WriteLine("Nome ja existe!");
                Console.WriteLine("Precione ENTER");
                Console.ReadLine();
                return dicionario;
            }

            dicionario.Add(name.Id, name.name);

            return dicionario;
        }

        public Dictionary<Guid, string> Atualizar(Dictionary<Guid,string> dicionario)
        {
            Console.Clear();
            foreach (var name in dicionario)
            {
                Console.WriteLine($"Id {name.Key} Nome: {name.Value}");
            }
            Console.WriteLine("==Atualizar==");
            Console.Write("Nome á atualizar: ");
            string nome = Console.ReadLine();



            foreach(var name in dicionario)
            {
                if(name.Value == nome)
                {
                    Console.Write($"Atualizar nome(id:{name.Key}): ");
                    string nameAlterado = Console.ReadLine();

                    dicionario[name.Key] = nameAlterado;
                    Console.WriteLine("Nome alterasdo com sucesso!");
                    break;
                }
            }


            return dicionario;
        }

        public void Deletar()
        {
            throw new NotImplementedException();
        }

        public void Listar(Dictionary<Guid, string> dicionario)
        {
            Console.Clear();
            Console.WriteLine("==LISTAR==");

            foreach (var name in dicionario)
            {
                Console.WriteLine($"Name:{name.Value}");
            }

            Console.WriteLine("precione ENTER");
            Console.ReadLine();
        }
    }
}
