using NameInverter.Repositorio;
using NameInverter.Repositorio.RepositorioSobrenome;
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
        public static bool TratarString(string nome1, string nome2)
        {
            var repositorioNome = new RepositoryNome();
            var repositorioSobrenome = new RepositorySobrenome();


            if (nome1.Any(char.IsDigit) || nome2.Any(char.IsDigit))
            {
                Console.WriteLine("Nome digitado errado!(Não colocar numero)");
                Console.WriteLine("Precione ENTER");
                Console.ReadLine();
                return true;
            }
            else if (Regex.IsMatch(nome1, @"[^a-zA-Z0-9 ]") || Regex.IsMatch(nome2, @"[^a-zA-Z0-9 ]"))
            {
                Console.WriteLine("Nome digitado errado!(Não colocar caracteres especiais)");
                Console.WriteLine("Precione ENTER");
                Console.ReadLine();
                return true;
            }
            else if (repositorioNome.DadosIguais(nome1) || repositorioSobrenome.DadosIguais(nome2))
            {
                Console.WriteLine("Nome ja existe!");
                Console.WriteLine("Precione ENTER");
                Console.ReadLine();
                return true;
            }
            else 
            {
                return false;
            }

        }
    }
}
