using Dapper.Contrib.Extensions;
using DapperCv.DataAccess.Interfaces;
using DapperCv.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.DataAccess.Concrete.Dapper
{
    public class DpGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity, new()
    {
        //RDMS Bağımlılığını ortadan kaldırmak için Connection Interface ni kullanacağız
        private readonly IDbConnection _dbConnection;

        public DpGenericRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void Delete(TEntity entity)
        {
            _dbConnection.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _dbConnection.GetAll<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbConnection.Get<TEntity>(id);
        }

        public void Insert(TEntity entity)
        {
            _dbConnection.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _dbConnection.Update(entity);
        }
    }
}
