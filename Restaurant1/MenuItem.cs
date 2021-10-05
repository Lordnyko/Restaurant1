using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant1
{
    public class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        //public readonly DateTime DateCreated;
        

        public MenuItem (double price, string description, string category)
        {
            Price = price;
            Description = description;
            Category = category;
          // DateCreated = DateTime.Today;
        }
    }
}
