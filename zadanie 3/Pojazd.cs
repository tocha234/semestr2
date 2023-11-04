using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samochod
{
    interface IPojazd
    {
        string KategoriaPojazdu { get; set; }
        int WagaPojazdu { get; set; }
        double PojemnoscSilnika { get; set; }
        int MocSilnika { get; set; }
        string KolorNadwozia { get; set; }
        int LiczbaOsi { get; set; }
        void WyswietlSpecyfikacje(); 
    }
}
