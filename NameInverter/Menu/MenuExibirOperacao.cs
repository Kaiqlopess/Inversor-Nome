using NameInverter.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class MenuExibirOperacao : IMenuExibirOperacao 
    {

        public void MenuAtualizar()
        {
            Console.WriteLine("==ATUALIZAR==");
            Console.Write("Escolha o Nome para Atualizar: ");
        }

        public void MenuNomeAtualizado()
        {
            Console.WriteLine("==ATUALIZAR==");
            Console.Write("Escolha o novo Nome: ");
        }

        public void MenuAdicionar()
        {
            Console.WriteLine("==ADICIONAR==");
            Console.Write("Insira um Nome para o Repositorio: ");
        }

        public void MenuDeletar() {
            Console.WriteLine("==DELETAR==");
            Console.Write("Escolha o Nome para Deletar: ");
        }
    }
}
