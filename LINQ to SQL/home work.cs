using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_SQL
{
    internal class home_work
    {
        LibraryDataContext db = new LibraryDataContext();

        void Main(string[] args)
        {
            // 1
            Console.Write("Pages count: "); int pages = Convert.ToInt32(Console.ReadLine());
            GetBooksByPages(pages);

            // 2
            Console.Write("Book name starts with: "); string letter = Console.ReadLine();
            GetBookStartsWithLetter(letter);

            // 3
            Console.Write("Author's name: "); string name = Console.ReadLine();
            Console.Write("Author's surname: "); string surname = Console.ReadLine();
            GetSomebodysBooks(name, surname);

            // 4
            Console.Write("Country: "); string country = Console.ReadLine();
            GetBookByCountry(country);

            // 5
            Console.Write("Name length: "); int length = Convert.ToInt32(Console.ReadLine());
            GetBookWhereLessLetters(length);

            // 6
            Console.Write("Country: "); country = Console.ReadLine();
            GetBookWithMaxPagesByCountry(country);

            // 7
            GetLaziestAuthor();

            // 8
            GetCountryByAuthorsCount();
        }

        public void GetBooksByPages(int pages)
        {
            var books = db.Books.Where(x => x.Pages > pages);
            foreach (var book in books)
                Console.WriteLine($"[{book.Id}] {book.Name}");
            Console.WriteLine("\n>>>\n");
        }

        public void GetBookStartsWithLetter(string letter)
        {
            var books = db.Books.Where(x => x.Name[0] == letter.ToUpper()[0]);
            foreach (var book in books)
                Console.WriteLine($"[{book.Id}] {book.Name}");
            Console.WriteLine("\n>>>\n");
        }

        public void GetSomebodysBooks(string name, string surname)
        {
            var books = db.Books.Where(x => x.Author.Name == name && x.Author.Surname == surname);
            if(books.Count() > 0)
            {
                foreach (var book in books)
                    Console.WriteLine($"[{book.Id}] {book.Name}");
            }
            else
                Console.WriteLine("Not found");

            Console.WriteLine("\n>>>\n");
        }

        public void GetBookByCountry(string country)
        {
            var books = db.Books.Where(x => x.Author.Country.Name == country).OrderByDescending(x => x.Name);
            if(books.Count() > 0)
            {
                foreach (var book in books)
                    Console.WriteLine($"[{book.Id}] {book.Name}");
            }
            else
                Console.WriteLine("Not found");

            Console.WriteLine("\n>>>\n");
        }

        public void GetBookWhereLessLetters(int length)
        {
            var nameValueLetterLess = db.Books.Where(x => x.Name.Length < length);
            if(nameValueLetterLess .Count() > 0)
            {
                foreach (var book in nameValueLetterLess)
                    Console.WriteLine($"[{book.Id}] {book.Name}");
            }
            else
                Console.WriteLine("Not found");

            Console.WriteLine("\n>>>\n");
        }

        public void GetBookWithMaxPagesByCountry(string country)
        {
            var mostPagesByCountry = db.Books.Where(x => x.Author.Country.Name == country).OrderByDescending(x => x.Pages).FirstOrDefault();

            if(mostPagesByCountry != null)
                Console.WriteLine($"[{mostPagesByCountry.Id}] {mostPagesByCountry.Name}");
            else
                Console.WriteLine("Not found");

            Console.WriteLine("\n>>>\n");
        }

        public void GetLaziestAuthor()
        {
            var laziestAuthor = db.Authors.OrderBy(x => x.Books.Count()).Take(1).FirstOrDefault();
            if(laziestAuthor != null)
                Console.WriteLine($"[{laziestAuthor.Id}] {laziestAuthor.Name} {laziestAuthor.Surname}");
            else
                Console.WriteLine("Not found");

            Console.WriteLine("\n>>>\n");
        }

        public void GetCountryByAuthorsCount()
        {
            var mostAuthorsCountry = db.Countries.OrderByDescending(x => x.Authors.Count()).FirstOrDefault();
            Console.WriteLine($"[{mostAuthorsCountry.Id}] {mostAuthorsCountry.Name}");
            Console.WriteLine("\n>>>\n");
        }
    }
}