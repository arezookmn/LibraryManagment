using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Author
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string? Name { get; set; }

        //[Required(ErrorMessage = "The Birth Date field is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        //[Required(ErrorMessage = "The Nationality field is required.")]
        public string? Nationality { get; set; }

        //[Required(ErrorMessage = "The Biography field is required.")]
        [StringLength(500, ErrorMessage = "The Biography field cannot exceed 500 characters.")]
        public string? Biography { get; set; }
    }
}
