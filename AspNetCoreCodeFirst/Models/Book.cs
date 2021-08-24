using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreCodeFirst.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string BookName { get; set; }
        [Required]
        public string AuthorName { get; set; }
        public double price { get; set; }
        public string language { get; set; }

        //public int Rating { get; set; }
    }
}
