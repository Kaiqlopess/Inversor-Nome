using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class FuncionalidadeMenu : IFuncionalidadeMenu
    { 
        public void menu(string escolha)
        {
            Repositorio repositorio = new Repositorio();
            IOperacaoNome escolhaOperaçao = null;


            switch (escolha)
            {
                case "1":
                    escolhaOperaçao = new AdicionarNome();
                    break;
                default:
                    break;
            }

            repositorio.ModificarRepositorio(escolhaOperaçao);
        }  

    }
}
