using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class DeletarNome : IOperacaoNome
    {
        private Repositorio _repositorio;


        public DeletarNome(Repositorio repositorio) {
            _repositorio = repositorio;
        }

        public void Executar() {
            _repositorio.Listar();
            Console.WriteLine("---------");

            MenuExibirOperacao.MenuDeletar();
            string nome = LerNome.LerDeletar();

            Name nomeDeletar = _repositorio.Procurar(nome);

            if (nomeDeletar == null) {
                Console.WriteLine("ERRO AO DIGITAR O NOME!");
                Console.ReadLine();
                return;
            }

            _repositorio.Remove(nomeDeletar.Id);  
        }



        /*public string categoria => "deletar";

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
        }*/

     
    }
}
