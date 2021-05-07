using DynamicQuestionnaires.DAL.DataContext;
using DynamicQuestionnaires.Infrastruture.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DynamicQuestionnaires.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal ApplicationDbContext context;
        internal DbSet<TEntity> dbSet;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> Get(
           Expression<Func<TEntity, bool>> filter = null,
           Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
           string includeProperties = "",
           int? page = null,
           int? pageSize = null,
           int? totalCount = null,
           bool track = false)
        {
            IQueryable<TEntity> query = dbSet;

            if (!track)
            {
                query = query.AsNoTracking();
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }


            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }



            if (orderBy != null)
            {
                query = orderBy(query);//.ToListAsync();
            }
            /* else
             {
                 return await query.ToListAsync();
             }*/

            if (page != null)
            {
                // - 1 needs fixing
                return await query.Skip((page.Value) * pageSize.Value).Take(pageSize.Value).ToListAsync();
            }
            return await query.ToListAsync();
        }

        public virtual async Task<TEntity> GetByID(object id)
        {
            return await dbSet.FindAsync(id);
            //return await dbSet.Include("ProcessTypeDocumentDetails").SingleOrDefaultAsync()
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        //ALERT : only works on basic models properties not on included/related tables
        public virtual void Update(TEntity entityToUpdate)
        {
            /*    var entity = dbSet.Find(entityToUpdate);
                context.Entry(entity).CurrentValues.SetValues(entityToUpdate);*/
            //  dbSet.Attach(entityToUpdate);
            if (context.Entry(entityToUpdate).State == EntityState.Detached)
            {
                dbSet.Attach(entityToUpdate);
            }
            context.Entry(entityToUpdate).State = EntityState.Modified;


            /*  dbSet.Attach(entityToUpdate);
              var entry = context.Entry(entityToUpdate);
              entry.State = EntityState.Modified;*/
        }
    }
}
