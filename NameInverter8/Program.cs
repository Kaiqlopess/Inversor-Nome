
using NameInverter;
using System;

namespace NameInverter8
{
    public class Program
    {
        static void Main(string[] args)
        {

            var funcao = new FuncionalidadeMenu();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==Menu==");
                Console.WriteLine("1.Adicionar");
                Console.WriteLine("2.Atualizar");
                Console.WriteLine("3.Deletar");
                Console.WriteLine("4.Listar");
                Console.WriteLine("5.sair");
                Console.Write("Escolha: ");
                string escolha = Console.ReadLine();

                if (escolha == "5")
                {
                    break;
                }

                funcao.menu(escolha);

            }




        }
    }
}