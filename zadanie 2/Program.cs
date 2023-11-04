using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_to_dobre_2
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Mercedes mercedesBenz = new Mercedes("Sedan", 2300, 6000, 200, "Czarny", 2);
            mercedesBenz.WyswietlSpecyfikacje();
            Console.ReadLine();
        }
    }
    
} 
