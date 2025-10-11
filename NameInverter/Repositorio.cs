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

        public void Listar() 
        {
            foreach (var nomes in _dados)
            {
                Console.WriteLine($"ID({nomes.Key})/Nome: {nomes.Value}");
            }
        }

        public bool DadosIguais(string nome) 
        {
            if (_dados.ContainsValue(nome))
            {
                return true;
            }
            return false;
        }

        public Name Procurar(string nome)
        {
            Name nomeAchado = new CommonName();

            foreach (var nomes in _dados)
            {
                if (nomes.Value == nome) {
                    nomeAchado.name = nomes.Value;
                    nomeAchado.Id = nomes.Key;
                    return nomeAchado;
                }
            }
            return null;
        }

        public void Remove(Guid Id)
        {
            _dados.Remove(Id);
        }


    }
}
