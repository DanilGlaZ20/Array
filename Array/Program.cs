using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Win32.SafeHandles;

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

        public static void Common_el()
        {
            int number = 4;
            String[] array1 = new String[number];
            String[] array2 = new String[number];
            Console.WriteLine("Введите элементы первого масстива ");
            for (int i = 0; i < number; i++) array1[i] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите элементы второго масстива ");
            for (int j = 0; j < number; j++) array2[j] = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (array1[i].Equals(array2[j]))
                        Console.WriteLine($"Этот элемент присутствует в обоих массивах {array1[i]}");
                }
            }

        }

        static void Main(string[] args)
        {
            //Train();
            Common_el();
        }
        
    }
}

