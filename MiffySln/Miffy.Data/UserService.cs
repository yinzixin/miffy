using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miffy.Model;
using Dapper;
using DapperExtensions;

namespace Miffy.Data
{
    public class UserService
    {
        public static void Create(User model)
        {
            using(var conn=Database.GetConn())
            {
                conn.Insert(model);
            }
        }
        public static User GetByDomain(string domain)
        {
            using (var conn = Database.GetConn())
            {
                var sql = "select * from User where isPause=0 and domain=@domain and expireAt>@now";
                var user = conn.Query<User>(sql, new
                {
                    now = DateTime.Now,
                    domain = domain
                }).SingleOrDefault();

                return user;
            }
        }

        public static User Login(string p1, string p2)
        {
            throw new NotImplementedException();
        }
    }
}
