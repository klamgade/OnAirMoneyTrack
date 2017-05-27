using System;
using System.Collections.Generic;
using System.Text;

namespace Omack.Data.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
