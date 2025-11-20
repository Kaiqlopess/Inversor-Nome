using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.Repositorio
{
    public interface IRepository
    {
        void Add(string nome);
        void ToList();
        bool DadosIguais(string nome);
        Name Procurar(string Nome);
        void Remove(CommonName nome);
        void Update(CommonName nome);
    }
}
