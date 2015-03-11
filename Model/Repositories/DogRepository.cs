using System.Data.Entity;
using Model.Entities;

namespace Model.Repositories
{
    public class DogRepository : IRepository<Dog>
    {
        private readonly Context _context;

        internal DogRepository(Context context)
        {
            _context = context;
        }

        public Dog Add(Dog entity)
        {
            return _context.Dogs.Add(entity);
        }

        public void Edit(Dog entity)
        {
            _context.Dogs.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Dog entity)
        {
            _context.Dogs.Remove(entity);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}