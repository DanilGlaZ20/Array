using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Win32.SafeHandles;

namespace Array
{
    class Program
    {
        public static void
            Train() //программа получает количество вагонов и число пассажиров; выводит общее кол-во пассажиров
        {
            Console.Write("Введите кол-во вагонов:");
            int num = Convert.ToInt16(Console.ReadLine()); //кол-во вагонов
            int sum = 0; //кол-во пассажиров в поезде
            int[] array = new int[num];
            Console.WriteLine("Введите кол-во пассажиров в каждом вагоне ");
            for (int i = 0; i < num; i++) //заполнение массива
            {
                array[i] = Convert.ToInt16(Console.ReadLine());
                sum += array[i];
            }

            Console.Write("Кол-во пассажиров в вагонах:");
            for (int j = 0; j < num; j++) Console.Write(array[j] + " ");
            Console.WriteLine();
            Console.WriteLine($"Кол-во пассажиров в поезде:{sum}");
        }

        public static void Common_el() //нахождение общих элементов в 2 массивах
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
                    if (array1[i].Equals(array2[j])) //сравнение 2 массивов
                        Console.WriteLine($"Этот элемент присутствует в обоих массивах - {array1[i]}");
                }
            }

        }

        public static void Rotation() //программа получает массив и кол-во поворотов (поворачивает массив)
        {
            int num = 5;
            int[] arr = new int[num];
            for (int i = 0; i < num; i++) arr[i] = Convert.ToInt16(Console.ReadLine()); //ввод массива
            Console.Write("Введите кол-во поворотов: ");
            int p = Convert.ToInt16(Console.ReadLine()); //кол-во поворотов

            for (int i = 0; i < p; i++)
            {
                int j;
                int tmp = arr[0];
                for (j = 0; j < num - 1; j++)
                {
                    arr[j] = arr[j + 1];

                }

                arr[j] = tmp;
            }



            Console.Write("Перевернутый массив:");
            for (int k = 0; k < num; k++) Console.Write(arr[k] + " ");

        }

        public static void Big_number()
        {
            Console.Write("Введите кол-во элементов в массиве: ");
            int num = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Введите  элементы  массива: ");
            for (int i = 0; i < arr.Length; i++) arr[i] = Convert.ToInt16(Console.ReadLine());
            int tmp = arr[0];
            Console.Write("Отсортированный массив: ");
            for (int i = arr.Length - 1; i>=0;i--)
            {

                if (tmp < arr[i])
                {
                    tmp = arr[i];
                    Console.Write(arr[i] + " ");
                    
                }
                //if (arr[arr.Length - 1] > arr[0]) Console.WriteLine(arr[arr.Length-1]);
                
                
            }

            

        }

        static void Main(string[] args)
            {
                Train();
                Common_el();
                Rotation();
                Big_number();
            }

        

    }
}

