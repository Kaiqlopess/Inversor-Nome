using NameInverter.CasoDeUso.Contratos.Sobrenome;
using NameInverter.Repositorio;
using NameInverter.Repositorio.RepositorioSobrenome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso.Serviços.Sobrenome
{
    public class ListarSobrenome : IListarSobrenome
    {
        private RepositorySobrenome _repositorio;

        public ListarSobrenome(RepositorySobrenome repositorio)
        {
            this._repositorio = repositorio;
        }

        public void Listar()
        {
            Console.Clear();
            _repositorio.ToList();
            Console.WriteLine("Precione ENTER");
            Console.ReadLine();

        }
    }
}
