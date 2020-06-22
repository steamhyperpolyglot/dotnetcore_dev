using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers {
    public class HomeController : Controller {
        bool FilterByPrice(Product p) {
            return (p?.Price ?? 0) >= 20;
        }

        /* public ViewResult Index() {
            IProductSelection cart = new ShoppingCart(
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M },
                new Product { Name = "Corner flag", Price = 34.95M }
            );
            return View(cart.Names);
        } */

        public ViewResult Index() {
            var products = new [] {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
            };

            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }

        /* public async Task<ViewResult> Index() {
            List<string> output = new List<string>();
            await foreach(long? len in MyAsyncMethods.GetPageLengths(output, "apress.com", "microsoft.com", "amazon.com")) {
                output.Add($"Page Length: {len}");
            }
            return View(output);
        } */

        #region Lambda Action Method

        // public ViewResult Index() => 
        //     View(Product.GetProducts().Select(p => p?.Name));

        #endregion

        public void prevCodeExamples() {

            #region Using Dictionary

            // Dictionary<string, Product> products = new Dictionary<string, Product> {
            //     // { "Kayak", new Product { Name = "Kayak", Price = 275M } },
            //     // { "Lifejacket", new Product { Name = "Lifejacket", Price = 48.95M } }
            //     ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M },
            //     ["Kayak"] = new Product { Name = "Lifejacket", Price = 48.95M }
            // };

            // return View("Index", products.Keys);

            #endregion

            #region Using the "is" keyword to check type.

            // object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            // decimal total = 0;
            // for (int i = 0; i < data.Length; i++) {
            //     switch(data[i]) {
            //         case decimal decimalValue:
            //             total += decimalValue;
            //             break;
            //         case int intValue when intValue > 50:
            //             total += intValue;
            //             break;
            //     }
            // }

            // return View("Index", new string[] { $"Total: {total:C2}" });

            #endregion

            #region Using Extension Methods with Filter Method

            // Product[] productArray = {
            //     new Product { Name = "Kayak", Price = 275M },
            //     new Product { Name = "Lifejacket", Price = 48.95M },
            //     new Product { Name = "Soccer ball", Price = 19.50M },
            //     new Product { Name = "Corner Flag", Price = 34.95M }
            // };

            // decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

            // return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });

            #endregion

            #region Passing Functions as Objects

            // Product[] productArray = {
            //     new Product { Name = "Kayak", Price = 275M },
            //     new Product { Name = "Lifejacket", Price = 48.95M },
            //     new Product { Name = "Soccer ball", Price = 19.50M },
            //     new Product { Name = "Corner Flag", Price = 34.95M }
            // };

            // Func<Product, bool> nameFilter = delegate(Product prod) {
            //     return prod?.Name?[0] == 'S';
            // };

            // We use lambda expression here.
            // decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
            // decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'S').TotalPrices();

            // return View("Index", new string[] { 
            //     $"Price Total: {priceFilterTotal:C2}",
            //     $"Name Total: {nameFilterTotal:C2}" });

            #endregion

            #region Using type inferencing

            // var names = new [] { "Kayak", "Lifejacket", "Soccer ball" };
            // return View(names);

            #endregion

            #region Using Anonymous Types

            // var products = new [] {
            //     new { Name = "Kayak", Price = 275M },
            //     new { Name = "Lifejacket", Price = 48.95M },
            //     new { Name = "Soccer ball", Price = 19.50M },
            //     new { Name = "Corner flag", Price = 34.95M }
            // };
            // return View(products.Select(p => p.Name));

            #endregion

            #region Display the type for Anonymous Types

            // var products = new [] {
            //     new { Name = "Kayak", Price = 275M },
            //     new { Name = "Lifejacket", Price = 48.95M },
            //     new { Name = "Soccer ball", Price = 19.50M },
            //     new { Name = "Corner flag", Price = 34.95M }
            // };
            // return View(products.Select(p => p.GetType().Name));

            #endregion

            #region Using Interfaces

            // IProductSelection cart = new ShoppingCart(
            //     new Product { Name = "Kayak", Price = 275M },
            //     new Product { Name = "Lifejacket", Price = 48.95M },
            //     new Product { Name = "Soccer ball", Price = 19.50M },
            //     new Product { Name = "Corner flag", Price = 34.95M }
            // );
            // return View(cart.Products.Select(p => p.Name));

            #endregion

            #region Using a List

            List<string> results = new List<string>();

            foreach(Product p in Product.GetProducts()) {
                string name = p?.Name ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                // results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", 
                //     name, price, relatedName));
                results.Add($"Name: {name}, Price: {price:C2}, Related: {relatedName}");
            }

            #endregion
        
        }
    }
}