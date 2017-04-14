using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop2
{/*2) вычислить и отобразить общую стоимость всех книг о С# в консоли
3) вычислить и отобразить среднюю стоимость книг о С# в консоли.
Расчет общей и средней стоимости реализовать в отдельном классе.
Интерфейс для реализации сортировки IComparable.*/

    class Count
    {
        private int i;
        private decimal CSAll;
        private decimal MidCS;

        public void CountAll(NewBook item)
        {
            if (item.CSharp)
            {
                i++;
                this.CSAll+=item.Price;
            }
        }
        public void Mid(NewBook item)
        {
            MidCS = CSAll / i;
        }
        public void OutMid()
        {
            Console.WriteLine("Средняя цена: {0}", MidCS);
        }
        public void OutAll()
        {
            Console.WriteLine("Стоимость всех CS книг: {0}", CSAll);
        }
    }
}
