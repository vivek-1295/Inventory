using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INMS.Models
{
    public class Role
    {
        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        [MaxLength(255)]
        [Index(IsUnique = true)]
        public string roleName { get; set; }


        public UserRoleMap UserRoleMap { get; set; }
    }
}