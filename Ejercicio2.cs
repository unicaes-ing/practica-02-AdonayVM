using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica2
{
    class Ejercicio
    {
        static void Main(string[] args)
        {
            string producto;
            double precio, IVA;
            int cantidad;
            double subtotal, total;
            Console.Write("Producto: ");
            producto = Convert.ToString(System.Console.ReadLine());
            Console.Write("Cantidad: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Precio: ");
            precio = Convert.ToDouble(System.Console.ReadLine());
            Console.Clear();
            subtotal = precio * cantidad;
            IVA = subtotal * 0.13;
            total = subtotal + IVA;
            Console.WriteLine("Producto: {0}\nCantidad: {1}\nPrecio: {2:C2}", producto, cantidad, precio);
            Console.WriteLine("");
            Console.WriteLine("Subtotal: {0:C2}", subtotal);
            Console.WriteLine("");
            Console.WriteLine("IVA: {0}", IVA);
            Console.WriteLine("==================================================");
            Console.WriteLine("Total: {0}", total);
            Console.ReadKey();
        }
    }
}
