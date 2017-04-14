using System;
using System.Collections.Generic;
using System.Collections;

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

    delegate void Del(NewBook i);
    class BookList
    {
        List<NewBook> List = new List<NewBook>();

        public void AddBook(string title, string author, decimal price, bool CS)
        {
            List.Add(new NewBook(title, author, price, CS));
        }
        public void Sort()
        {
            List.Sort();
        }
        public void ProcessBooks(Del processBook)
        {
            Sort();
            foreach (var item in List)
            {
                processBook(item);
            }
        }
        public void BookOut(NewBook b)
        {
            Console.WriteLine("Книга:{0,14:0.000} | Автор: {1,14:0.000} | Цена: {2,14:0.000}", b.Title, b.Author, b.Price);
        }
    }
}
