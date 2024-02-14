using System;

namespace ejemplos_cortedecontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            // Corte de control
            // Cada jugador que cargamos de los equipos tiene un legajo, edad y sueldo a ingresar (no sabemos jug ni equipos), agrupados por codigos de equipo y corta con sueldo (-)

            int legajo,edad,codigoEquipo;
            float sueldo;
            int equipoActual;

            Console.WriteLine("Ingrese el legajo:");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad:");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo:");
            sueldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el código de equipo:");
            codigoEquipo = int.Parse(Console.ReadLine());
            // contadores, acumuladores, banderas
            while (sueldo > 0)
            {
                equipoActual = codigoEquipo; // ESENCIA DEL CORTE DE CONTROL !! // más contadores, acumuladores, banderas
                while (codigoEquipo == equipoActual)
                {
                    // aca procesamos ... (max, min, promedios)
                    Console.WriteLine("Ingrese el legajo:");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad:");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo:");
                    sueldo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el código de equipo:");
                    codigoEquipo = int.Parse(Console.ReadLine());
                    // aca podemos mostrar algunos resultados
                }
                //mostrar resultados de c/equipo
            }
            //mostrar resultados de todos los equipos
        }
    }
}
