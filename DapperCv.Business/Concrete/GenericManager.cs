using DapperCv.Business.Interfaces;
using DapperCv.DataAccess.Interfaces;
using DapperCv.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, IEntity, new()
    {

        private readonly IGenericRepository<TEntity> _genericRepository;

        public GenericManager(IGenericRepository<TEntity> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public void Delete(TEntity entity)
        {
            _genericRepository.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _genericRepository.GetById(id);
        }

        public void Insert(TEntity entity)
        {
            _genericRepository.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _genericRepository.Update(entity);
        }
    }
}
