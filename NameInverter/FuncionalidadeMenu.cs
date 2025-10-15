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

            switch (escolha)
            {
                case "1":
                    IOperacaoNome nomeAdicionado = new AdicionarNome(repositorio);
                    nomeAdicionado.Executar();
                    break;
                case "2":
                    IOperacaoNome nomeAtualizado = new AtualizarNome(repositorio);
                    nomeAtualizado.Executar();
                    break;
                case "3":
                    IOperacaoNome nomeDeletado = new DeletarNome(repositorio);
                    nomeDeletado.Executar();
                    break;
                case "4":
                    IOperacaoNome listarNome = new ListarNome(repositorio);
                    listarNome.Executar();
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
