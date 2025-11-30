using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso.Contratos.Nome
{
    public interface IAtualizarNome
    {
        void Atualizar(string Nome, Guid IdNome);
    }
}
