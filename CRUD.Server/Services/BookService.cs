
using CRUD.Server.Respository;
using CRUD.Shared.DTO;
using CRUD.Shared.Models;

namespace CRUD.Server.Services
{
    public class BookService: IBookService
    {
        private readonly IGenericRepository<Book> _bookRepository;
        private readonly IGenericRepository<Category> _categoryRepository;
        public BookService(IGenericRepository<Book> bookRepository, IGenericRepository<Category> categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> GetCategory()
        {
            try
            {
                List<Category> categories = new List<Category>();
                var allCategories = _categoryRepository.GetAll().ToList();
                return allCategories;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public async Task<IEnumerable<BookResponseModel>> GetAll()
        {
            try
            {
                List<BookResponseModel> productList = new List<BookResponseModel>();

                var allBooks= _bookRepository.GetAll().ToList();

                foreach (var book in allBooks)
                {
                    var categoryName = _categoryRepository.GetAll().FirstOrDefault(x => x.Id == book.CategoryId).Name;

                    var productListObj = new BookResponseModel()
                    {
                        Title = book.Title,
                        Description = book.Description,
                        Author = book.Author,
                        Category = categoryName,
                        Id = book.Id,
                    };

                    productList.Add(productListObj);
                }

                return productList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Book> AddBook(BookRequestModel model)
        {
            try
            {
                var book = new Book()
                {
                    Id = Guid.NewGuid(),
                    Title = model.Title,
                    Description = model.Description,
                    Author = model.Author,
                    CategoryId = model.CategoryId
                };
                await _bookRepository.AddAsync(book);
                return book;
            }
            catch (Exception ex) { throw ex; }
        }

        public async Task<EditModel> GetBookById(Guid id)
        {
            try
            {
                var res = _bookRepository.GetById(id);
                EditModel book = new EditModel();
                if (res != null)
                {
                    book.Id = res.Id;
                    book.Author = res.Author;
                    book.Title = res.Title;
                    book.Description = res.Description;
                    book.CategoryId = res.CategoryId;
                }
                return book;
            }
            catch (Exception ex) { throw ex; }
        }
        public async Task<Book> EditBook(EditModel model, Guid id)
        {
            try
            {
                //var categoryId = _categoryRepository.GetAll().FirstOrDefault(x => x.Name == model.Category).Id;
                var book = _bookRepository.GetById(id);
                book.Author = model.Author;
                book.Title = model.Title;
                book.Description = model.Description;
                book.CategoryId = model.CategoryId;
                
                _bookRepository.Update(book);
                _bookRepository.Save();
                return book;
            }
            catch (Exception ex) { throw ex; }
        }

        public async Task<Guid> DeleteBook(Guid id)
        {
            try
            {
                var book = _bookRepository.GetAll().FirstOrDefault(x => x.Id == id);
                if (book != null)
                {
                    await _bookRepository.DeleteAsync(book);
                    return id;
                }
                throw new Exception("No product found with this Id");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
