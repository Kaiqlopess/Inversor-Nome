using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class AtualizarNome : IOperacaoNome
    {
        private Repositorio _repositorio;

        public AtualizarNome(Repositorio repositorio) 
        {
            this._repositorio = repositorio; 
        }

        public void Executar()
        {
            Console.Clear();

            _repositorio.Listar();
            Console.WriteLine("------------------");

            MenuExibirOperacao.MenuAtualizar();
            string nome = LerNome.LerAtualizar();
            Name nomeAtualizar = _repositorio.Procurar(nome);

            if (nomeAtualizar == null)
            {
                Console.WriteLine("ERRO AO DIGITAR O NOME!");
                Console.ReadLine();
                return;
            }

            Console.Clear();
            MenuExibirOperacao.MenuNomeAtualizado();
            nomeAtualizar.name = LerNome.LerAtualizar();

            _repositorio.Atualizar(nomeAtualizar.Id, nomeAtualizar.name);
        }
    }



       /* public string categoria => "atualizar";

        public Name LerNome()
        {
            var repositorio = Repositorio.Instacia;


            Console.Write("Escolha o nome: ");
            string nome = Console.ReadLine();

            while (repositorio.Procurar(nome) == null)
            {
                Console.Write("Escolha o nome de novo: ");
                nome = Console.ReadLine();
            }



            return repositorio.Procurar(nome);
        }

    }*/
}
