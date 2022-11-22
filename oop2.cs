using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Library_Managment_System
    {
        public int UserType;
        public string UserName;
        private int Password;
        public void login()
        {
            Console.WriteLine("login");
        }
        private void Register()
        {
            Console.WriteLine("register");
        }
        public void Logout()
        {
            Console.WriteLine("logout");
        }
    }
    class Book
    {
        public string Title;
        public string Author;
        private int ISBN;
        public int Publication;
        public Librarian librarian;
        public Library_Managment_System management;
        public void Show_duedt()
        {
            Console.WriteLine("show duedt");
        }
        private void Reservation_status()
        {
            Console.WriteLine("reservation status");
        }
        private void Feedback()
        {
            Console.WriteLine("feedback");
        }
        public void Book_request()
        {
            Console.WriteLine("book request");
        }
        public void Renw_info()
        {
            Console.WriteLine("renw info");
        }
    }
    class Librarian
    {
        public string Name;
        private string ID;
        public int Password;
        public int SearchString;
        public library_database library;
        public Library_Managment_System System;
        private void Verify_librarian()
        {
            Console.WriteLine("verify librarian");
        }
        public void Search()
        {
            Console.WriteLine("search");
        }
    }
    class library_database
    {
        public string List_of_books;
        public void Add()
        {
            Console.WriteLine("add");
        }
        private void Delete()
        {
            Console.WriteLine("delete");
        }
        public void Update()
        {
            Console.WriteLine("update");
        }
        private void Display()
        {
            Console.WriteLine("display");
        }
        public void Search()
        {
            Console.WriteLine("search");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "tytul";
            book.Author = "autor";
            book.Book_request();
            book.Renw_info();

            book.librarian = new Librarian();
            book.librarian.Name = "imie";
            book.librarian.Password = 1;
            book.librarian.Search();

            Librarian librarian = new Librarian();
            
            librarian.library = new library_database();

            librarian.library.List_of_books = "lista";
            librarian.library.Add();
            librarian.library.Update();
            librarian.library.Search();


            book.management = new Library_Managment_System();
            book.management.login();
            book.management.Logout();

            librarian.System = new Library_Managment_System();
            librarian.System.login();
            librarian.System.Logout();

            Console.ReadKey();
        }
    }
}
