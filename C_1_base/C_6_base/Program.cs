using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6_base
{
    public class YourTaskHere
    {
        //1 - Реализуйте метод LINQer, который на основе входной последовательности формирует LINQ-запрос, возвращающий элементы последовательности, котороые больше среднего значения входной последовательности 
        public static IEnumerable<int> LINQer(int[] array)
        {
            IEnumerable<int> bigger_than_middle =
            from now in array
            where now > array.Average()
            select now;
            return bigger_than_middle; // возвращаем делегат?
        }
        //2 - Реализуйте метод, который будет асинхронно искать и выводить в консоль факториал чисел от N до 1
        //3 - в проекте "Test" создайте класс для тестирования обоих задач

        static public int factorial(int N)
        {
            int n_factor = 1;
            for (int i = 2; i <= N; i++)
                n_factor *= i;
            Console.WriteLine("{0}! = {1}", N, n_factor);
            return n_factor;
        }
        async public static void as_fact(int N)
        {
            await Task.Run(() => factorial(N));
        }
        static void Main()
        {
            //count_factorials();
            Console.WriteLine("input N to count factorials from 1! to N!");
            int N = Int32.Parse(Console.ReadLine());
            while (N >= 1)
            {
                int n = N;
                as_fact(n);
                N--;
            }

        }
    }
}
