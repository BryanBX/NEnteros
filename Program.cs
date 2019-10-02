using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEnteros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que permita ingresar n números enteros por el teclado y se desea conocer:
                a) La cantidad de números positivos.
                b) La cantidad de números negativos.
                c) La cantidad de números pares.
                d) La cantidad de números impares*/

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("             Cantidad de Numeros               ");
            Console.WriteLine("");

            double Numero = 0, Cantidad = 0, Ciclo = 1, Negativo = 0, Positivo = 0, Par = 0, Impar = 0;
            Console.Write("Ingrese cantidad de numeros: ");
            Cantidad = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite los Numeros\n");

            do
            {
                Console.Write("Numero {0}: ",Ciclo);
                Numero = double.Parse(Console.ReadLine());
                if (Numero > 0)
                    Positivo++;
                if (Numero < 0)
                    Negativo++;
                if (Numero  % 2==0)
                    Par++;
                if (Numero %2!=0)
                    Impar++;
                Ciclo++;
            } while (Ciclo<=Cantidad);

            Console.WriteLine("\nA) Numeros Positivos: {0}",Positivo);
            Console.WriteLine("B) Numeros Negativos: {0}", Negativo);
            Console.WriteLine("C) Numeros Pares: {0}", Par);
            Console.WriteLine("D) Numeros Impares: {0}", Impar);
            Console.ReadKey();
        }
    }
}
