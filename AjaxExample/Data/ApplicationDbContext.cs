using AjaxExample.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace AjaxExample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
