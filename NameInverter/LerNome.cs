using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class LerNome
    {
 
        public static string LerAdicionar(){
            
            string nomeLido = Console.ReadLine();

            while (TratamentoString.TratarString(nomeLido))
            {
                nomeLido = Console.ReadLine();
                Console.Clear();
            }

            return nomeLido;
        }

        public static string LerDeletar()
        {

            string nomeLido = Console.ReadLine();

            return nomeLido;
        }

        public static string LerAtualizar()
        {

            string nomeLido = Console.ReadLine();

            return nomeLido;
        }


    }
}
