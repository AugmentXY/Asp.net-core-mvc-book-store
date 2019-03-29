using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Carousel
    {
        public int Id { get; set; }
        public string imageURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
