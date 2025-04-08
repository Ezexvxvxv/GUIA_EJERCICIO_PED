using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Grafo grafo = new Grafo();

                grafo.AgregarAris("A", "B", 5);
                grafo.AgregarAris("A", "C", 2);
                grafo.AgregarAris("B", "C", 1);
                grafo.AgregarAris("B", "D", 3);
                grafo.AgregarAris("C", "D", 4);
                grafo.AgregarAris("D", "E", 2);

                var (distancias, previos) = grafo.Dijkstra("A");

                var ruta = grafo.ObtenerRut("A", "E", previos);

                Console.WriteLine($"La distancia más corta desde A hasta E es: {distancias["E"]} kilómetros.");
                Console.WriteLine("La ruta más corta es: " + string.Join(" -> ", ruta));
        }
        
    }
}
