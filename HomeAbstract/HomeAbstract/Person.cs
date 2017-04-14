using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAbstract
{
    class Person : BaseWorker
    {
        /// <summary>
        /// Конструктор работника.
        /// </summary>
        /// <param name="str">ИМя работника.</param>
        /// <param name="sal">Зарплата работника.</param>
        public Person(string str, double sal) : base(str, sal)
        {
        }

    }
}
