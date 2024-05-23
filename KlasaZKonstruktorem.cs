using System;
using System.Collections.Generic;
using System.Text;

namespace Konstruktory
{
    class KlasaZKonstruktorem
    {
        private KlasaZKonstruktorem()
        {
            Console.WriteLine("Nic nie podano!");
        }
        private KlasaZKonstruktorem(string tekstDoKonsoli)
        {
            Console.WriteLine(tekstDoKonsoli);
        }

        public static KlasaZKonstruktorem Metoda()
        {
            return new KlasaZKonstruktorem();
        }

    }
}
