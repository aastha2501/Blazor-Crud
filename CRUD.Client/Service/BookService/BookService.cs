using CRUD.Shared.DTO;
using CRUD.Shared.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace CRUD.Client.Service.SuperHeroService
{
    public class BookService : IBookService
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;

        List<Book> Books = new List<Book>();
        public BookService(HttpClient http, NavigationManager navigationManager)
        {
            _httpClient = http;
            _navigationManager = navigationManager;
        }

        public async Task<List<BookResponseModel>> GetBooks()
        {
            var response = await _httpClient.GetFromJsonAsync<List<BookResponseModel>>("api/Book/allbooks");
          
            return response;
        }
        public async Task<List<Category>> GetCategory()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Category>>("api/Book/allCategories");

            return response;
        }
        public async Task<Book> AddBook(BookRequestModel model)
        {
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Book/add", content);
            if (response.IsSuccessStatusCode)
            {
                var createdBookJson = await response.Content.ReadAsStringAsync();
                var createdBook = JsonConvert.DeserializeObject<Book>(createdBookJson);
                return createdBook;
            }
            return null;
        }

        //private async Task SetBook(HttpResponseMessage result)
        //{
        //    var response = await result.Content.ReadFromJsonAsync<List<Book>>();
        //    Books = response;
        //    _navigationManager.NavigateTo("books");
        //}
        public async Task UpdateBook(EditModel book)
        {
            await _httpClient.PutAsJsonAsync($"api/Book/edit/{book.Id}", book);
            
        }

        public async Task<EditModel> GetById(Guid id)
        {
            var response = await _httpClient.GetFromJsonAsync<EditModel>($"api/Book/{id}");
            return response;
        }

        public async Task<HttpResponseMessage> Delete(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"api/Book/delete/{id}");
            return result;

        }
    }
}
