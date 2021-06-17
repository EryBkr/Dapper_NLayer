using DapperCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.DataAccess.Interfaces
{
    public interface ISocialMediaDal : IGenericRepository<SocialMediaIcon>
    {
        IEnumerable<SocialMediaIcon> GetByUserId(int userId);
    }
}
