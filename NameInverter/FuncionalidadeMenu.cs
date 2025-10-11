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
            OperacaoRepositorio repositorio = new OperacaoRepositorio();
            IOperacaoNome escolhaOperaçao = null;


            switch (escolha)
            {
                case "1":
                    escolhaOperaçao = new AdicionarNome();
                    break;
                case "2":
                    escolhaOperaçao = new AtualizarNome();
                    break;
                case "3":
                    escolhaOperaçao = new DeletarNome();
                    break;
                case "4":
                    escolhaOperaçao = new ListarNome();
                    break;
                default:
                    Console.WriteLine("Opçao nao existe!");
                    Console.WriteLine("aperte ENTER!");
                    Console.ReadLine();
                    return;
            }


            repositorio.ModificarRepositorio(escolhaOperaçao);




        }  

    }
}
