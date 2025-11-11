using NameInverter.CasoDeUso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class ListarNome : IListarNome
    {
        private Repository _repositorio;

        public ListarNome(Repository repositorio) 
        {
            this._repositorio = repositorio;
        }

        public void Listar() {

            _repositorio.ToList();
            Console.ReadLine();
        }
    }
}











