using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194
{
    class Asiento
    {
        string NumSerie { get; set; }
        Cinturon _cinturon;

        public Asiento()
        {
            _cinturon = new Cinturon();
        }
    }
}
