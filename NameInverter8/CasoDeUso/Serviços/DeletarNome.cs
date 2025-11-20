using NameInverter.CasoDeUso;
using NameInverter.Menu;
using NameInverter.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class DeletarNome : IDeletarNome
    {
        private Repository _repositorio;
        private IMenuExibirOperacao _menuExibirOperacao = new MenuExibirOperacao();
        

        public DeletarNome(Repository repositorio) {
            this._repositorio = repositorio;
        }

        public void Deletar() {
            Console.Clear();
            _repositorio.ToList();
            Console.WriteLine("---------");

            _menuExibirOperacao.MenuDeletar();
            string nome = Console.ReadLine();

            Name nomeDeletar = _repositorio.Procurar(nome);

            if (nomeDeletar == null) {
                Console.WriteLine("ERRO AO DIGITAR O NOME!");
                Console.ReadLine();
                return;
            }

            _repositorio.Remove((CommonName)nomeDeletar);
        }

    }
}

