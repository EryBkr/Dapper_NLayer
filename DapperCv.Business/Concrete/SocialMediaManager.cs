using DapperCv.Business.Interfaces;
using DapperCv.DataAccess.Interfaces;
using DapperCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.Concrete
{
    public class SocialMediaManager : GenericManager<SocialMediaIcon>, ISocialMediaService
    {
        private readonly IGenericRepository<SocialMediaIcon> _genericRepository;
        private readonly ISocialMediaDal _socialDal;

        public SocialMediaManager(IGenericRepository<SocialMediaIcon> genericRepository, ISocialMediaDal socialDal) : base(genericRepository)
        {
            _genericRepository = genericRepository;
            _socialDal = socialDal;
        }

        public IEnumerable<SocialMediaIcon> GetByUserId(int userId)
        {
            return _socialDal.GetByUserId(userId);
        }
    }
}
