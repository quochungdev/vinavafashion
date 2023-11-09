using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinavaFashionProject.Models
{
    public class Product
    {
        private static int _nextId = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }

        public Product() { 
            Id = _nextId++;
        }
    }
}
