using System;
using System.Diagnostics.CodeAnalysis;

namespace Array
{
    class Program
    {
        public  static void Train()
        {   Console.Write("Введите кол-во вагонов:");
            int num = Convert.ToInt16(Console.ReadLine());
            int sum = 0;
            int[] array = new int[num];
            Console.WriteLine("Введите кол-во пассажиров в каждом вагоне ");
            for (int i = 0; i < num; i++)
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
                sum += array[i];
            }
            Console.Write("Кол-во пассажиров в вагонах:");
            for (int j = 0; j < num; j++) Console.Write(array[j]+" ");
            Console.WriteLine();
            Console.WriteLine($"Кол-во пассажиров в поезде:{sum}");
        }

        static void Main(string[] args)
        {
            Train();
        }
        
    }
}

