using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Sueldos
{
    class Sueldos
    {
        private float[] turnoM; //Declaramos un vector para el turno mañana
        private float[] turnoT; //Declaramos un vector para el turno tarde
        public void Cargar()
        {
            string linea;
            turnoM = new float[6]; //Asignamos al vector una de longitud 4
            turnoT = new float[3]; //Asignamos al vector una de longitud 4
            Console.WriteLine("Sueldos de empleados del turno de la mañana.");
            for (int f = 0; f < 6; f++)
            {
                Console.Write("Ingrese sueldo " + (f + 1) + ": ");
                linea = Console.ReadLine();
                turnoM[f] = float.Parse(linea); //Asignamos valores al vector turno mañana
            }
            Console.WriteLine("Sueldos de empleados del turno de la tarde.");
            for (int f = 0; f < 3; f++)
            {
                Console.Write("Ingrese sueldo " + (f + 1) + ": ");
                linea = Console.ReadLine();
                turnoT[f] = float.Parse(linea); //Asignamos valores al vector turno tarde
            }
        }
        public void CalcularGastos()
        {
            float man = 0;
            float tar = 0;
            for (int f = 0; f < 8; f++)
            {
                man = man + turnoM[f]; //Realizamos la suna de los valores del vector turno Mañana
                tar = tar + turnoT[f]; //Realizamos la suna de los valores del vector turno Tarde
            }
            Console.WriteLine("Total de gastos del turno de la mañana:" + man);
            Console.WriteLine("Total de gastos del turno de la tarde:" + tar);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Sueldos pv = new Sueldos();
            pv.Cargar();
            pv.CalcularGastos();
        }
    }
}