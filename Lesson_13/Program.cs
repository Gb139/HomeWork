using System;

namespace Lesson_13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5]{-20, 1, 51, -85, -9};
            var (positiv, negativ) = PositivNegativ(numbers);
            Console.WriteLine($"Положительных {positiv}, Отрицательных {negativ}");
            
            int[] fibo = Fibonachi(10);
            Console.Write("Числа Фибоначи : ");
            foreach (var i in fibo)
            {
                Console.Write($"{i} ");
            }

            int[] values = new int[5] { 6, 31, 1, 45, 54 };
            SortArr(values);
            Console.WriteLine();
            Console.Write("Отсортированный массив : ");
            foreach (var i in values)
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
                else
                {
                    positiv++;
                }
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