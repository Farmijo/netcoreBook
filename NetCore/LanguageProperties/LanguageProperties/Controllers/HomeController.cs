using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageProperties.Models;
using System.Linq;
using System.Threading.Tasks;



namespace LanguageProperties.Controllers
{

    public class HomeController : Controller
    {
        /* Using string interpolation
        public ViewResult Index()
        {

            List<string> results = new List<string>();

            foreach(Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<NoName>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                bool available = p?.InStock ?? false;
                results.Add($"Name: {name}, Price: {price}, Related: {relatedName}, Available: {available}");
                // better than use the string.Format(...{0}, name)... syntax

            }
            return View(results);

        }*/

        /*
        public ViewResult Index()
        {

            //It is admitted to initialize the model on the View call
            return View("Index", new string[] { "Hola", "Eho", "huhuh" });

        }*/
        /*
        public ViewResult Index()
        {
            Dictionary<string, Product> products = new Dictionary<string, Product> {
                    { "Kayak", new Product { Name = "Kayak", Price = 275M } },
                    { "Lifejacket", new Product{ Name = "Lifejacket", Price = 48.95M } }
                };
            // Can be also declared as this, using Index initializers, avoiding the excess of {{}}
            Dictionary<string, Product> productsSecondInitialiation = new Dictionary<string, Product>
            {
                ["kayak"] = new Product { Name = "Kayak", Price = 275M },
                ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
            }

               
            return View("Index", products.Keys);
            
        }*/

        //Pattern Matching example
        /* public ViewResult Index()
         {
             object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
             decimal total = 0;

             for(int i = 0; i<data.Length; i++)
             {
                 if(data[i] is decimal d)
                 {
                     total += d; 
                 }

             }
             return View("Index", new string[] { $"Total: {total:C2}" });
         }*/

        //Pattern matching in Switch statements.
        /*
        public ViewResult Index()
        {
            object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            decimal total = 0;

            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case decimal decimalValue:
                        total += decimalValue;
                        break;
                    case int intValue when intValue > 50:
                        total += intValue;
                        break;
                }

            }
            return View("Index", new string[] { $"Total: {total:C2}" });
        }*/

        //Extension methods
        //The method TotalPrices() defined on Extension Methods class can be used directly over ShoppingCart instances

        /*
    public ViewResult Index()
    {
        ShoppingCart cart
        = new ShoppingCart { Products = Product.GetProducts() };
        decimal cartTotal = cart.TotalPrices();
        return View("Index", new string[] { $"Total: {cartTotal:C2}" });
    }*/

        // Using the extension method on an Interface.

        /// Type inference 
       /* public ViewResult Index()
        {
            var products = new[] {
                                    new { Name = "Kayak", Price = 275M },
                                    new { Name = "Lifejacket", Price = 48.95M },
                                    new { Name = "Soccer ball", Price = 19.50M },
                                    new { Name = "Corner flag", Price = 34.95M }
                                 };
            return View(products.Select(p => p.GetType().Name));
        }
*/

        public async Task<ViewResult> Index(){

            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Length: {length}" });

        }


    }


}