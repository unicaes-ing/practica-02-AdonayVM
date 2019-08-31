using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica2
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            double precio, total;
            int numero;
            DateTime inicio;
            DateTime fin;

            Console.WriteLine("Número de teléfono: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Inicio de la llamada:");
            inicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Finalización de la llamada:");
            fin = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Costo por minuto de la llamada:");
            precio = Convert.ToDouble(Console.ReadLine());
            total = precio * fin.Subtract(inicio).TotalMinutes;
            Console.Clear();
            Console.WriteLine("Hora de inicio:" );
            Console.WriteLine(inicio.ToString("HH:mm"));
            Console.WriteLine("Hora de finalización de la llamada:");
            Console.WriteLine(fin.ToString("HH:mm"));
            Console.WriteLine("Duración de la llamada:");
            Console.WriteLine(fin.Subtract(inicio).TotalMinutes + " minutos");
            Console.WriteLine("\nTOTAL A PAGAR:");
            Console.WriteLine("{0:C2}", total);
            Console.ReadKey();
        }
    }
}
