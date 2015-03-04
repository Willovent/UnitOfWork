using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IRepository<T>
    {

        T Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        int Save();
    }
}
