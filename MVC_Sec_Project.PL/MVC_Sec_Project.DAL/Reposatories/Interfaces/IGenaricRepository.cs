using MVC_Sec_Project.DAL.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.DAL.Reposatories.Interfaces
{
    public interface IGenaricRepository<TEntity> where TEntity : BaseEntity
    {
        public IEnumerable<TEntity> GetAll(bool WithTracking = false);
        public IEnumerable<TResult> GetAll<TResult>(Expression<Func<TEntity, TResult>> selector);
        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        public TEntity GetById(int id);
        public void Add(TEntity Entity);
        public void Update(TEntity Entity);
        public void Delete(int id);
        //IEnumerable<TEntity> GetIEnumerable();
        //IQueryable <TEntity> GetIQueryable();
    }
}
