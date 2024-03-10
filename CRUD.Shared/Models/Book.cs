using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Shared.Models
{
    public class Book
    {
        public Guid Id { get; set; }
      
        public string Title { get; set; } = string.Empty;
    
        public string Description { get; set; } = string.Empty;
       
        public string Author { get; set; } = string.Empty;
        public Category? Category { get; set; }
        public string CategoryId { get; set; }
    }
}
