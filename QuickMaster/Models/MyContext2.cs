using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickMaster.Models
{
    public class MyContext2 : DbContext
    {

        public MyContext2(DbContextOptions<MyContext2> options) : base(options)
        {

        }

        public DbSet<Publisher> Publisher { get; set; }
    }
}
