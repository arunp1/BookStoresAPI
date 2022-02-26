namespace BookStoresAPI.BusinessLayer
{
    internal interface IBookRepository
    {
        int Create(BookDetail bookDetail);
        BookDetail Update(BookDetail bookDetail, int bookId);
    }
}