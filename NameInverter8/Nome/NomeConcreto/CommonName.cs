using NameInverter.Nome.NomeConcreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class CommonName : Name
    {
        public SobrenomeName Sobrenome { get; set; }
        public CommonName(string name) : base(name)
        {
        }
        public CommonName() : base()
        {
        }
    }
}
