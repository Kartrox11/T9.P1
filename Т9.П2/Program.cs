using System;

namespace Т9.П2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-й способ

            //Console.Write("Размер массива = ");
            //byte size = byte.Parse(Console.ReadLine());
            //int k = 0;
            //int[] array = new int[size];
            //Random rand = new Random();
            //for(int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rand.Next(-5,5);
            //    Console.WriteLine($"array[{i}] = {array[i]}");
            //}
            //for(int j = 0; j < array.Length; j++)
            //{
            //    if (array[j] > 0) k++;
            //}
            //Console.WriteLine($"k = {k}");

            //2-й способ

            Console.Write("Размер массива = ");
            byte size = byte.Parse(Console.ReadLine());
            int k = 0;
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-5, 5);
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
            foreach(int el in array)
            {
                if (el > 0) k++;
            }
            Console.WriteLine($"Количество положит. чисел = {k}");
        }
    }
}
