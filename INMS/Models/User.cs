using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INMS.Models
{
    public class User
    {

        [Key]
        [Required]
        public int id { get; set; }

        [Required]
        [MaxLength(255)]
        [Index(IsUnique = true)]
        public string userName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }


        public UserRoleMap UserRoleMap { get; set; }
    }
}