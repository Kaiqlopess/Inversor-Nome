using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.Nome.NomeConcreto
{
    public class SobrenomeName : Name
    {
        public Guid CommonNameId {  get; set;}
        public CommonName CommonName { get; set; }

        public SobrenomeName(string name) : base(name)
        {
        }
        public SobrenomeName() : base()
        {
        }

        public SobrenomeName(string name, Guid CommonNameId) : base(name)
        {
            this.CommonNameId = CommonNameId;
        }

    }
}
