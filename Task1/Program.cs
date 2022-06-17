using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CheckSimple();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка обработки введенного числа");
            }
        }

        static void CheckSimple()
        {
            int n = int.Parse(Console.ReadLine());
            int d = 0;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                i++;
            }

            if (d == 0)
            {
                Console.WriteLine("Простое");
                return;
            }
            Console.WriteLine("Не проcтое");
        }
    }
}
