using System;

namespace Práctica2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Ingrese su nombre:");
            nombre = Convert.ToString(System.Console.ReadLine());
            nombre = nombre.Replace("a", "#").Replace("e", "%").Replace("i", "$").Replace("o", "?").Replace("u", "*");
            Console.WriteLine("Su nombre modificado es: {0}", nombre);
            Console.ReadKey();
        }
    }
}
