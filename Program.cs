using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace Lesson5_15_08_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 таск
            Console.WriteLine("Введите размер массива");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите {N1} числа");
            int[] array1 = new int[N1];
            
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int min = array1[0];
            int max = array1[0];
            int sum=0;
            int ave = 0;
            for (int i=0; i< array1.Length;i++)
            {
                min = Math.Min(min, array1[i]);
                max = Math.Max(max, array1[i]);
                sum = sum + array1[i];
                ave = sum / N1;
                if (array1[i] % 2 != 0)
                {
                    Console.WriteLine( $"Нечетный {array1[i]}");
                   
                }
            }
            {
                Console.WriteLine($"Мин {min}, Макс {max},Сумма {sum}, Сред {ave}");
            }
            // 2 таск
            Console.WriteLine("Введите размер массива");
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите {N2} числа");
            int[] array3 = new int[N2];
            
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int j = array3.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(array3[j]);
            }
            
            // 3 таск
            Console.WriteLine("Введите размер массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            Console.WriteLine($"Введите {N} числа");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите индекс массива");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите размер второго массива");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int [count];
            foreach (int i in array2)
            {
                if (index + i < N)
                {
                    array2[i] = i + index;
                    index++;
                    Console.WriteLine(array2[i]);
                }
                else
                {
                    array2[i] = 1;
                    Console.WriteLine(array2[i]);
                }
            }
        }
    }
}