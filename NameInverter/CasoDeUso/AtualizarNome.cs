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
        private Repositorio _repositorio;
        private IMenuExibirOperacao _menuExibirOperacao;
        public AtualizarNome(Repositorio repositorio) 
        {
            this._repositorio = repositorio; 
        }

        public void Atualizar()
        {
            Console.Clear();

            _repositorio.Listar();
            Console.WriteLine("------------------");

            _menuExibirOperacao.MenuAtualizar();
            string nome = LerNome.LerAtualizar();
            Name nomeAtualizar = _repositorio.Procurar(nome);

            if (nomeAtualizar == null)
            {
                Console.WriteLine("ERRO AO DIGITAR O NOME!");
                Console.ReadLine();
                return;
            }

            Console.Clear();
            _menuExibirOperacao.MenuNomeAtualizado();
            nomeAtualizar.name = LerNome.LerAtualizar();

            _repositorio.Atualizar(nomeAtualizar.Id, nomeAtualizar.name);
        }
    }
}
