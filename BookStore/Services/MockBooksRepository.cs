using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class MockBooksRepository : IRepository<Book>
    {
        List<Book> _books;
        public MockBooksRepository()
        {
            _books = new List<Book>()
            {
                new Book()
                {
                    Id = 0,
                    Title = "Getting Started with models in mvc",
                    Description = "Using mock data",
                    Author = "Takudzwa A Vafana",
                    Price = 27.90,
                    Image = "img0",
                    PublishDate="Jan 2019"
                },
                 new Book()
                {
                    Id = 1,
                    Title = "Getting Started with Asp",
                    Description = "Using mock data to save work",
                    Author = "Albert Vafana",
                    Price = 17.90,
                    Image = "img1",
                    PublishDate="Feb 2019"
                },
                 new Book()
                {
                    Id = 2,
                    Title = "Getting dot net core",
                    Description = "Usingnot using sql",
                    Author = "Ark Portal",
                    Price = 37.90,
                    Image = "img2",
                    PublishDate="Mar 2019"
                },
                 new Book()
                {
                    Id = 3,
                    Title = "Getting Started with Unreal Engine",
                    Description = "Using the game engine to make AAA games",
                    Author = "Tim Sweeny",
                    Price = 57.90,
                    Image = "img3",
                    PublishDate="Apr 2019"
                },
                 new Book()
                {
                    Id = 4,
                    Title = "Getting Started with Cry Engine",
                    Description = "Using Crytek's Game engine",
                    Author = "Crytek",
                    Price = 97.90,
                    Image = "img4",
                    PublishDate="May 2019"
                }

            };
        }
        public bool Add(Book item)
        {
            try
            {
                Book book = item;
                book.Id = _books.Max(x => x.Id) + 1;
                _books.Add(item);
                return true;
            }
            catch (Exception)
            {
                //log it here
                return false;
            }
        }

        public bool Delete(Book item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Book item)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            return _books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _books.ToList();
        }
    }
}
