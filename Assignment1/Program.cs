using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        enum Type
        {
            Magazine, Novel, Referencebook, Miscellaneous
        };

        struct Book
        {
            public int bookid;
            public string title;
            public float price;
            public Type bookType;
        }
        static Book accept(Book book, int bookid, string title, float price, Type bookType)
        {
            book.bookid = bookid;
            book.title = title;
            book.price = price;
            book.bookType = bookType;
            return book;
        }
        static void display(Book book)
        {
            Console.WriteLine("Book_id = " + book.bookid + "\nTitle = " + book.title + "\nPrice = " + book.price + "\nBookType = " + book.bookType);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            book = accept(book, 1, "C# Program", 100, Type.Magazine);
            display(book);
        }

    }
}
