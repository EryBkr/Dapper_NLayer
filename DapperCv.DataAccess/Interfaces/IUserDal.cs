using DapperCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.DataAccess.Interfaces
{
    public interface IUserDal:IGenericRepository<AppUser>
    {
        /// <summary>
        /// User varsa true yoksa false dönecek
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool CheckUser(string userName, string password);

        AppUser FindByName(string userName);
    }
}
