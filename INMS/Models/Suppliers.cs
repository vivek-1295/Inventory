using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INMS.Models
{
    public class Suppliers
    {
        [Key]
        public int id { get; set; }

        [Display(Name ="Supplier")]
        public string supplier { get; set; }

        public ICollection<Purchases> Purchases { get; set; }
    }
}