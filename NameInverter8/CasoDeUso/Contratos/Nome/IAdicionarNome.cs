using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso.Contratos.Nome
{
    public interface IAdicionarNome
    {
        Guid Adicionar(string nome);
    }
}
