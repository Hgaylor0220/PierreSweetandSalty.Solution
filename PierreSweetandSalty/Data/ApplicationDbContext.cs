using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PierreSweetandSalty.Models;

namespace PierreSweetandSalty.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

            public virtual DbSet<Flavor> Flavors { get; set; }
            public DbSet<Treat> Treats { get; set; }
            public DbSet<FlavorTreat> FlavorTreat  { get; set; }

            public ApplicationDbContext(DbContextOptions options) : base(options) { }

  
    
    }
}