using System.Data.Entity;
using Model.Entities;

namespace Model
{
    internal class Context : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Dog> Dogs { get; set; }
        
    }
}
