using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreFront.Models
{
    public class Store
    {
        [Key]
        public string StoreID { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
    }
}
