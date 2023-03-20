using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    
    class Book : IComparable<Book>
    {
        List<Book> Books = new List<Book>();
        public int ID;
        public string Title;
        public string Author;
        public string Publisher;
        public int Year;
        public string Type;
        public Book() { }

        public Book(int ID, string Title, string Author, string Publisher, int Year, string Type)
        {
            this.ID = ID;
            this.Title = Title;
            this.Author = Author;
            this.Publisher = Publisher;
            this.Year = Year;
            this.Type = Type;
        }

        public void Display()
        {
            Console.WriteLine("ID: {0}, Title: {1}, Author {2}, Publisher {3}, Year {4}, Type {5}", ID, Title, Author, Publisher, Year, Type);
        }
        public int CompareTo(Book other)
        {
            return this.ID.CompareTo(other.ID);
        }
        public void NewBook()
        {
            Book b = new Book();
            Console.WriteLine("ID");
            b.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Title");
            b.Title = Convert.ToString(Console.ReadLine());
            Console.WriteLine("A");
            b.Author = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ID");
            b.Publisher = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ID");
            b.Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ID");
            b.Type = Convert.ToString(Console.ReadLine());
            Books.Add(b);
        }
        public void sort
        {
        foreach (Book b in Books)
            {
            b.Display();
            }
            Books.Sort();
            Console.WriteLine("\nList of Books:");
            foreach (Book b in Books)
            {
                b.Display();
            }
        }
pubic voi
                Console.WriteLine("\nFind the Book:");
            string findTitle = Console.ReadLine();
            foreach (Book b in Books)
            {
                if (b.Title.ToUpper().Contains(findTitle.ToUpper()))
                {
                    b.Display();
                }
            }
            Console.ReadLine();
                   
    }
}
