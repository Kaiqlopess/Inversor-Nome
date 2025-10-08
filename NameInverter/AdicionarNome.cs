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
            Console.WriteLine("Digite nome: ");
            string nome = Console.ReadLine();

            /*if (TratamentoString.TratarString(nome)){
                Console.WriteLine("Nome digitado errado!");
            }*/

            Name nomeTratado = new CommonName(nome);

            return nomeTratado;
        }
    }
}
