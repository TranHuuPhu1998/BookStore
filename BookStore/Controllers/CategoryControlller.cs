using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BookService _bookService;

        public CategoryController(BookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet("Detail/{id}")]
        // GET: /<controller>/
        public IActionResult Detail(int id)
        {

            ViewData["GetAllBookOfCategory"] = _bookService.GetAllBookOfCategory(id);
            ViewData["list1"] = _bookService.GetCountCategory();
            var books = _bookService.ListAllBooks();
            
            return View(books);
        }

        // [HttpGet("Detail/{id}")]
        public async Task<IActionResult> getPage(int id,int? pageNumber){
            var books = _bookService.GetAllBookOfCategory(id);
            int pageSize = 3;
            return View(await PaginatedList<Book>.CreateAsync(books.ToList().AsQueryable(), pageNumber ?? 1, pageSize));
        }

    
        
    }
}