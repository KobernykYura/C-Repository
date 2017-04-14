using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLanda
{
    using static Console;

    class Program
    {

        
        static void Main(string[] args)
        {
            var obj = new NewObj[10];
            Class work = new Class();

            EventClass evn = new EventClass();

            evn.Event += OutHello;
            evn.Event += DidYouKnow;

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i] = new NewObj($"Я это ты +{i}", i+1);
            }

            Del a = work.Add;
            Del p = work.Print;
            Del s = work.Sum;

            for (int i = 0; i < obj.Length; i++)
            {
                a(obj[i]);
                p(obj[i]); 
            }
            s(obj[1]);

            WriteLine("\nФакториал до какого числа мне вывести?\n"); evn.GoEvent();
            Write(">> ");
            string st = ReadLine();
            int stt = Convert.ToInt32(st);

            Factoreal(stt);

            ReadKey();
        }

        public static void Factoreal(int stt)
        {
            DelFact f = ff => {
                int r = 1;
                for (int i = 1; i <= ff; i++)
                {
                    r *= i;
                }
                return r;
            };
            for (int i = 1; i <= stt; i++)
            {
                WriteLine($"Факториал {i} равен:  {f(i)}");
            }

        }

        static void OutHello()
        {
            WriteLine("Привет! Ты меня звал?");
        }
        static void DidYouKnow()
        {
            WriteLine("Ты знал что сегодня великий день?");
        }
    }
}

