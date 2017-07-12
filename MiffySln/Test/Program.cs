using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miffy.Model;
using Miffy.Data;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            configGroup();
            addUser();
        }

        static void addUser()
        {

            var u = new User
            {
                CreateTime = DateTime.Now,
                ExpireAt = new DateTime(2020, 1, 1),
                Mobile = "13405764898",
                QQ = "278308924",
                Wechat = "yinzixin1985",
                Password = "123456",
                Domain="localhost"
            };

            UserService.Create(u);
        }

        static void configGroup()
        {
            var g = new ContentGroup { FriendlyName = "米菲新闻", Name = "news",UserID=1 };
            ContentGroupService.Create(g);

            g = new ContentGroup { FriendlyName = "首页轮播", Name = "slide", UserID = 1 };
            ContentGroupService.Create(g);
            g = new ContentGroup { FriendlyName = "产品展示", Name = "product", UserID = 1 };
            ContentGroupService.Create(g);
            g = new ContentGroup { FriendlyName = "产品商城", Name = "shop", UserID = 1 };
            ContentGroupService.Create(g);
            g = new ContentGroup { FriendlyName = "商学院", Name = "school", UserID = 1 };
            ContentGroupService.Create(g);
        }
    }
}
