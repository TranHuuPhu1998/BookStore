using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Detail()
        {
            Book book = new Book
            {       
                Id=1,
                Author ="Apple",
                Description="learn dotnet core",
                Title="book",
                Price=111,
                DiscountedPrice=1010

            };

            return View(book);
        }
    }
}
