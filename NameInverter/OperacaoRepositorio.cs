using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class OperacaoRepositorio
    {
        public void ModificarRepositorio(IOperacaoNome tipoOperaçao)
        {
            var repositorio = Repositorio.Instacia;
            

            if (tipoOperaçao.categoria == "adicionar")
            {
                Name nome = tipoOperaçao.LerNome();

                repositorio.Add(nome.Id, nome.name);

                return;
            }

            if (tipoOperaçao.categoria == "listar")
            {
                Console.Clear();
                Console.WriteLine("==LISTAR==");
                repositorio.Listar();

                Console.ReadLine();
            }

            if(tipoOperaçao.categoria == "deletar")
            {
                Console.Clear();
                Console.WriteLine("==Deletar==");
                repositorio.Listar();

                Name nome = tipoOperaçao.LerNome();

                repositorio.Remove(nome.Id);
            }

            if(tipoOperaçao.categoria == "atualizar")
            {
                Console.Clear();
                Console.WriteLine("==Atualizar==");
                repositorio.Listar();

                Name nome = tipoOperaçao.LerNome();

                Console.Write("Novo Nome: ");
                string novoNome = Console.ReadLine();

                nome.name = novoNome;

                repositorio.Atualizar(nome.Id, nome.name);

            }
            
        } 
    }
}
