using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EJERCICIO_1
{

    class TablaHash
    {
        private List<string>[] tabla;
        private int tama;

        public TablaHash(int tama)
        {
            this.tama = tama;
            tabla = new List<string>[tama];
            for (int i = 0; i < tama; i++)
            {
                tabla[i] = new List<string>();
            }
        }

        private int FuncionHash(string cod)
        {
            int suma = 0;
            foreach (char c in cod)
            {
                suma += c; 
            }
            return suma % tama; 
        }

        public void Insertar(string cod)
        {
            int indice = FuncionHash(cod);
            tabla[indice].Add(cod);
        }

        public void MostrarTabla()
        {
            for (int i = 0; i < tama; i++)
            {
                Console.Write($"Índice {i}: ");
                foreach (var cod in tabla[i])
                {
                    Console.Write(cod + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            TablaHash tablaHash = new TablaHash(7);

            string[] codSeguimiento = { "MZ123", "QK456", "PL789", "MN321", "QK654", "PL987", "MZ321" };
            foreach (string cod in codSeguimiento)
            {
                tablaHash.Insertar(cod);
            }

            Console.WriteLine("Contenido de la tabla hash:");
            tablaHash.MostrarTabla();
        }
    }
}
