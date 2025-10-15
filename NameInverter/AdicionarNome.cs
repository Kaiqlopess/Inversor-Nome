using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class AdicionarNome
    {
        private Repositorio _repositorio;

        public AdicionarNome(Repositorio repositorio)
        {
            this._repositorio = repositorio;
        }
        
        public void Adicionar(string nome)
        {
            this._repositorio.Add(nome);
        }
    }
        //public string categoria { get => "adicionar";}

        //public Name LerNome()
        //{
        //    Console.Clear();
        //    Console.WriteLine("==ADICIONAR==");
        //    Console.Write("Digite nome: ");
        //    string nome = Console.ReadLine();

        //    while(TratamentoString.TratarString(nome)){
        //        Console.Clear();
        //        Console.WriteLine("==ADICIONAR==");
        //        Console.Write("Digite nome: ");
        //        nome = Console.ReadLine();
        //    }

        //    Name nomeTratado = new CommonName(nome);

        //    return nomeTratado;
        //}
    
}
