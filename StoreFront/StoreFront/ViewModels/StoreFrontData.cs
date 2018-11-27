using StoreFront.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreFront.ViewModels
{
    public class StoreFrontData
    {
        public Store MyStore { get; set; }
        public List<ProductFrontData> MyProducts { get; set; }
        public DateTime CurrentDate { get; set; }
    }
}
