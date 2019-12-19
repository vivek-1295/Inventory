using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INMS.Models
{
    public class Purchases
    {
        [Key]
        public int id { get; set; }
        
        public int supplierId { get; set; }

        [ForeignKey("Products")]
        public int productId { get; set; }
        public string NumberReceived { get; set; }
        public DateTime purchaseDate { get; set; }

        //Reference
        [Required]
        public Products Products { get; set; }
        public Suppliers Suppliers { get; set; }
    }
}