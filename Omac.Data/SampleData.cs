using System;
using System.Collections.Generic;
using System.Text;

namespace Omack.Data
{
    public class SampleData
    {
        public SampleData()
        {
            //initialize some in memory data inside constructor
            Items = new List<Items>()
            {
                new Items{Id = 1, Name = "Curry", DatePurchased= DateTime.UtcNow, Price = 55},
                new Items{Id = 2, Name = "Meat", DatePurchased= DateTime.UtcNow, Price = 15},
                new Items{Id = 3, Name = "Milk", DatePurchased= DateTime.UtcNow, Price = 5},
                new Items{Id = 4, Name = "Rent", DatePurchased= DateTime.UtcNow, Price = 450},
                new Items{Id = 5, Name = "Veg", DatePurchased= DateTime.UtcNow, Price = 23},
                new Items{Id = 6, Name = "Eggs", DatePurchased= DateTime.UtcNow, Price = 8},
                new Items{Id = 7, Name = "Breads", DatePurchased= DateTime.UtcNow, Price = 1},
            };
        }
        public static SampleData Current { get; set; } = new SampleData();
        public List<Items> Items { get; set; }
        
    }
  
    public class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DatePurchased { get; set; }
        public decimal Price { get; set; }
    }
}
