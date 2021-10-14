using Microsoft.EntityFrameworkCore;
using SegundoParcialAmina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAmina.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Suerte> Suerte { get; set; }
    }
}
