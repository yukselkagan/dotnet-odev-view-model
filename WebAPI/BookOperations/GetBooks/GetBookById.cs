using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DbOperations;
using WebAPI.Common;

namespace WebAPI.BookOperations.GetBooks
{
    public class GetBookById
    {

        private readonly BookStoreDbContext _dbContext;

        public GetBookById(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public GetBookByIdModel Handle(int id)
        {

            var book = _dbContext.Books.Where(x => x.Id == id).SingleOrDefault();
            GetBookByIdModel Model = new GetBookByIdModel();

            Model.Title = book.Title;
            Model.PageCount = book.PageCount;
            Model.PublishDate = book.PublishDate.ToString("dd/MM/yyyy");
            Model.Genre = ((GenreEnum)book.GenreId).ToString();


            return Model;



        }





    }






    public class GetBookByIdModel
    {

        public string Title { get; set; }

        public int PageCount { get; set; }

        public string PublishDate { get; set; }

        public string Genre { get; set; }



    }


}
