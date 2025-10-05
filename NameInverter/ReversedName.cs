using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class ReversedName : Name
    {
        public string name { get; set; }
        public ReversedName(string name) : base(name)
        {
            this.name = name;
        }


        public void ReverseName()
        {
            string[] words = name.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write($"{words[i]} ");
            }
        }
    }
}
