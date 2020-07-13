using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name ="Release Name")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        [StringLength(30)]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        public string Genre { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        [Range(1,500)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
