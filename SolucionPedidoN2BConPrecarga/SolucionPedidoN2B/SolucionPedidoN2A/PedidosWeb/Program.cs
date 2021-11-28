using System;
using PedidoDominio;

namespace PedidosWeb
{
    class Program
    {
        private static Restaurant miRestaurant = new Restaurant();
        static void Main(string[] args)
        {
            Console.WriteLine(miRestaurant.MostrarPlatos());
            Console.ReadKey();
        }
    }
}
