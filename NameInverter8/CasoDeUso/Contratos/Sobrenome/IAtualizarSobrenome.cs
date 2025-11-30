using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso.Contratos.Sobrenome
{
    public interface IAtualizarSobrenome
    {
        void Atualizar(string Nome, Guid IdNome);
    }
}
