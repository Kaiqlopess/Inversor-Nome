using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class Repositorio
    {
        public Dictionary<Guid, string> ModificarRepositorio(IOperacaoNome tipoOperaçao)
        {
            Dictionary<Guid, string> repositorio = new Dictionary<Guid, string>();

            if (tipoOperaçao.categoria == "adicionar")
            {
                Name nome = tipoOperaçao.LerNome();

                repositorio.Add(nome.Id, nome.name);

                return repositorio;
            }
            
            return repositorio;
        } 
    }
}
