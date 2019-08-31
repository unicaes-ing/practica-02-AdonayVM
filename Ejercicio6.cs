using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica2
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Now;
            Console.WriteLine("Hoy es {0} y son las {1}", hoy.ToLongDateString(), hoy.ToShortTimeString());
            Console.ReadKey();
        }
    }
}
