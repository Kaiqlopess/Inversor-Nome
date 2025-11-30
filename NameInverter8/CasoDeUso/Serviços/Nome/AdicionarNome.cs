using NameInverter.CasoDeUso.Contratos.Nome;
using NameInverter.CasoDeUso.Contratos.Sobrenome;
using NameInverter.Menu;
using NameInverter.Nome.NomeConcreto;
using NameInverter.Repositorio;
using NameInverter.Repositorio.RepositorioNome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace NameInverter.CasoDeUso.Serviços.Nome
{
    public class AdicionarNome : IAdicionarNome
    {
        private RepositoryNome _repositorio;

        public AdicionarNome(RepositoryNome repositorio)
        {
            this._repositorio = repositorio;
        }
        
        public Guid Adicionar(string nome)
        {   
            Name name = new CommonName(nome);

            this._repositorio.Add((CommonName)name);

            return name.Id;
        }

    
    }
}
