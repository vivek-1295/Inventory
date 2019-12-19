using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace INMS.Models
{
    public class UserRoleMap
    {
        [Key]
        public int Id { get; set; }
        
        public int userId { get; set; }
        
        public int roleId { get; set; }

        public ICollection<Role> Roles { get; set; }
        public ICollection<User> Users { get; set; }
    }
}