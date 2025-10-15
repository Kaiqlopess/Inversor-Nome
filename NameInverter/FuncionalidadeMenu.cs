using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class FuncionalidadeMenu
    { 

        public void menu(string escolha)
        {
            var repositorio = Repositorio.Instacia;

            string nome;

            switch (escolha)
            {
                case "1":
                    MenuExibirOperacao.MenuAdicionar();
                    nome = LerNome.LerAdicionar();
                    var nomeAdicionado = new AdicionarNome(repositorio);
                    nomeAdicionado.Adicionar(nome);
                    break;
                case "2":
                    MenuExibirOperacao.MenuAtualizar();
                    nome = LerNome.LerAtualizar();
                    var nomeAtualizado = new AtualizarNome(repositorio);
                    nomeAtualizado.Atualizar(nome);
                    break;
                case "3":
                    MenuExibirOperacao.MenuDeletar();
                    nome = LerNome.LerDeletar();
                    var nomeDeletado = new DeletarNome(repositorio);
                    nomeDeletado.Deletar(nome);
                    break;
                case "4":
                    var listarNome= new ListarNome(repositorio);
                    listarNome.Listar();
                    break;
                default:
                    Console.WriteLine("Opçao nao existe!");
                    Console.WriteLine("aperte ENTER!");
                    Console.ReadLine();
                    return;
            }
        }  

    }
}
