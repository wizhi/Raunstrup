﻿namespace Raunstrup.Core.Repositories
{
    public interface IRepository<TEntity>
    {
        TEntity Get(int id);
        void Save(TEntity entity);
        void Delete(TEntity entity);
    }
}
