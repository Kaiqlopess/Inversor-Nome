using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.Repositorio.RepositorioNome
{
    public interface IRepositoryNome
    {
        void Add(CommonName nome);
        List<CommonName> ToList();
        List<CommonName> TolistNameComplete();
        bool DadosIguais(string nome);
        Name Procurar(Guid Nome);
        void Remove(CommonName nome);
        void Update(CommonName nome);
    }
}
