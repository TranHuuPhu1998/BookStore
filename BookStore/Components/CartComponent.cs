using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using BookStore.Data;
namespace BookStore.Components
{
    public class CartComponent : ViewComponent
    {
        private BookService _bookService;

        public CartComponent(BookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {

            string bookstr = HttpContext.Session.GetString("cart");
            Dictionary<int, int> abc = new Dictionary<int, int>();
            Dictionary<Book, int> bookList = new Dictionary<Book, int>();
            var bookListCart = new Book();
            if (!String.IsNullOrEmpty(bookstr))
            {
                bookListCart = JsonConvert.DeserializeObject<Dictionary<Book, int>>(bookstr);

            }
            List<Book> books = bookListCart.ToList();
            return View(books);
        }

        // public async Task<IViewComponentResult> InvokeAsync() 
        // {
        //     string bookstr = HttpContext.Session.GetString("cart");
        //     if (!String.IsNullOrEmpty(bookstr))
        //     {
        //         Dictionary<int, int> books = JsonConvert.DeserializeObject<Dictionary<int, int>>(bookstr);
        //         return View(books);
        //     }
        //     else
        //     {
        //         var book =  new Dictionary<int, int>();
        //         return View(book);
        //     }  

        // }
    }
}