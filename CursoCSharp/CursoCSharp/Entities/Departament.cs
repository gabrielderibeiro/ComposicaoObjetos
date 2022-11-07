using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Entities
{
    class Departament
    {
        public string Name { get; set; }

        public Departament()
        {

        }

        public Departament(string name)
        {
            this.Name = name;
        }

    }
}
