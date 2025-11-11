using NameInverter.CasoDeUso;
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
            var repositorio = new Repository();

            switch (escolha)
            {
                case "1":
                    IAdicionarNome nomeAdicionado = new AdicionarNome(repositorio);
                    nomeAdicionado.Adicionar();
                    break;
                case "2":
                    IAtualizarNome nomeAtualizado = new AtualizarNome(repositorio);
                    nomeAtualizado.Atualizar();
                    break;
                case "3":
                    IDeletarNome nomeDeletado = new DeletarNome(repositorio);
                    nomeDeletado.Deletar();
                    break;
                case "4":
                    IListarNome listarNome = new ListarNome(repositorio);
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
