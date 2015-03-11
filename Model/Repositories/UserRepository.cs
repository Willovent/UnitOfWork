using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Model.Entities;

namespace Model.Repositories
{
    public class UserRepository : IRepository<User>
    {

        private readonly Context _context;
        
        internal UserRepository(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Renvoie les 10 derniers utilisateurs enregistrés
        /// </summary>
        /// <returns></returns>
        public List<User> LastUsers()
        {
            return _context.Users.OrderByDescending(x => x.UserId).Take(10).Include(x => x.Dogs).ToList();
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
