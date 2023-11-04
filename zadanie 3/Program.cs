using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samochod
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Car Mercedes = new Car("Sedan", 1900, 6000, 500, "Czarny", 2);
            Mercedes.WyswietlSpecyfikacje();
            Console.ReadLine();
        }
    }
    
}


