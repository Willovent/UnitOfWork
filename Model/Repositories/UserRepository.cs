using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Model.Repositories
{
    public class UserRepository : IRepository<User>
    {

        private readonly Context _context;

        public List<User> LastUsers()
        {
            return _context.Users.OrderByDescending(x =>x.UserId).Take(10).Include(x => x.Dogs).ToList();
        } 
        public UserRepository(Context context)
        {
            _context = context;
        }

        public User Add(User entity)
        {
            return _context.Users.Add(entity);
        }

        public void Edit(User entity)
        {
            _context.Users.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(User entity)
        {
            _context.Users.Remove(entity);
        }

        public int Save()
        {
           return _context.SaveChanges();
        }
    }
}
