using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public interface IFuncionaldiadeMenu
    {
        Dictionary<Guid, string> Adicionar(Dictionary<Guid, string> dicionario);
        Dictionary<Guid, string> Atualizar(Dictionary<Guid, string> dicionario); 
        void Deletar();
        void Listar(Dictionary<Guid, string> dicionario);
    }
}
