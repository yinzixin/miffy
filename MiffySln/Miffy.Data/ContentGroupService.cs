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
    public static class ContentGroupService
    {
        public static void Create(ContentGroup model)
        {
            using (var conn = Database.GetConn())
            {
                conn.Insert(model);
            }
        }

        public static List<ContentGroup> Get(int uid)
        {
            using(var conn=Database.GetConn())
            {
                var sql = "select * from ContentGroup where isDelete=0 and uid=@uid";
                return conn.Query<ContentGroup>(sql, new { uid = uid }).ToList();
            }
        }
    }
}
