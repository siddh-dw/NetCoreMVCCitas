using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMVC.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Cita> Citas {get; set;}
    }
}