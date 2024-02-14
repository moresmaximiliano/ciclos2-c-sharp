using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista
            int n,con;
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                con = 0;
                while (n != 0)
                {
                    con ++;
                    Console.WriteLine("Ingrese un número:");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Esta lista tiene " + con + " números");
                Console.WriteLine("Ingrese un número positivo para continuar con la carga o negativo/cero para terminar:");
                n = int.Parse(Console.ReadLine());
            }

            // Otra forma de hacerlo es:
            // int n,con,numeroGrupo = 0;
            // do
            // {
            //     numeroGrupo ++;
            //     con = 0;
            //     n = int.Parse(Console.ReadLine());
            //     while (n > 0)
            //     {
            //         con ++;
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     Console.WriteLine("La lista número " + numeroGrupo + " tiene " + con + " números ingresados");
            // } while (n >= 0);
        }
    }
}
