using CRUD.Server.Services;
using CRUD.Shared;
using CRUD.Shared.DTO;
using CRUD.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet("allbooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            var result = new ApiResponse();
            try
            {
                var productList = await _bookService.GetAll();
                if (productList != null)
                {
                    result.Data = productList;
                    return Ok(result.Data);
                }
                throw new Exception("Failed to load");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.ErrorMessage = ex.Message;
                return BadRequest(result);
            }
        }

        [HttpGet("allCategories")]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = new ApiResponse();
            try
            {
                var categoryList = await _bookService.GetCategory();
                if (categoryList != null)
                {
                    result.Data = categoryList;
                    return Ok(result.Data);
                }
                throw new Exception("Failed to load");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.ErrorMessage = ex.Message;
                return BadRequest(result);
            }
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddCar(BookRequestModel model)
        {
            var response = new ApiResponse();
            try
            {
                var res = _bookService.AddBook(model);
                if (res != null)
                {
                    response.Success = true;
                    response.Data = model;
                    return Ok(response.Data);
                }
                
                throw new Exception("Failed to add data.");
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                return BadRequest(response);
            }
        }

        [HttpPut("edit/{id:guid}")]
        public async Task<IActionResult> EditCar(EditModel model, Guid id)
        {
            var response = new ApiResponse();
            try
            {
                var res = _bookService.EditBook(model, id);
                if (res != null)
                {
                    response.Success = true;
                    response.Data = model;
                    return Ok(response.Data);
                }

                throw new Exception("Failed to add data.");
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                return BadRequest(response);
            }
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetBookById(Guid id)
        {
            var response = new ApiResponse();
            try
            {
                var res = _bookService.GetBookById(id).Result;
               
                if (res != null)
                {
                    response.Success = true;
                    response.Data = res;
                    return Ok(response.Data);
                }

                throw new Exception("Failed to add data.");
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                return BadRequest(response);
            }
        }


        [HttpDelete("delete/{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = new ApiResponse();
            try
            {
                var res = await _bookService.DeleteBook(id);
                if (res != null)
                {
                    response.Success = true;
                }
                return Ok(response.Success);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.ErrorMessage = ex.Message;
                return BadRequest(response.Success);
            }
        }

    }
}
