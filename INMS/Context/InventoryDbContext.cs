using INMS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace INMS.Context
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<Products> Products { get; set; }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<Suppliers> Suppliers { get; set; }

        public DbSet<Purchases> Purchases { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserRoleMap> UserRoleMaps { get; set; }
    }
}