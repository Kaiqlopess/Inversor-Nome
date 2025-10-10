using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NameInverter
{
    public class TratamentoString
    {
        public static bool TratarString(string nome)
        {
            if (nome.Any(char.IsDigit)) {
                Console.WriteLine("Nome digitado errado!(Não colocar numero)");
                Console.ReadLine();
                return true;
            }

            if (Regex.IsMatch(nome, @"[^a-zA-Z0-9 ]")){
                Console.WriteLine("Nome digitado errado!(Não colocar caracteres especiais)");
                Console.ReadLine();
                return true;
            }

            return false;

        }
    }
}
