using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miffy.Model
{
   public class ContentGroup
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string FriendlyName { get; set; }

        public int UserID { get; set; }
        public bool IsDelete { get; set; }

        public List<Content> Contents { get; set; }
    }


   public class ContentGroupMapper : ClassMapper<ContentGroup>
   {
       public ContentGroupMapper()
       {
           Table("ContentGroup");
           Map(m => m.Contents).Ignore();

           AutoMap();
       }
   }
}
