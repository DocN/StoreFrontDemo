using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreFront.Models
{
    public class StoreFrontData
    {
        public Store MyStore { get; set; }
        public List<ProductFrontData> MyProducts { get; set; }
    }
}
