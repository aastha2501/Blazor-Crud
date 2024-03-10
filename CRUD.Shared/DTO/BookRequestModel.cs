using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Shared.DTO
{
    public class BookRequestModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required(ErrorMessage = "The Category field is required")]
        public string CategoryId { get; set; }
        [Required]
        public string Author { get; set; }

    }
}
