using NameInverter.CasoDeUso;
using NameInverter.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class DeletarNome : IDeletarNome
    {
        private Repositorio _repositorio;
        private IMenuExibirOperacao _menuExibirOperacao;

        public DeletarNome(Repositorio repositorio) {
            _repositorio = repositorio;
        }

        public void Deletar() {
            _repositorio.Listar();
            Console.WriteLine("---------");

            _menuExibirOperacao.MenuDeletar();
            string nome = LerNome.LerDeletar();

            Name nomeDeletar = _repositorio.Procurar(nome);

            if (nomeDeletar == null) {
                Console.WriteLine("ERRO AO DIGITAR O NOME!");
                Console.ReadLine();
                return;
            }

            _repositorio.Remove(nomeDeletar.Id);
        }

    }
}

