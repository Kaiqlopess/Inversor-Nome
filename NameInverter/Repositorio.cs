using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class Repositorio
    {
        private static Repositorio _repositorio;
        private Dictionary<Guid, string> _dados = new Dictionary<Guid, string>();

        private Repositorio() { }

        public static Repositorio Instacia
        {
            get 
            {
                if (_repositorio == null) {
                    _repositorio = new Repositorio();
                }
                return _repositorio; 
            }
        }

        public void Add(Guid key, string nome) 
        {
            _dados.Add(key, nome);
        }

        public void list() 
        {
            foreach (var nomes in _dados)
            {
                Console.WriteLine($"ID({nomes.Key})/Nome: {nomes.Value}");
            }
        }
    }
}
