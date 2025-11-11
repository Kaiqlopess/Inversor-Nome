using NameInverter.CasoDeUso;
using NameInverter.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class AtualizarNome : IAtualizarNome
    {
        private Repository _repositorio;
        private IMenuExibirOperacao _menuExibirOperacao = new MenuExibirOperacao();

        public AtualizarNome(Repository repositorio) 
        {
            this._repositorio = repositorio; 
        }

        public void Atualizar()
        {
            Console.Clear();
            _repositorio.ToList();
            Console.WriteLine("------------------");

            _menuExibirOperacao.MenuAtualizar();
            string nome = Console.ReadLine();

            Name nomeAtualizar = _repositorio.Procurar(nome);

            if (nomeAtualizar == null)
            {
                Console.WriteLine("ERRO AO DIGITAR O NOME!");
                Console.ReadLine();
                return;
            }

            Console.Clear();
            _menuExibirOperacao.MenuNomeAtualizado();
            nomeAtualizar.name = Console.ReadLine();

            _repositorio.Atualizar((CommonName)nomeAtualizar);
        }
    }
}
