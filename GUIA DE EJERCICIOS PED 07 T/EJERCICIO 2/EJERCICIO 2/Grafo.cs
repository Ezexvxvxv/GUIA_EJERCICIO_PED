using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    using System;
    using System.Collections.Generic;

    public class Grafo
    {
        private Dictionary<string, List<(string, int)>> adjList;

        public Grafo()
        {
            adjList = new Dictionary<string, List<(string, int)>>();
        }

        public void AgregarAris(string origen, string destino, int peso)
        {
            if (!adjList.ContainsKey(origen))
                adjList[origen] = new List<(string, int)>();

            if (!adjList.ContainsKey(destino))
                adjList[destino] = new List<(string, int)>();

            adjList[origen].Add((destino, peso));
            adjList[destino].Add((origen, peso)); 
        }

        public (Dictionary<string, int>, Dictionary<string, string>) Dijkstra(string inicio)
        {
            var dis = new Dictionary<string, int>();
            var visitados = new HashSet<string>();
            var colaPrio = new SortedSet<(int, string)>();
            var prev = new Dictionary<string, string>(); 
            foreach (var nodo in adjList.Keys)
            {
                dis[nodo] = int.MaxValue;
            }
            dis[inicio] = 0;
            colaPrio.Add((0, inicio));

            while (colaPrio.Count > 0)
            {
                var (disActual, nodoActual) = colaPrio.Min;
                colaPrio.Remove(colaPrio.Min);

                if (visitados.Contains(nodoActual))
                    continue;

                visitados.Add(nodoActual);

                foreach (var (vecino, peso) in adjList[nodoActual])
                {
                    int nuevaDistancia = disActual + peso;

                    if (nuevaDistancia < dis[vecino])
                    {
                        colaPrio.Remove((dis[vecino], vecino));
                        dis[vecino] = nuevaDistancia;
                        prev[vecino] = nodoActual;
                        colaPrio.Add((nuevaDistancia, vecino));
                    }
                }
            }

            return (dis, prev);
        }

        public List<string> ObtenerRut(string inicio, string destino, Dictionary<string, string> previos)
        {
            var ruta = new List<string>();
            var actual = destino;

            while (actual != null)
            {
                ruta.Insert(0, actual);
                previos.TryGetValue(actual, out actual);
            }

            if (ruta[0] != inicio) 
                return new List<string>();

            return ruta;
        }
    }
}
