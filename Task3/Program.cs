using System;
using System.Collections.Generic;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 13;
            try
            {
                int result = CountFibonacciWithRecurse(n);
                //int result = CountFibonacciWithArray(n);
                Console.WriteLine($"Число фибоначи порядка {n} = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}\nОтрицательные числа в учебной задаче не рассматриваются");
            }
        }

        static int CountFibonacciWithRecurse(int order)
        {
            if (order < 0)
            {
                throw new ArgumentOutOfRangeException("запрашиваемый порядок числа");
            }
            if (order == 0)
            {
                return 0;
            }
            if (order == 1)
            {
                return 1;
            }

            return CountFibonacciWithRecurse(order - 2) + CountFibonacciWithRecurse(order - 1);
        }

        static int CountFibonacciWithArray(int order)
        {
            if (order < 0)
            {
                throw new ArgumentOutOfRangeException("запрашиваемый порядок числа");
            }
            int fibonacci_1 = 0;
            int fibonacci_2 = 1;
            int temp;
            int i = 0;
            while (i <= order - 2)
            {
                temp = fibonacci_1 + fibonacci_2;
                fibonacci_1 = fibonacci_2;
                fibonacci_2 = temp;
                i++;
            }
            if (order == 0)
            {
                return fibonacci_1;
            }
            return fibonacci_2;
        }
    }
}
