using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.Menu
{
    public interface IMenuExibirOperacao
    {
        void MenuAtualizar();
        void MenuNomeAtualizado();
        void MenuAdicionar();
        void MenuDeletar();
    }
}
