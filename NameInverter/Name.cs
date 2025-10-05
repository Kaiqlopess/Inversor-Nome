using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public abstract class Name
    {

        public Guid Id { get; set; }
        public string name { get; set; }
        

        public Name(string name)
        {
            this.name = name;
            this.Id = Guid.NewGuid();   
        }

        

    }
}
