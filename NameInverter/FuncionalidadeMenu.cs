using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    internal class FuncionalidadeMenu : IFuncionaldiadeMenu
    {
        public Name Adicionar()
        {
            Console.Clear();
            Console.WriteLine("==Adicionar==");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Name name = new CommonName(nome);


            return name;
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
