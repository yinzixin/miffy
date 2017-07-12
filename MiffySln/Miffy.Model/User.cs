using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miffy.Model
{
    public class User
    {
        public int ID { get; set; }

        public string Mobile { get; set; }

        public string Password { get; set; }

        public string Wechat { get; set; }

        public string QQ { get; set; }

        public string Domain { get; set; }

        public string Logo { get; set; }

        public DateTime ExpireAt { get; set; }

        public DateTime CreateTime { get; set; }

        public string Memo { get; set;}

        public bool IsPause { get; set; }

        public bool IsDelete { get; set; }
    }
}
