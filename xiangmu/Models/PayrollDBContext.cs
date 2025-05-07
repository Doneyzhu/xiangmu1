using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using xiangmu.Models;
using System.Data.Entity;

namespace xiangmu.Models
{
    public class PayrollDBContext : DbContext
    {
        public PayrollDBContext() : base("name=PayrollDBContext")
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Positions> Positions { get; set; }
    }
}