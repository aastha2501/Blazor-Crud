using CRUD.Shared.DTO;
using CRUD.Shared.Models;

namespace CRUD.Server.Services
{
    public interface IBookService
    {
        Task<IEnumerable<BookResponseModel>> GetAll();
        Task<Book> AddBook(BookRequestModel model);
        Task<IEnumerable<Category>> GetCategory();
        Task<Book> EditBook(EditModel model, Guid id);
        Task<EditModel> GetBookById(Guid id);
        Task<Guid> DeleteBook(Guid id);
    }
}
