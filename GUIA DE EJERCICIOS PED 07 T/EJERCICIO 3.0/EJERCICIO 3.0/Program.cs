using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            hospital.AgregarPaciente(new Paciente("Ana", 3));
            hospital.AgregarPaciente(new Paciente("Luis", 1));
            hospital.AgregarPaciente(new Paciente("Sofía", 2));
            hospital.AgregarPaciente(new Paciente("Marta", 1));
            hospital.AgregarPaciente(new Paciente("Pedro", 2));

            Console.WriteLine("Orden de atención:");

            Paciente paciente;
            while ((paciente = hospital.AtenderPaciente()) != null)
            {
                Console.WriteLine($"Se esta atendiendo al  paciente: {paciente.Nombre}, Pasientes por prioridad: {paciente.Prio}");
            }
        }
    }

    public class Paciente
    {
        public string Nombre { get; set; }
        public int Prio { get; set; }
        public Paciente(string nombre, int prio)
        {
            Nombre = nombre;
            Prio = prio;
        }
    }

    public class Hospital
    {
        private SortedList<int, Queue<Paciente>> prioCola = new SortedList<int, Queue<Paciente>>();

        public void AgregarPaciente(Paciente paciente)
        {
            if (!prioCola.ContainsKey(paciente.Prio))
            {
                prioCola[paciente.Prio] = new Queue<Paciente>();
            }

            prioCola[paciente.Prio].Enqueue(paciente);
        }

        public Paciente AtenderPaciente()
        {
            foreach (var prioridad in prioCola.Keys)
            {
                if (prioCola[prioridad].Count > 0)
                {
                    return prioCola[prioridad].Dequeue(); 
                }
            }
            return null;
        }
    }
}