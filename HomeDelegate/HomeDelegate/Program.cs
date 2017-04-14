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
    class Program
    {

        static void Main(string[] args)
        {
            // Создаю магазин и счетчик.
            Bookstore Store = new Bookstore();
            CountClass Count = new CountClass();

            //  Создаю книги.
            NewBook bookDB = new NewBook();

            AddBook(bookDB);
            // Делегаты делегаты добавления книги, выводв списка, методов сумм.
            //ProcessBookDelegate add = Store.AddBook;
            //ProcessBookDelegate str = Store.StringOut;
            //ProcessBookDelegate summ = Count.Count;
            //ProcessBookDelegate summCS = Count.CountCS;
            //ProcessBookDelegate summMidCS = Count.CountMedCS;

            //  Добавляю книги.
            //add(Book1);
            //add(Book2);
            //add(Book3);
            //add(Book4);

            //// Тренерую вызов анонимного делегата.
            //EmptyDelegate print = delegate() {  // Делегат вывода списка книг.
            //    foreach (NewBook item in Store.BookList)
            //    {
            //        str(item);
            //    }
            //};

            ////  Делегаты для реализации суммы.
            //EmptyDelegate sort = Store.Sort;    // Делегат сортировки.
            //EmptyDelegate sum = delegate () {   // Делегат суммы цен всех книг.
            //    ResulTCount(summ, Store);
            //    Write("{0}$", Count.GetAllPrice);
            //};
            //EmptyDelegate sumCS = delegate () { // Делегат суммы всех цен на книги C#.
            //    ResulTCount(summCS, Store);
            //    Write("{0}$", Count.GetCSPrice);
            //};
            //EmptyDelegate sumMedCS = delegate () {  // Делегат суммы средней цены всех книг C#.
            //    ResulTCount(summMidCS, Store);
            //    Write("{0}$", Count.GetMedCSPrice);
            //};

            //  Вывод результатов сортировки
            //ResulTSort(sort, print);

            ////  Вывод сезультатов сумм.
            //Write("\n Сумма цен за все книги: ");
            //sum();
            //Write("\n Сумма цен за все CSharp книги: ");
            //sumCS();
            //Write("\n Средняя сумма цен за все CSharp книги: ");
            //sumMedCS();

            //ReadKey();
        }

        ///// <summary>
        ///// Метод вызова делегатов сортировки и вывода списков.
        ///// </summary>
        ///// <param name="sort">Делегат сортировки.</param>
        ///// <param name="print">Делегат вывода.</param>
        //protected static void ResulTSort(EmptyDelegate sort, EmptyDelegate print)
        //{
        //    WriteLine("\n Список до сортировки цен.");
        //    print();
        //    sort();
        //    WriteLine("\n Список после сортировки цен.");
        //    print();
        //}

        ///// <summary>
        ///// Метод для заполнения делегатов EmptyDelegate.
        ///// </summary>
        ///// <param name="del">Делегат типа ProcessBookDelegate.</param>
        ///// <param name="Store">Магазин.</param>
        //protected static void ResulTCount(ProcessBookDelegate del, Bookstore Store)
        //{
        //    foreach (NewBook item in Store.BookList)
        //    {
        //        del(item);
        //    }
        //}
        static void AddBook(NewBook newbook)
        {
            newbook.AddBook("Big black book", "Me", 100, false);
            newbook.AddBook("Big whith book", "Person C#", 10000, true);
            newbook.AddBook("Big orange book", "You", 10, true);
            newbook.AddBook("Big yellow book", "NotMe", 500, false);
        }
    }
}
