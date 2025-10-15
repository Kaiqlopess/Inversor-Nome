using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class ListarNome
    {
        private Repositorio _repositorio;

        public ListarNome(Repositorio repositorio) 
        {
            this._repositorio = repositorio;
        }

        public void Listar() {
            _repositorio.Listar();
            Console.ReadLine();
        }


    }
}











