using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using BookStore.Services;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {

        //List<Book> _book;
        IRepository<Book> _bookrepo;
        IRepository<Carousel> _Carouselrepo;
        public HomeController(IRepository<Book> book, IRepository<Carousel> carousel)
        {
            //_book = new List<Book>();
            _bookrepo = book;
            _Carouselrepo = carousel;
        }

        //The home page
        public IActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel()
            {
                Books = _bookrepo.GetAll(),
                Carousels = _Carouselrepo.GetAll()
            };
            return View(model);
        }

        [HttpGet]
        //add book get
        public IActionResult AddBook()
        {
            return View();
        }
        
        [HttpPost]
        //add book post
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                Book item = new Book()
                {
                    Id = _bookrepo.GetAll().Max(m => m.Id) + 1,
                    Title = book.Title,
                    Description = book.Description,
                    Author = book.Author,
                    Image = book.Image,
                    Price = book.Price,
                    PublishDate = book.PublishDate,
                };
                _bookrepo.Add(item);
                return RedirectToAction("Index");
            } else
            {
                return View();
            }
           
        }

        // The about page
        public IActionResult About()
        {
            return View(); 
        }

        // The Contact Page
        public IActionResult Contact()
        {
            return View(); 
        }
    }
}