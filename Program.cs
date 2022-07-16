using System;

namespace T05Ejercicio11
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10];
            int suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Añada el " + (i + 1) + "º valor: ");
                int valor = Convert.ToInt32(Console.ReadLine());
                array[i] = valor;
                suma += valor;
            }
            //Para la suma también se puede utilizar el método Sum
            //de System.Linq
            Console.WriteLine("La suma de todos los valores es: " + suma);
        }
    }
}