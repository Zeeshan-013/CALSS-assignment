using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Order_CRUD.Models
{
    public class DataDbContext : DbContext //Create db context class and inherit with base class
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) //configure dbContext option 
        {
        }
        public DbSet<orders> orders { get; set; } // add your data models
    }
}
