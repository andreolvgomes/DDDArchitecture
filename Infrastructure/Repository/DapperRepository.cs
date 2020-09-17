using ApplicationCore.Interfaces.Repository;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class DapperRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ClienteContext _dbcontext = null;

        public DapperRepository(ClienteContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public virtual TEntity Add(TEntity entity)
        {
            return _dbcontext.Add<TEntity>(entity);
        }

        public virtual IEnumerable<TEntity> All()
        {
            return _dbcontext.All<TEntity>();
        }

        public virtual IEnumerable<TEntity> All(string sql)
        {
            return _dbcontext.All<TEntity>(sql);
        }

        public virtual TEntity Delete(TEntity entity)
        {
            return _dbcontext.Delete<TEntity>(entity);
        }

        public virtual TEntity Find(int id)
        {
            return _dbcontext.Find<TEntity>(id);
        }

        public virtual void Update(TEntity entity)
        {
            _dbcontext.Update<TEntity>(entity);
        }
    }
}