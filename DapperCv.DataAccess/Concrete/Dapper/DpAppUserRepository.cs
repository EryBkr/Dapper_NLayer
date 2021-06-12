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
    public class DpAppUserRepository : DpGenericRepository<AppUser>, IUserDal
    {
        private readonly IDbConnection _dbConnection;

        //Generic Repo dbConnection beklediği için bu şekilde bir çözüm bulduk
        public DpAppUserRepository(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public bool CheckUser(string userName, string password)
        {
            var user = _dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUsers where UserName=@userName and Password=@password", new { userName = userName, password = password });

            return user != null;
        }

        public AppUser FindByName(string userName)
        {
            var user = _dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUsers where  UserName=@userName", new
            {
                userName = userName
            });

            return user;
        }
    }
}
