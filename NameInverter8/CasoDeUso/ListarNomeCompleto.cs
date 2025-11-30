using NameInverter.Repositorio;
using NameInverter.Repositorio.RepositorioNome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso
{
    public class ListarNomeCompleto
    {
        private IRepositoryNome _repository = new RepositoryNome();

        public void listar()
        {
            var listNomeCompleto = _repository.TolistNameComplete();

            Console.Clear();

            Console.WriteLine("LISTA DE NOMES COMPLETOS:");

            foreach (var item in listNomeCompleto)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"ID({item.Id})/{item.name} {item.Sobrenome?.name}");
            }
 
            Console.WriteLine("\nprecione ENTER!");
            Console.ReadLine();
        }
    }
}
