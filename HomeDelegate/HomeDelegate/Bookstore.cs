using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDelegate  // Коберник-Березовский Юрий
{
    /*
   Разработать класс описывающий библиотеку, Bookstore. Класс должен поддерживать возможность добавлять книги в библиотеку, метод AddBook, и обрабатывать книги, метод ProcessBooks(ProcessBookDelegate processBook). 
Книги в библиотеке имеют следующие атрибуты:
public string Title; // Название.
   public string Author; // Автор.
   public decimal Price; // Цена.
   public bool CSharp; // Книга о C#
   Используя делегат public delegate void ProcessBookDelegate(Book book)
1) распечатать названия всех книг о С# отсортировав их по убыванию цены в консоли
2) вычислить и отобразить общую стоимость всех книг о С# в консоли
3) вычислить и отобразить среднюю стоимость книг о С# в консоли.
Расчет общей и средней стоимости реализовать в отдельном классе.
Интерфейс для реализации сортировки IComparable.
*/
    using static Console;
    delegate void ProcessBookDelegate(NewBook book);

    class Bookstore
    {
        /// <summary>
        /// Поля класса BookStore.
        /// </summary>
        public List<NewBook> BookList;
        public string Title;
        public string Author;
        public decimal Price;
        public bool CSharp;

        /// <summary>
        /// Конструктор Магазина(создание списка).
        /// </summary>
        public Bookstore()
        {
            BookList = new List<NewBook>();
        }

        //public string ChangeTitle
        //{
        //    set { this.Title = value; }
        //}

        //public string ChangeAuthor
        //{
        //    set { this.Author = value; }
        //}

        /// <summary>
        /// Добавление в каталог книги.
        /// </summary>
        /// <param name="book">Добавляемая книга.</param>
        public void AddBook(string title, string author, decimal price, bool paperBack)
        {
            BookList.Add(new NewBook(title, author, price, paperBack));
        }

        /// <summary>
        /// Сортировка книг.
        /// </summary>
        public void Sort()
        {
            BookList.Sort();
        }

        //public void Out() //  Заменил этот метод делегатом в Main
        //{
        //    foreach (NewBook item in BookList)
        //    {
        //        StringOut(item);
        //    }
        //
        //}

        /// <summary>
        /// Вывод характеристик книги.
        /// </summary>
        /// <param name="item">Обрабатываемая книга.</param>
        public void StringOut(NewBook item)
        {
            string answ = YesNo(item);
            WriteLine("| Есть книга {0,10:0.000} | Автор: {1,8:0.000} | Цена: {2,10:0.000}$ | Она о C#? {3,8:0.000} | ", item.Title, item.Author, item.Price, answ);

        }
        /// <summary>
        /// Метод проверки книги. Является она С# или нет.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public string YesNo(NewBook item)
        {
            if (item.CSharp == true) { return"Да"; }
            else { return "Нет"; }
        }
    }
}
