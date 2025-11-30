using NameInverter.CasoDeUso.Contratos.Nome;
using NameInverter.CasoDeUso.Contratos.Sobrenome;
using NameInverter.CasoDeUso.Serviços.Nome;
using NameInverter.CasoDeUso.Serviços.Sobrenome;
using NameInverter.Menu;
using NameInverter.Repositorio;
using NameInverter.Repositorio.RepositorioSobrenome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso
{
    public class InserirNomeCompleto
    {

        private IMenuExibirOperacao _menuExibirOperacao = new MenuExibirOperacao();
        private IAdicionarSobrenome adicionarSobrenome;
        private IAdicionarNome adicionarNome;

        public InserirNomeCompleto()
        {
            var repositorioNome = new RepositoryNome();
            var repositorioSobrenome = new RepositorySobrenome();

            adicionarNome =  new AdicionarNome(repositorioNome);
            adicionarSobrenome = new AdicionarSobrenome(repositorioSobrenome);
        }
     
        public void Inserir() 
        {
            Console.Clear();
            _menuExibirOperacao.MenuAdicionar();
            string nome = Console.ReadLine();

            string[] nomeCompleto = nome.Split(' ');

            if (TratamentoString.TratarString(nomeCompleto[0], nomeCompleto[1]))
            {
                return;
            }

            Guid idNome = adicionarNome.Adicionar(nomeCompleto[0]);

            adicionarSobrenome.Adicionar(nomeCompleto[1], idNome);
        }
    }
}
