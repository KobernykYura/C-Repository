using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop2
{/*Разработать класс описывающий библиотеку, Bookstore. Класс должен поддерживать возможность добавлять книги в библиотеку, метод AddBook, и обрабатывать книги, метод ProcessBooks(ProcessBookDelegate processBook). 
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
Интерфейс для реализации сортировки IComparable.*/

    class Program
    {
        static void Main(string[] args)
        {
            BookList list = new BookList();
            AddBook(list);

            Del d = list.BookOut;
            list.ProcessBooks(d);

            Count c = new Count();
            Del b = c.CountAll;

            list.ProcessBooks(b); b = c.Mid;
            list.ProcessBooks(b);
            c.OutAll();
            c.OutMid();
            
            Console.ReadKey();
        }
        static void AddBook(BookList list)
        {
            list.AddBook("White book","SamConnor",100,true);
            list.AddBook("Black book","DenConnor",1020,false);
            list.AddBook("Orange book","SimonConnor",1600,true);
            list.AddBook("Grey book","BartConnor",1050,true);
            list.AddBook("Light book","CorrConnor",1012,true);
            list.AddBook("Grey book","VoidConnor",10, false);
        }
    }
}
