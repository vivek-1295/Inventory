using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INMS.Models
{
    public class Orders
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Title")]
        public string title { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "User Type")]
        public string User { get; set; }

        [ForeignKey("Products")]
        [Display(Name = "Product")]
        public int productId { get; set; }

        [Display(Name = "No. of Order Shipped")]
        public string numberShipped { get; set; }

        [Display(Name = "Shippment Number")]
        public int shippmentNumber { get; set; }
        
        [Display(Name = "Shippment Status")]
        public string status { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public DateTime orderDate { get; set; }
        
        //Reference
        public Products Products { get; set; }
    }
}