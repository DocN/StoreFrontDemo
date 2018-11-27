using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreFront.Models
{
    public class Product
    {
        [Key]
        public string ProductID { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
