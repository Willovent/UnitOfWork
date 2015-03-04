using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        
    }
}
