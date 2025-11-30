using NameInverter.CasoDeUso.Contratos.Nome;
using NameInverter.CasoDeUso.Contratos.Sobrenome;
using NameInverter.CasoDeUso.Serviços.Sobrenome;
using NameInverter.Menu;
using NameInverter.Repositorio;
using NameInverter.Repositorio.RepositorioNome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso.Serviços.Nome
{
    public class AtualizarNome : IAtualizarNome
    {
        private IRepositoryNome _repositorio = new RepositoryNome();
        private IMenuExibirOperacao _menuExibirOperacao = new MenuExibirOperacao();
        private AtualizarSobrenome _atualizarSobrenome = new AtualizarSobrenome();


        public void Atualizar(string Nome, Guid IdNome)
        {

            Name nomeAtualizar = _repositorio.Procurar(IdNome);

            if (nomeAtualizar == null)
            {
                Console.WriteLine("ERRO AO DIGITAR O Id do NOME!");
                Console.ReadLine();
                return;
            }

            nomeAtualizar.name = Nome;

            _repositorio.Update((CommonName)nomeAtualizar);
        }
    }
}
