using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Omack.Data.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; } // "{user name} has paid {amount}."
        public Boolean IsActive { get; set; }

        //Foreign Keys
        public int UserId { get; set; }
        public int GroupId { get; set; }
        
        
        //Nav properties
        public Group Group { get; set; }
        public User User { get; set; }

        //System Properties  [Note: UpdatedBy & CreatedBy = Current Loggedin User ID]
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public int? CreatedBy { get; set; }
    }
}
