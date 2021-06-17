using Dapper;
using DapperCv.DataAccess.Interfaces;
using DapperCv.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperCv.DataAccess.Concrete.Dapper
{
    public class DpSocialMediaRepository : DpGenericRepository<SocialMediaIcon>, ISocialMediaDal
    {
        private readonly IDbConnection _dbConnection;

        //Generic Repo dbConnection beklediği için bu şekilde bir çözüm bulduk
        public DpSocialMediaRepository(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<SocialMediaIcon> GetByUserId(int userId)
        {
            return _dbConnection.Query<SocialMediaIcon>("select * from SocialMediaIcons where AppUserId=@userId",new {userId=userId});
        }
    }
}
