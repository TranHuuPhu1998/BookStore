using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;

using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookStore.Data;


namespace BookStore.Components
{
    public class PaginatedListComponent : ViewComponent
    {
        private BookService _bookService;

        public PaginatedListComponent(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("Card/AddProduct/{id}")]
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            Dictionary<int, int> bookIds = CardHelper.GetAllProducts(HttpContext);
            Dictionary<Book, int> books = _bookService.FindAll(bookIds);
    
            string referer = Request.Headers["Referer"].ToString();
            ViewData["returnurl"] = referer;

            return View(books);
        }

    }

    
}
