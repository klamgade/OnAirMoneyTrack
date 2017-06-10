using System;
using System.Collections.Generic;
using System.Text;

namespace Omack.Services.Models
{
    public class ItemServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public int ItemType { get; set; }
        public Boolean IsActive { get; set; }

        public int UserId { get; set; }
        public int GroupId { get; set; }
        public int MediaId { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public int? CreatedBy { get; set; }
    }
}
