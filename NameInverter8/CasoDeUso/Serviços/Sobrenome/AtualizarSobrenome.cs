using NameInverter.Nome.NomeConcreto;
using NameInverter.Repositorio.RepositorioSobrenome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso.Serviços.Sobrenome
{
    public class AtualizarSobrenome
    {
        private IRepositorySobrenome _repositorioSobrenome = new RepositorySobrenome();
        public void Atualizar(string Nome, Guid IdNome)
        {
            var sobrenomeAtualizar = _repositorioSobrenome.Procurar(IdNome);

            sobrenomeAtualizar.name = Nome;

            _repositorioSobrenome.Update((SobrenomeName)sobrenomeAtualizar);
        }
    }
}
