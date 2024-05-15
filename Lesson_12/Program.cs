using System;

namespace Lesson_12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 12, -12, -2, 1, -53, 32, 135, 23 };
            var (positiv, negativ) = PositivNegativ(arr);
            Console.WriteLine($"Положительных {positiv}, Отрицательных {negativ}");
            int[] fibo = Fibonachi(10);
            Console.Write("Числа Фибоначи : ");
            foreach (var i in fibo)
            {
                Console.Write($"{i} ");
            }
            SortArr(arr);
            Console.WriteLine();
            Console.Write("Отсортированный массив : ");
            foreach (var i in arr)
            {
                Console.Write($"{i} ");    
            }
        }

        public static (int, int) PositivNegativ(int[] arr)
        {
            int positiv = 0;
            int negativ = 0;

            foreach (var s in arr)
            {
                if (s < 0)
                    negativ++;
                positiv++;
            }
            return (positiv,negativ);
        }

        public static int[] Fibonachi(int number)
        {
            int n = number;
            int[] arr = new int[number + 1];
            arr[0] = 1;
            arr[1] = 1;
            
            for (int i = 2; i <= n; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];

            }

            return arr;
        }

        public static void SortArr(int[] arr)
        {
            int a = 0;
            for (int ferst = 0; ferst < arr.Length; ferst++)
            {
                for (int tu = 0; tu < arr.Length - 1; tu++)
                {
                    if (arr[tu] > arr[tu + 1])
                    {
                        a = arr[tu + 1];
                        arr[tu + 1] = arr[tu];
                        arr[tu] = a;
                    }
                }
            }
        }
    }
}