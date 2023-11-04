using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samochod
{
    class Car : IPojazd
    {
        public string KategoriaPojazdu { get; set; }
        public int WagaPojazdu { get; set; }
        public double PojemnoscSilnika { get; set; }
        public int MocSilnika { get; set; }
        public string KolorNadwozia { get; set; }
        public int LiczbaOsi { get; set; }

        public Car(string kategoriaPojazdu, int wagaPojazdu, double pojemnoscSilnika, int mocSilnika, string kolorNadwozia, int liczbaOsi)
        {
            KategoriaPojazdu = kategoriaPojazdu;
            WagaPojazdu = wagaPojazdu;
            PojemnoscSilnika = pojemnoscSilnika;
            MocSilnika = mocSilnika;
            KolorNadwozia = kolorNadwozia;
            LiczbaOsi = liczbaOsi;
        }
        public void WyswietlSpecyfikacje()
        {
            Console.WriteLine("To jest specyfikacja samochodu: ");
            Console.WriteLine("Kategoria pojazdu: " + KategoriaPojazdu);
            Console.WriteLine("Waga pojazdu: " + WagaPojazdu + "kg");
            Console.WriteLine("Pojemnosc silnika: " + PojemnoscSilnika + "cm3");
            Console.WriteLine("Moc silnika: " + MocSilnika + "KM");
            Console.WriteLine("Kolor nadwozia: " + KolorNadwozia);
            Console.WriteLine("Liczba osi: " + LiczbaOsi);
        }
    }
}
