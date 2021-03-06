﻿using System;
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

    class SalaryHour : SalaryBase
    {
        /// <summary>
        /// Конструктор почасовой зарплаты.
        /// </summary>
        /// <param name="rate">зарплата.</param>
        public SalaryHour(double rate) : base(rate)
        {
        }

        /// <summary>
        /// Метод пресчата почасовой зарплаты в месяц.
        /// </summary>
        /// <returns>Возвращает месячную зарплату.</returns>
        public override double CountSalary()
        {
            return 20.8 * 8 * Salary;
        }
    }
}
