using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar en pantalla cuantos de esos números son primos.

            int n,conPrimos = 0,con;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                con = 0;
                for (int y = 1; y <= n; y++)
                {
                    if (n % y == 0)
                    {
                        con ++;
                    }
                }
                if (con == 2)
                {
                    conPrimos ++;
                }
            }
                Console.WriteLine(conPrimos + " de los números que ingresaste son primos");
        }
    }
}
