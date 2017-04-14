using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAbstract  // Коберник-Березовский Юрий
{/*Построить три класса (базовый и 2 потомка), описывающих некоторых работников с
почасовой оплатой (один из потомков) и фиксированной оплатой (второй потомок).
а) Описать в базовом классе абстрактный метод для расчёта среднемесячной заработной
платы. Для «повременщиков» формула для расчета такова: «среднемесячная заработная плата
= 20.8 * 8 * почасовую ставку», для работников с фиксированной оплатой «среднемесячная
заработная плата = фиксированной месячной оплате».
б) Создать на базе абстрактного класса массив сотрудников и заполнить его.
в) **Реализовать интерфейсы для возможности сортировки массива используя Array.Sort().
г) ***Реализовать возможность вывода данных с использованием foreach.*/

    using static Console;
    class Program
    {
        static void Main(string[] args)
        {
            Write("Заплата в час: ");
            double salaryHour = InputCheckDouble();
            Write("Зарплата в месяц: ");
            double salaryMounth = InputCheckDouble();

            SalaryHour Hour = new SalaryHour(salaryHour);
            SalaryMounth Mounth = new SalaryMounth(salaryMounth);

            BaseWorker[] BW = new BaseWorker[20];

            for (int i = 0; i < 10; i++)    // Заполнение массива работниками и их среднемесячными зарплатами.
            {
                BW[i] = new Person($"Person{i+1}", Hour.CountSalary());
            }

            for (int i = 10; i < 20; i++)    // Заполнение массива работниками и их среднемесячными зарплатами.
            {
                BW[i] = new Person($"Person{i+1}", Mounth.CountSalary());
            }

            foreach (Person person in BW)   // Перебор каждого работника и его среднемесячной зарплаты через foreach.
            {
                WriteLine($"Выбран работник {person.NameOut()} с месячной оплатой {person.SalaryOut()} труда."); 
            }
            ReadKey();
           
        }

        /// <summary>
        /// Проверка ввода на ошибки. Проверка правильности ввода.
        /// </summary>
        /// <returns>Результатом является значение.</returns>
        static public double InputCheckDouble()
        {
            double value = 0;
            bool flag = false;

            do
            {
                try
                {
                    value = Convert.ToDouble(ReadLine());
                    flag = false;
                }
                catch (Exception)
                {
                    flag = true;
                    WriteLine("Введены некорректные данные! Повторите попытку.\n");
                }
            } while (flag);
            return value;
        }

        /// <summary>
        /// Проверка ввода на ошибки. Проверка правильности ввода.
        /// </summary>
        /// <returns>Результатом является значение.</returns>
        static public int InputCheckInt()
        {
            int value = 0;
            bool flag = false;

            do
            {
                try
                {
                    value = Convert.ToInt32(ReadLine());
                    flag = false;
                }
                catch (Exception)
                {
                    flag = true;
                    WriteLine("Введены некорректные данные! Повторите попытку.\n");
                }
            } while (flag);
            return value;
        }


    }

}
