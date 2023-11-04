using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_to_dobre_2
{
    class Mercedes : Car
    {
        public Mercedes(string kategoriaPojazdu, int wagaPojazdu, double pojemnoscSilnika, int mocSilnika, string kolorNadwozia, int liczbaOsi)
            : base(kategoriaPojazdu, wagaPojazdu, pojemnoscSilnika, mocSilnika, kolorNadwozia, liczbaOsi)
        {
            
        }      
    }
}
