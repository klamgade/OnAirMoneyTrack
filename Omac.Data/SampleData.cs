using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Omack.Data.CustomValidations;

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
        public static SampleData Current { get; set; } = new SampleData();  //ignore this code if you want to initialize SampleData somewhere. Otherwise just call this static method
        public List<Items> Items { get; set; }
        
    }
  
    public class Items
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "You need to provide the name")]
        [MaxLength(50, ErrorMessage = "Name cannot be more than 50 characters long")]
        public string Name { get; set; }

        [IsBelowCurrentDate(ErrorMessage = "The entered date cannot be greater than current date.")]
        public DateTime DatePurchased { get; set; }
        public decimal Price { get; set; }
    }
    public class IpAddress
    {
        public string Ip { get; set; }
        public string DateChanged { get; set; }

    }
}
