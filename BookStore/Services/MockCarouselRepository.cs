using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class MockCarouselRepository : IRepository<Carousel>
    {
        List<Carousel> _carousels;
        public MockCarouselRepository()
        {
            _carousels = new List<Carousel>();
            _carousels.Add(new Carousel()
            {
                Id = 0,
                Title = "Discount Books",
                Description = "Discounted Books get them all",
                imageURL = ""
            });
            _carousels.Add(new Carousel()
            {
                Id = 2,
                Title = "New Books",
                Description = "All Brand new Books get them all",
                imageURL = ""
            });
            _carousels.Add(new Carousel()
            {
                Id = 3,
                Title = "Subscription Books",
                Description = "Discounted Books on Monthly Subscription",
                imageURL = ""
            });

        }
        public bool Add(Carousel item)
        {
            try
            {
                Carousel carousel = item;
                carousel.Id = _carousels.Max(x => x.Id) + 1;
                _carousels.Add(carousel);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Carousel item)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Carousel item)
        {
            throw new NotImplementedException();
        }

        public Carousel Get(int id)
        {
            return _carousels.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Carousel> GetAll()
        {
            return _carousels.ToList();
        }
    }
}
