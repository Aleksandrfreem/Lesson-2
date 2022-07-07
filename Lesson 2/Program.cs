using System;

namespace BubbleSort
{
    class MySort
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, -13 };
            int temp;
            int firstNum = -1;
            {
                Console.Write("Числа больше 5: ");
            }

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > 5)
                {


                    Console.WriteLine(arr[j] + " ");
                }
            }
            {
                Console.Write("Сортировка:");
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            {


                foreach (var item in arr)
                    Console.WriteLine(item + " ");

            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {

                    if (firstNum == -1)
                    {
                        firstNum = arr[i];
                    }
                    int sum = 0;
                    foreach (int value in arr)
                    {
                        sum += value;
                    }

                    Console.WriteLine("Сумма массива: " + sum);
                    Console.Write("Первый положительный элемент массива: ");
                    foreach (int p in arr) ;
                    Console.WriteLine(i);
                    Console.ReadLine();

                }
            }
        }
    }
}