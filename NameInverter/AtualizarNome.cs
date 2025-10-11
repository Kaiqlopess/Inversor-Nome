using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class AtualizarNome : IOperacaoNome
    {
        public string categoria => "atualizar";

        public Name LerNome()
        {
            var repositorio = Repositorio.Instacia;


            Console.Write("Escolha o nome: ");
            string nome = Console.ReadLine();

            while (repositorio.Procurar(nome) == null)
            {
                Console.Write("Escolha o nome de novo: ");
                nome = Console.ReadLine();
            }



            return repositorio.Procurar(nome);
        }

    }
}
