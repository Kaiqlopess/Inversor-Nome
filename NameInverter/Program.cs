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

            Console.Write("Digite seu nome: ");
            String name = Console.ReadLine();

            Name rename = new ReversedName(name);


            Console.Write("Nome invertido: ");
            rename.ReverseName();


        }
    }
}
