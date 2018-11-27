using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreFront.Models
{
    public class Publisher
    {
        [Key]
        public string PublisherID { get; set; }
        public string PublisherName { get; set; }
    }
}
