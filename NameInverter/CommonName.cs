using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class CommonName : Name
    {
        public Guid id {  get; }
        public string nome { get; set; }

        public CommonName(string name) : base(name)
        {
            this.id = Guid.NewGuid(); 
            this.name = name;
        }
    }
}
