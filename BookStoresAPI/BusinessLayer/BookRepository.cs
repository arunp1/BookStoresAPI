using System.Linq;

namespace BookStoresAPI.BusinessLayer
{
    public class BookRepository : IBookRepository
    {
        public masterEntities dbContext;

        public BookRepository()
        {
            dbContext = new masterEntities();
        }

        /// <summary>
        /// Book Create. Creating a book using EF
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int Create(BookDetail book)
        {
            var bookDetail = new BookDetail
            {
                BookName = book.BookName,
                Author = book.Author,
                Category = book.Category,
                Description = book.Description
            };
            dbContext.BookDetails.Add(bookDetail);
            dbContext.SaveChanges();


            return bookDetail.BookId;
        }

        /// <summary>
        /// Updating the BookDetails based on bookid
        /// </summary>
        /// <param name="bookDetail"></param>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public BookDetail Update(BookDetail bookDetail, int bookId)
        {
            var book = dbContext.BookDetails.FirstOrDefault(x => x.BookId == bookId);

            if (book != null)
            {
                //Null Check is for partial updates if the value is null then it will take the old value
                book.Author = !string.IsNullOrEmpty(bookDetail.Author) ? bookDetail.Author : book.Author;
                book.BookName = !string.IsNullOrEmpty(bookDetail.BookName) ? bookDetail.BookName : book.BookName;
                book.Category = !string.IsNullOrEmpty(bookDetail.Category) ? bookDetail.Category : book.Category;
                book.Description = !string.IsNullOrEmpty(bookDetail.Description)
                    ? bookDetail.Description
                    : book.Description;

                dbContext.SaveChanges();
            }

            return book;
        }
    }
}