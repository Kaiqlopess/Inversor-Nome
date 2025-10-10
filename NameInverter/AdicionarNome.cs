using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class AdicionarNome : IOperacaoNome
    {
        public string categoria { get => "adicionar";}

        public Name LerNome()
        {
            Console.WriteLine("==ADICIONAR==");
            Console.Write("Digite nome: ");
            string nome = Console.ReadLine();

            while(TratamentoString.TratarString(nome)){
                Console.Clear();
                Console.WriteLine("==ADICIONAR==");
                Console.Write("Digite nome: ");
                nome = Console.ReadLine();
            }

            Name nomeTratado = new CommonName(nome);

            return nomeTratado;
        }
    }
}
