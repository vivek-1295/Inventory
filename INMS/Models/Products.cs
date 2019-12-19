using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INMS.Models
{
    public class Products
    {
        [Key]
        [Required]
        [Display(Name = "Product Id")]
        public int id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Product Name can contain only 30 characters")]
        [Display(Name = "Product Name")]
        public string productName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Part Number can contain only 30 characters")]
        [Display(Name = "Part Number")]
        public string partNumber { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Product Lable can contain only 30 characters")]
        [Display(Name = "Product Lable")]
        public string productLabel { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Display(Name = "Starting Inventory")]
        public int startingInventory { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Display(Name = "Inventory Received")]
        public int InventoryReceived { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Display(Name = "Inventory Shipped")]
        public int InventoryShipped{ get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Display(Name = "Invetory on Hand")]
        public int InventoryOnHand { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Display(Name = "Minimum Required")]
        public int MinimumRequired { get; set; }

        public ICollection<Orders> Orders { get; set; }
        public ICollection<Purchases> Purchases { get; set; }
    }
}