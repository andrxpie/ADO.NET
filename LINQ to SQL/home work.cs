using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_SQL
{
    internal class home_work
    {
        static void Main(string[] args)
        {
            LibraryDataContext db = new LibraryDataContext();

            // 1
            Console.Write("Pages count: "); int pagesValue = Convert.ToInt32(Console.ReadLine());
            var morePages = db.Books.Where(x => x.Pages > pagesValue);
            foreach (var book in morePages)
                Console.WriteLine($"[{book.Id}] {book.Name}");

            Console.WriteLine("\n>>>\n");

            // 2
            Console.Write("Book name starts with: "); string startLetter = Console.ReadLine();
            var booksStartsWith = db.Books.Where(x => x.Name[0] == startLetter.ToUpper()[0]);
            foreach (var book in booksStartsWith)
                Console.WriteLine($"[{book.Id}] {book.Name}");

            Console.WriteLine("\n>>>\n");

            // 3
            Console.Write("Author's name: "); string authorsName = Console.ReadLine();
            Console.Write("Author's surname: "); string authorsSurname = Console.ReadLine();

            var somebodysBooks = db.Books.Where(x => x.Author.Name == authorsName && x.Author.Surname == authorsSurname);
            if(somebodysBooks.Count() > 0)
            {
                foreach (var book in somebodysBooks)
                    Console.WriteLine($"[{book.Id}] {book.Name}");
            }
            else
                Console.WriteLine("Not found");

            Console.WriteLine("\n>>>\n");

            // 4
            Console.Write("Country: "); string country = Console.ReadLine();
            var countryBooks = db.Books.Where(x => x.Author.Country.Name == country).OrderByDescending(x => x.Name);
            if(countryBooks.Count() > 0)
            {
                foreach (var book in countryBooks)
                    Console.WriteLine($"[{book.Id}] {book.Name}");
            }
            else
                Console.WriteLine("Not found");

            Console.WriteLine("\n>>>\n");

            // 5
            Console.Write("Name length: "); int nameLength = Convert.ToInt32(Console.ReadLine());
            var nameValueLetterLess = db.Books.Where(x => x.Name.Length < nameLength);
            if(nameValueLetterLess .Count() > 0)
            {
                foreach (var book in nameValueLetterLess)
                    Console.WriteLine($"[{book.Id}] {book.Name}");
            }
            else
                Console.WriteLine("Not found");

            Console.WriteLine("\n>>>\n");

            // 6
            Console.Write("Country: "); country = Console.ReadLine();
            var mostPagesByCountry = db.Books.Where(x => x.Author.Country.Name == country).OrderByDescending(x => x.Pages).FirstOrDefault();

            if(mostPagesByCountry != null)
                Console.WriteLine($"[{mostPagesByCountry.Id}] {mostPagesByCountry.Name}");
            else
                Console.WriteLine("Not found");

            Console.WriteLine("\n>>>\n");

            // 7
            var laziestAuthor = db.Authors.OrderBy(x => x.Books.Count()).Take(1).FirstOrDefault();
            if(laziestAuthor != null)
                Console.WriteLine($"[{laziestAuthor.Id}] {laziestAuthor.Name} {laziestAuthor.Surname}");
            else
                Console.WriteLine("Not found");

            Console.WriteLine("\n>>>\n");

            // 8
            var mostAuthorsCountry = db.Countries.OrderByDescending(x => x.Authors.Count()).FirstOrDefault();
            Console.WriteLine($"[{mostAuthorsCountry.Id}] {mostAuthorsCountry.Name}");

            Console.WriteLine("\n>>>\n");
        }
    }
}