using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() =>
        View(Product.GetProducts().Select(p => p?.Name));
    }
}
//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;
//using System.Linq;

//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            Product[] productArray = {
//new Product {Name = "Kayak", Price = 275M},
//new Product {Name = "Lifejacket", Price = 48.95M},
//new Product {Name = "Soccer ball", Price = 19.50M},
//new Product {Name = "Corner flag", Price = 34.95M}
//};
//            decimal priceFilterTotal = productArray
//            .Filter(p => (p?.Price ?? 0) >= 20)
//            .TotalPrices();
//            decimal nameFilterTotal = productArray
//        Chapter 4 ■ Essential C# Features
//94
//.Filter(p => p?.Name?[0] == 'S')
//.TotalPrices();
//            return View("Index", new string[] {
//$"Price Total: {priceFilterTotal:C2}",
//$"Name Total: {nameFilterTotal:C2}" });
//        }
//    }
//}




//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//using System;
//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        bool FilterByPrice(Product p)
//        {
//            return (p?.Price ?? 0) >= 20;
//        }
//        public ViewResult Index()
//        {
//            Product[] productArray = {

//new Product {Name = "Kayak", Price = 275M},
//new Product {Name = "Lifejacket", Price = 48.95M},
//new Product {Name = "Soccer ball", Price = 19.50M},
//new Product {Name = "Corner flag", Price = 34.95M}
//};
//            Func<Product, bool> nameFilter = delegate (Product prod)
//            {
//                return prod?.Name?[0] == 'S';
//            };
//            decimal priceFilterTotal = productArray
//            .Filter(FilterByPrice)
//            .TotalPrices();
//            decimal nameFilterTotal = productArray
//            .Filter(nameFilter)
//            .TotalPrices();
//            return View("Index", new string[] {
//$"Price Total: {priceFilterTotal:C2}",
//$"Name Total: {nameFilterTotal:C2}" });
//        }
//    }
//}





//using Microsoft.AspNetCore.Mvc;
//using System.Collections.Generic;
//using LanguageFeatures.Models;
//namespace LanguageFeatures.Controllers
//{
//    public class HomeController : Controller
//    {
//        public ViewResult Index()
//        {
//            ShoppingCart cart = new ShoppingCart
//            {
//                Products = Product.GetProducts()
//            }; // this method is defined in products 
//            Product[] productArray = {
//            new Product {Name = "Kayak", Price = 275M},
//            new Product {Name = "Lifejacket", Price = 48.95M},
//            new Product {Name = "Soccer ball", Price = 19.50M},
//            new Product {Name = "Corner flag", Price = 34.95M}
//                };
//            decimal cartTotal = cart.TotalPrices();
//            decimal arrayTotal = productArray.TotalPrices();
//            //return View("Index", new string[] {
//            //$"Cart Total: {cartTotal:C2}",
//            //    $"Array Total: {arrayTotal:C2}" });
//            // ProductArray[0]
//            //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
//            //decimal cartTotal = cart.TotalPrices();
//            //return View("Index", new string[] { $"Total: {cartTotal:C2}" });
//            //object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
//            //decimal total = 0;
//            //for (int i = 0; i < data.Length; i++)
//            //{
//            //    switch (data[i]) // switch is substituting if and else 
//            //    {
//            //        case decimal decimalValue:
//            //            total += decimalValue;
//            //            break;
//            //        case int intValue when intValue > 50:
//            //            total += intValue;
//            //            break;
//            //    }
//        }
//        //return View("Index", new string[] { $"Total: {total:C2}" });

//        //List<string> results = new List<string>(); // this means you have a list named results specialized with string 
//        //foreach (Product p in Product.GetProducts())
//        //{
//        //    string name = p?.Name ?? "<No Name>";
//        //    decimal? price = p?.Price ?? 0;
//        //    string relatedName = p?.Related?.Name ?? "<None>";

//        //    results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
//        //    //results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}",
//        //    //name, price, relatedName));
//        //    //results.Add(string.Format("Name: {0}, Price: {1}", name, price));
//        //}
//        //return View(results);
//    }
//}
