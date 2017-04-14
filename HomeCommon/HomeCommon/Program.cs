using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCommon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambdas *****\n");
            TraditionalDelegateSyntax();
            Console.ReadLine();
        }
        static void TraditionalDelegateSyntax()
        {
            // Создать список целых чисел.
            List<int> list = new List<int>(2);
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 4, 4 });
            Console.WriteLine(list.Count);
            list.Clear();
            Console.WriteLine(list.Count);
            list.TrimExcess();
            Console.WriteLine(list.Capacity);

            // Вызов FindAll() с использованием традиционного синтаксиса делегатов.
            // Создаём обобщенный экземпляр обобщенного делегата используя встроенный делегат Predicate
            //Predicate<int> predicate = i => (i % 2) == 0;
            // Создаём список целых чисел, используя метод FindAll, в который передаём делегат
            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);
            Console.WriteLine("Здесь только четные числа:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }
    }
}