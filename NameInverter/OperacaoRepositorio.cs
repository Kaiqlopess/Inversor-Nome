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
                repositorio.list();

                Console.ReadLine();
            }
            
        } 
    }
}
