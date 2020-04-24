using System;

namespace Task__3
{
    class Books
    {
        public static int count = 0;

        public string autor;
        public string title;
        public int pages;

        public Books()
        {
            title = "The Hobbit";
            autor = "J.R.R.Tolkien";
            pages = 288;

            count++;
            Print();
        }
        public Books(string _title, string _autor, int _pages)
        {
            title = _title;
            autor = _autor;
            pages = _pages;

            count++;
            Print();
        }

        public void Print()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Pages: " + pages);
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Books book = new Books();
            Console.WriteLine();
            Books book2 = new Books("Lord of the Rings", "J.R.R.Tolkien", 499);

            Console.WriteLine("Count of books:" + Books.count);

            Console.ReadKey();
        }

    }
}
