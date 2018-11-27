using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StoreFront.Data;
using StoreFront.Models;
using StoreFront.ViewModels;

namespace StoreFront.Controllers
{
    public class StoreFrontController : Controller
    {
        private readonly StoreFrontContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public StoreFrontController(StoreFrontContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var products =  _context.Product.OrderBy(c=> c.ReleaseDate).ToList();
            var frontData = GetPublishers(products);
            var storeData = _context.Store.FirstOrDefault();
            StoreFrontData myStoreFrontData = new StoreFrontData();
            myStoreFrontData.MyStore = storeData;
            myStoreFrontData.MyProducts = frontData;
            myStoreFrontData.CurrentDate = DateTime.Now;
            return View(myStoreFrontData);
        }

        public List<ProductFrontData> GetPublishers(List<Product> products)
        {
            List<ProductFrontData> frontData = new List<ProductFrontData>();
            foreach(var product in products)
            {
                ProductFrontData currentFrontData = new ProductFrontData();
                currentFrontData.myProduct = product;
                currentFrontData.myPublisher = _context.Publisher.Where(c => c.PublisherID.Equals(product.PublisherID)).FirstOrDefault();
                frontData.Add(currentFrontData);
            }
            return frontData;
        }
    }
}