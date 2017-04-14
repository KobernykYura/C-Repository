using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop2
{
    public struct NewBook : IComparable
    {
        public string Title; // Название.
        public string Author; // Автор.
        public decimal Price; // Цена.
        public bool CSharp; // Книга о C#

        public NewBook(string Title, string Author, decimal Price, bool CSharp)
        {
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
            this.CSharp = CSharp;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            NewBook book = (NewBook)obj;
            return book.Price.CompareTo(this.Price);
        }
    }
}
