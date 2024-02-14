using System;

namespace ejemplos_cicloscombinados
{
    class Program
    {
        static void Main(string[] args)
        {
           // FOR con FOR
           // Cargo edades y saco el promedio de 10 equipos de futbol con 20 jugadores c/u.

        //    int acu,n;
        //    float promedio;
        //    for (int y = 0; y < 10; y++)
        //    {
        //     acu = 0;
        //     for (int x = 0; x < 20; x++)
        //     {
        //         Console.WriteLine("Ingrese la edad del jugador:");
        //         n = int.Parse(Console.ReadLine());
        //         acu += n;
        //     }
        //     promedio = (float) acu / 20;
        //     Console.WriteLine("El promedio de edad del equipo es: " + promedio);
        //    }



           // FOR con WHILE
           // Sigo sacando el promedio de los 10 equipos, pero ahora no se cunatos jug tiene c/u.
           // int con;
        //    for (int x = 0; x < 10; x++)
        //    {
        //     Console.WriteLine("Ingrese la edad:");
        //     n = int.Parse(Console.ReadLine());
        //     acu = 0;
        //     con = 0;
        //     while (n != 0)
        //     {
        //      acu += n;
        //      con ++;
        //      Console.WriteLine("Ingrese la edad:");
        //      n = int.Parse(Console.ReadLine());                
        //     }
        //     promedio = (float) acu / con;
        //     Console.WriteLine("El promedio de edad del equipo es" + promedio);
        //    }



            // WHILE CON FOR
            // Sigo sacando el promedio, ahora se que son 20 jug por equipo, pero no se cuantos equipos son.

        //     Console.WriteLine ("Ingrese 1 para comenzar o 0 para terminar");
        //     n = int.Parse(Console.ReadLine());
        //     while (n != 0)
        //     {
        //         acu = 0;
        //         for (int x = 0; x < 20; x++)
        //         {
        //             Console.WriteLine("Ingrese la edad:");
        //             n = int.Parse(Console.ReadLine());
        //             acu += n;
        //         }
        //         promedio = (float) acu / 20;
        //         Console.WriteLine("El promedio del equipo es: " + promedio);

        //         Console.WriteLine("Ingrese 1 para continuar o 0 para terminar");
        //         n = int.Parse(Console.ReadLine());
        //    }



            // WHILE con WHILE (CORTE DE CONTROL)
            // Sigo sacando los promedios, pero ahora no se ni el número de equipos ni el número de jug de c/u.

            // Console.WriteLine ("Ingrese la edad:");
            // n = int.Parse(Console.ReadLine());
            // while (n > 0)
            // {
            //     acu = 0;
            //     con = 0;
            //     while (n != 0)
            //     {
            //         acu += n;
            //         con ++;
            //         Console.WriteLine("Ingrese la edad:");
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     promedio = (float) acu / con;
            //     Console.WriteLine("El promedio es: " + promedio);

            //     Console.WriteLine("Ingrese una edad para continuar o un negativo/cero para cortar:");
            //     n = int.Parse(Console.ReadLine());

        }
    }
}





                





