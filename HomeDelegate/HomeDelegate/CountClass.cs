using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDelegate
{
    /// <summary>
    /// Класс расчета общей цены книг: Count(NewBook item): цены всех книг по CSharp: CountCS(NewBook item); средняя книг по CSharp: CountMedCS(NewBook item).
    /// </summary>
    class CountClass
    {
        /// <summary>
        /// Поля класса CountClass.
        /// </summary>
        protected decimal AllPrice;
        protected decimal CSPrice;
        protected decimal MedCSPrice;
        protected decimal CSnum;
        
        /// <summary>
        /// Метод подсчета цен всех книг.
        /// </summary>
        /// <param name="item">Передаваемая книга.</param>
        public void Count(NewBook item) //  Подсчет цен всех книг.
        {
            AllPrice += item.Price;
        }
        /// <summary>
        /// Метод посчета цен книг СSharp.
        /// </summary>
        /// <param name="item">Книга.</param>
        public void CountCS(NewBook item) //  Подсчет цен книг СSharp.
        {
            if (item.CSharp == true) { CSPrice += item.Price; CSnum++; }
        }
        /// <summary>
        /// Метод посчета средней цены книг СSharp.
        /// </summary>
        /// <param name="item">Книга.</param>
        public void CountMedCS(NewBook item) //  Подсчет средней цены книг CSharp.
        {
            if (item.CSharp == true) MedCSPrice += item.Price / CSnum;
        }

        /// <summary>
        /// Возвращает Значения суммы всех цен.
        /// </summary>
        public decimal GetAllPrice
        {
            get { return this.AllPrice; }
        }
        /// <summary>
        /// Возвращает значение суммы книг CSharp.
        /// </summary>
        public decimal GetCSPrice
        {
            get { return this.CSPrice; }
        }
        /// <summary>
        /// Возвращает значение средней суммы книг CSharp. 
        /// </summary>
        public decimal GetMedCSPrice
        {
            get { return this.MedCSPrice; }
        }
    }
}
