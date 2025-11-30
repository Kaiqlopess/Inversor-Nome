using NameInverter.CasoDeUso.Contratos.Sobrenome;
using NameInverter.Nome.NomeConcreto;
using NameInverter.Repositorio.RepositorioSobrenome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso.Serviços.Sobrenome
{
    public class AdicionarSobrenome : IAdicionarSobrenome
    {
        private readonly IRepositorySobrenome _repositorio;

        public AdicionarSobrenome(IRepositorySobrenome repositorio)
        {
            this._repositorio = repositorio;
        }
        public void Adicionar(string nome, Guid CommonNameId)
        {
            Name name = new SobrenomeName(nome, CommonNameId);

            _repositorio.Add((SobrenomeName)name);
        }
    } 
}
