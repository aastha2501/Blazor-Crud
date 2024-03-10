using CRUD.Shared.DTO;
using CRUD.Shared.Models;

namespace CRUD.Client.Service.SuperHeroService
{
    public interface IBookService
    {

        Task<List<BookResponseModel>> GetBooks();
        Task<Book> AddBook(BookRequestModel model);
        Task<List<Category>> GetCategory();
        Task UpdateBook(EditModel book);
        Task<EditModel> GetById(Guid id);
        Task<HttpResponseMessage> Delete(Guid id);
    }
}
