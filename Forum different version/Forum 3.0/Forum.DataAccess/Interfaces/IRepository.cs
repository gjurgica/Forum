using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(string Id);
        int Insert(TEntity entity);
        int Update(TEntity entity);
        int Delete(string Id);
    }
}
