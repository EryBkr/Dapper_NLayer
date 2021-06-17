using DapperCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.Business.Interfaces
{
   public interface ISocialMediaService:IGenericService<SocialMediaIcon>
    {
        IEnumerable<SocialMediaIcon> GetByUserId(int userId);
    }
}
