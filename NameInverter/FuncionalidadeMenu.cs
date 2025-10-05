using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    internal class FuncionalidadeMenu : IFuncionaldiadeMenu
    {
        public void Adicionar()
        {
            Console.Clear();
            Console.WriteLine("==Adicionar==");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();


        }

        public void Atualizar()
        {
            throw new NotImplementedException();
        }

        public void Deletar()
        {
            throw new NotImplementedException();
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }
    }
}
