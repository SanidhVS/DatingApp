using API.Entitities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options ) : base(options)
        {

        }
        public DbSet<AppUser> Users { get; set; } //Use the table name required to be created because this C# class would be migrated 
    }
}
