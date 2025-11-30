using NameInverter.Nome.NomeConcreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.Repositorio.RepositorioSobrenome
{
    public interface IRepositorySobrenome
    {
        void Add(SobrenomeName nome);
        void ToList();
        bool DadosIguais(string nome);
        Name Procurar(Guid IdNome);
        void Remove(SobrenomeName nome);
        void Update(SobrenomeName nome);
    }
}
