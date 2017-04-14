using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

    class NewBook : Bookstore, IComparable<NewBook>
    {
        /// <summary>
        /// Конструктор книги.
        /// </summary>
        /// <param name="title">Заголовок книги.</param>
        /// <param name="author">Автор книги.</param>
        /// <param name="price">Цена книги.</param>
        /// <param name="csharp">Она C#?</param>
        public NewBook(string title, string author, decimal price, bool csharp)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
            this.CSharp = csharp;
        }

        /// <summary>
        /// Метод сравнения для сортировки списка книг.
        /// </summary>
        /// <param name="other">Передаваемая книга.</param>
        /// <returns>Результат сравнения цен книг.</returns>
        public int CompareTo(NewBook other)
        {
            // A null value means that this object is greater.
            if (other == null)
                return 1;

            else
                return other.Price.CompareTo(this.Price);
        }
    }
}
