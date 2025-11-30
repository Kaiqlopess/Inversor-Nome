using NameInverter.CasoDeUso.Contratos.Nome;
using NameInverter.Repositorio;
using NameInverter.Repositorio.RepositorioNome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso.Serviços.Nome
{
    public class ListarNome : IListarNome
    {
        private RepositoryNome _repositorio;

        public ListarNome(RepositoryNome repositorio) 
        {
            this._repositorio = repositorio;
        }

        public void Listar() {
            Console.Clear();

            List<CommonName> nomes= _repositorio.ToList();

            foreach (var nome in nomes)
            {
                Console.WriteLine($"ID({nome.Id})/Nome: {nome.name}");
            }

            Console.WriteLine("Precione ENTER");
            Console.ReadLine();
            
        }
    }
}











