﻿namespace Model
{
    public interface IRepository<T>
    {
        T Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        T Find(int id);
        int Save();
    }
}
