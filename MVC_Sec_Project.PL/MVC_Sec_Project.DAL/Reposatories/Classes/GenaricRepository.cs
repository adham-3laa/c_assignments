using MVC_Sec_Project.DAL.Contexts;
using MVC_Sec_Project.DAL.Models.Shared;
using MVC_Sec_Project.DAL.Reposatories.Interfaces;
using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Sec_Project.DAL.Reposatories.Classes
{
    public class GenaricRepository <TEntity> (AppDbContext _context) : IGenaricRepository<TEntity> where TEntity : BaseEntity
    {
       

        public void Add(TEntity Entity)
        {
            _context.Set<TEntity>().Add(Entity);
        }


        public void Delete(int id)
        {
            var Entity = _context.Set<TEntity>().Find(id);
            if (Entity == null)
                throw new ArgumentException($"TEntity with id {id} not found.");
            Entity.isDeleted = true;
            _context.Set<TEntity>().Update(Entity);
        }

        public IEnumerable<TEntity> GetAll(bool WithTracking = false)
        {
            if (WithTracking)
                return _context.Set<TEntity>().Where(d => d.isDeleted == false).ToList();
            else
                return _context.Set<TEntity>().Where(d => d.isDeleted == false).AsNoTracking().ToList();
        }
        public IEnumerable<TResult> GetAll<TResult>(System.Linq.Expressions.Expression<Func<TEntity, TResult>> selector)
        {
            return _context.Set<TEntity>()
                .Where(entity => entity.isDeleted == false)
                .Select(selector).ToList();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>()
                .Where(predicate)
                .ToList();
        }

        public TEntity? GetById(int id)
        {
            var Entity = _context.Set<TEntity>().Find(id);
            return Entity;
        }

        public void Update(TEntity Entity)
        {
            _context.Set<TEntity>().Update(Entity);
        }
        //public IEnumerable<TEntity> GetIEnumerable()
        //{
        //    return _context.Set<TEntity>();
        //}

        //public IQueryable<TEntity> GetIQueryable()
        //{
        //    return _context.Set<TEntity>();
        //}


    }
}
