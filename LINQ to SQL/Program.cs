using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_to_SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryDataContext db = new LibraryDataContext();

            // 1
            var highPagesCount = db.Books.Where(x => x.Pages > 100);
            foreach (var book in highPagesCount)
                Console.WriteLine($"[{book.Id}] {book.Name}");

            Console.WriteLine("\n>>>\n");

            // 2
            var booksStartsWithAa = db.Books.Where(x => x.Name[0] == 'A' || x.Name[0] == 'a');
            foreach (var book in booksStartsWithAa)
                Console.WriteLine($"[{book.Id}] {book.Name}");

            Console.WriteLine("\n>>>\n");

            // 3
            var WSBooks = db.Books.Where(x => x.Author.Name == "William" && x.Author.Surname == "Shakespeare");
            if(WSBooks.Count() > 0)
            {
                foreach (var book in WSBooks)
                    Console.WriteLine($"[{book.Id}] {book.Name}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.WriteLine("\n>>>\n");

            // 4
            var UABooks = db.Books.Where(x => x.Author.Country.Name == "Ukraine").OrderByDescending(x => x.Name);
            if(UABooks.Count() > 0)
            {
                foreach (var book in UABooks)
                    Console.WriteLine($"[{book.Id}] {book.Name}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.WriteLine("\n>>>\n");

            // 5
            var name10LetterLess = db.Books.Where(x => x.Name.Length < 10);
            if(name10LetterLess.Count() > 0)
            {
                foreach (var book in name10LetterLess)
                    Console.WriteLine($"[{book.Id}] {book.Name}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.WriteLine("\n>>>\n");

            // 6
            var mostPagesNotDEMOCRATION = db.Books.OrderByDescending(x => x.Pages).Where(x => x.Author.Country.Name != "USA").Take(1).First();

            if(mostPagesNotDEMOCRATION != null)
                Console.WriteLine($"[{mostPagesNotDEMOCRATION.Id}] {mostPagesNotDEMOCRATION.Name}");
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
            var kickDEMOCRATIONauthors = db.Authors.Where(x => x.Country.Name != "USA").OrderByDescending(x => x.Name + " " + x.Surname);
            foreach (var book in kickDEMOCRATIONauthors)
                Console.WriteLine($"[{book.Id}] {book.Name} {book.Surname}");

            Console.WriteLine("\n>>>\n");

            // 9
            var maxCountryAuthors = db.Countries.OrderByDescending(x => x.Authors.Count()).Take(1).FirstOrDefault();
            Console.WriteLine($"[{maxCountryAuthors.Id}] {maxCountryAuthors.Name}");

            Console.WriteLine("\n>>>\n");
        }
    }
}