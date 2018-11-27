using Microsoft.AspNetCore.Identity;
using StoreFront.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StoreFront.Data
{
    public class Seed
    {
        private static readonly string STORE_NAME = "Ryan's Store";
        private static readonly string [] PRODUCT_TITLES = new string[] { "Doom", "Starcraft", "Spyro", "Crash 4" };
        private static readonly string[] PRODUCT_DESC = new string[] { "item 1 description testing", "item 2 description testing", "item 3 description testing", "item 4 description testing" };
        private static readonly string[] PRODUCT_IMAGEURL = new string[] { "https://www.mobygames.com/images/covers/l/3907-doom-dos-front-cover.jpg", "https://www.mobygames.com/images/covers/l/2064-starcraft-windows-front-cover.jpg", "https://www.mobygames.com/images/covers/l/17925-spyro-the-dragon-playstation-front-cover.jpg", "https://www.mobygames.com/images/covers/l/86029-crash-bandicoot-playstation-front-cover.jpg" };
        private static int[] RELEASE_DAY = new int[] { 1, 2, 3, 4 };
        private static int[] RELEASE_MONTH = new int[] { 10, 11, 12, 4 };
        private static int[] RELEASE_YEAR = new int[] { 2000, 2001, 2002, 2003 };

        public static async Task Initialize(StoreFrontContext context, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            context.Database.EnsureCreated();

            //check if store seed already exists in DB
            Store myStore = context.Store.Where(c => c.StoreName.Equals(STORE_NAME)).FirstOrDefault();
            if(myStore == null)
            {
                //if not add it to the DB 
                myStore = new Store();
                myStore.StoreName = STORE_NAME;
                myStore.Address = "123 Fake Street";
                context.Store.Add(myStore);
            }

            //add our products
            for(int i =0; i < PRODUCT_TITLES.Length; i++)
            {
                Product currentProduct = context.Product.Where(c => c.Title.Equals(PRODUCT_TITLES[i])).FirstOrDefault();
                if (currentProduct == null)
                {
                    currentProduct = new Product();
                    currentProduct.Title = PRODUCT_TITLES[i];
                    currentProduct.Description = PRODUCT_DESC[i];
                    currentProduct.ImageURL = PRODUCT_IMAGEURL[i];
                    currentProduct.ReleaseDate = new DateTime(RELEASE_YEAR[i], RELEASE_MONTH[i], RELEASE_DAY[i]);
                    context.Product.Add(currentProduct);
                }
            }

            await context.SaveChangesAsync();
        }
    }
}
