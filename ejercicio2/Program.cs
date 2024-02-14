using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

            // -El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // -Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            bool banOrden;
            int conOrden = 0,minimo,con,impares,n,posMayorPorcentaje = 0;
            float porcentajeImpares, mayorPorcentajeImp = 0;
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                minimo = n; 
                banOrden = true; 
                con = 0; 
                impares = 0;
                    while (n != 0)
                    {
                        con ++;
                        if (n % 2 != 0)
                            impares ++;
                        if (n <= minimo)
                            minimo = n;
                        else
                            banOrden = false;    
                        Console.WriteLine("Ingrese un número:");
                        n = int.Parse(Console.ReadLine());
                    }
                        porcentajeImpares = ((float)impares / con) * 100;
                        if (porcentajeImpares > mayorPorcentajeImp)
                        {
                            mayorPorcentajeImp = porcentajeImpares;
                            posMayorPorcentaje = x + 1;
                        }
                
                        if (banOrden){
                        conOrden ++;
                        }

            }
            Console.WriteLine("El número del grupo con mayor porcentaje de números impares es el " + posMayorPorcentaje + ", con un porcentaje de impares del: " + mayorPorcentajeImp + " %.");
            Console.WriteLine(conOrden + " de los grupos ingresados estan ordenados de mayor a menor.");   
            // tambien podemos hacerlo poniendo duoble en vez de float a las 2 variables y evitar poner el float entre parentesis
        }

    }
}
                

