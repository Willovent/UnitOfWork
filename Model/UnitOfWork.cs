using System;
using Model.Repositories;

namespace Model
{
    public class UnitOfWork : IDisposable
    {
        private readonly Context _context = new Context();

        private UserRepository _userRepository;
        public UserRepository UserRepository
        {
            get { return _userRepository ?? (_userRepository = new UserRepository(_context)); }
        }

        private DogRepository _dogRepository;
        public DogRepository DogRepository
        {
            get { return _dogRepository ?? (_dogRepository = new DogRepository(_context)); }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
