using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookstoreBasicFunctions
    {

        public static List<Book> GetBookByTitle(string bTitle)
        {
            try
            {
                using var context = new SE407_BookstoreContext();
                return context.Books.Join(context.Authors, book => book.AuthorId, author => author.AuthorId,
                    (book, author) => new
                    {
                        book.BookId,
                        book.BookTitle,
                        book.GenreId,
                        book.AuthorId,
                        book.YearOfRelease,
                        AuthorLastName = author.AuthorLast

                    }).Where(book => book.BookTitle.ToLower() == bTitle.ToLower())
                    .Select(b => new Book()
                    {
                        BookId = b.BookId,
                        BookTitle = b.BookTitle,
                        GenreId = b.GenreId,
                        YearOfRelease = b.YearOfRelease,
                        AuthorId = b.AuthorId

                    }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        public static List<Book> GetAllBooksByAuthorLastname(string aLastName)
        {
            try
            {
                using var context = new SE407_BookstoreContext();
                return context.Books.Join(context.Authors, book => book.AuthorId, author => author.AuthorId,
                    (book, author) => new
                    {
                        book.BookId,
                        book.BookTitle,
                        book.GenreId,
                        book.AuthorId,
                        book.YearOfRelease,
                        AuthorLastName = author.AuthorLast

                    }).Where(book => book.AuthorLastName.ToLower() == aLastName.ToLower())
                    .Select(b => new Book()
                    {
                        BookId = b.BookId,
                        BookTitle = b.BookTitle,
                        GenreId = b.GenreId,
                        YearOfRelease = b.YearOfRelease,
                        AuthorId = b.AuthorId
                                              
                    }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static List<Book> GetAllBooks()
        {
            try
            {

                using (var context = new SE407_BookstoreContext())
                {
                    return context.Books.ToList();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }







    }
}
