using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAbstract
{// Коберник-Березовский Юрий
    /*Построить три класса (базовый и 2 потомка), описывающих некоторых работников с
    почасовой оплатой (один из потомков) и фиксированной оплатой (второй потомок).
    а) Описать в базовом классе абстрактный метод для расчёта среднемесячной заработной
    платы. Для «повременщиков» формула для расчета такова: «среднемесячная заработная плата
    = 20.8 * 8 * почасовую ставку», для работников с фиксированной оплатой «среднемесячная
    заработная плата = фиксированной месячной оплате».
    б) Создать на базе абстрактного класса массив сотрудников и заполнить его.
    в) **Реализовать интерфейсы для возможности сортировки массива используя Array.Sort().
    г) ***Реализовать возможность вывода данных с использованием foreach.*/

    abstract class BaseWorker : IComparable
    {
        protected string Name { get; set; }
        protected double Salary { get; set; }

        /// <summary>
        /// Конструктор работника.
        /// </summary>
        /// <param name="str">Имя работника.</param>
        /// <param name="sal">Его договорная зарплата.</param>
        public BaseWorker(string str, double sal)
        {
            this.Salary = sal;
            this.Name = str;
        }

        public string NameOut() { return Name; }    // Метод возвращает имя работника
        public double SalaryOut() { return Salary; }    // Метод возвращает договорную зарплату работника

        public int CompareTo(object obj)
        {
            return Salary.CompareTo(obj);
        }
    }
}