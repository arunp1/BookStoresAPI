using BookStoresAPI.BusinessLayer;
using System;
using System.Web.Http;

namespace BookStoresAPI.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IBookRepository _bookService;

        public ValuesController()
        {
            _bookService = new BookRepository();
        }


        /// <summary>
        /// Create Method of Book
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        [Route("api/book/create")]
        [HttpPost]
        public IHttpActionResult Create([FromBody] BookDetail book)
        {
            try
            {
                var response = _bookService.Create(book);

                if (response != null)
                    return Ok(response);

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// Update Method of Book.
        /// Handled the Partial updates scenario as well.This logic is handled inside the BookRepository Update method
        /// </summary>
        /// <param name="book"></param>
        /// <param name="bookid"></param>
        /// <returns></returns>
        [Route("api/book/{bookId}/update")]
        [HttpPut]
        public IHttpActionResult Update([FromBody] BookDetail book, [FromUri] int bookid)
        {
            try
            {
                var response = _bookService.Update(book, bookid);

                if (response != null)
                    return Ok(response);

                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}