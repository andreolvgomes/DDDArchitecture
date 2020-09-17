using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ClienteContext : IDisposable
    {
        private SqlConnection _conn = null;

        /// <summary>
        /// ClienteContext
        /// </summary>
        public ClienteContext()
        {

        }

        /// <summary>
        /// Connection
        /// </summary>
        public SqlConnection Connection
        {
            get
            {
                return this.Conn();
            }
        }

        public void Dispose()
        {
            if (_conn != null)
                _conn.Dispose();
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Start Conn
        /// </summary>
        /// <returns></returns>
        private SqlConnection Conn()
        {
            if (_conn == null)
                _conn = new SqlConnection(this.ConnectionCofiguration());
            return _conn;
        }

        private string ConnectionCofiguration()
        {
            return @"server=.\sql;database=bdsic;user id=sa;pwd=sic742";
        }

        public TEntity Add<TEntity>(TEntity entity)
        {
            // insert into db
            return entity;
        }

        public IEnumerable<TEntity> All<TEntity>()
        {
            return new List<TEntity>();
        }

        public IEnumerable<TEntity> All<TEntity>(string sql)
        {
            return new List<TEntity>();
        }

        public TEntity Delete<TEntity>(TEntity entity)
        {
            return entity;
        }

        public TEntity Find<TEntity>(int id) where TEntity : class
        {
            // find from db
            return default(TEntity);
        }

        public void Update<TEntity>(TEntity entity)
        {
            // 
        }
    }
}