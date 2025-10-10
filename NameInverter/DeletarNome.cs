using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    internal class DeletarNome : IOperacaoNome
    {
        public string categoria => "deletar";

        public string LerNome()
        {
            Console.WriteLine("==DELETAR NOME==");
            Console.WriteLine("Escolha o nome: ");
            string nome = Console.ReadLine();

            return nome;
        }

        Name IOperacaoNome.LerNome()
        {
            throw new NotImplementedException();
        }
    }
}
