using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BookStore;

namespace BookStoreTest
{
    public class BookstoreBasicFunctionsTest
    {
        [Fact]
        public void GetBookByTitleTest()
        {
            var result = BookstoreBasicFunctions.GetBookByTitle("Canterbury Tales");
            Assert.True(result.Count == 1);
        }

        [Fact]
        public void GetAllBooksByAuthorLastnameTest()
        {
            var result = BookstoreBasicFunctions.GetAllBooksByAuthorLastname("Polo");
            Assert.True(result.Count == 1);
        }

        [Fact]
        public void GetAllMoviesTest()
        {
            var result = BookstoreBasicFunctions.GetAllBooks();
            Assert.True(result.Count == 2);
        }
    }
}
