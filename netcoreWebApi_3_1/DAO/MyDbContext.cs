using Microsoft.EntityFrameworkCore;
using netcoreWebApi_3_1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreWebApi_3_1.DAO
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Sbtest1> Sbtest1 { get; set; }
    }
}
