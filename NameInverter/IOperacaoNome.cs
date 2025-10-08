using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public interface IOperacaoNome
    {
        string categoria {  get;}
        Name LerNome();
    }
}
