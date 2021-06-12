using DapperCv.Business.Interfaces;
using DapperCv.DataAccess.Concrete.Dapper;
using DapperCv.DataAccess.Interfaces;
using DapperCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.Concrete
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
        private readonly IGenericRepository<AppUser> _genericRepository;
        private readonly IUserDal _userRepository;

        public AppUserManager(IGenericRepository<AppUser> genericRepository, IUserDal userRepository) :base(genericRepository)
        {
            _genericRepository = genericRepository;
            _userRepository = userRepository;
        }

        public bool CheckUser(string userName, string password)
        {
            return _userRepository.CheckUser(userName,password);
        }

        public AppUser FindByName(string userName)
        {
            return _userRepository.FindByName(userName);
        }
    }
}
