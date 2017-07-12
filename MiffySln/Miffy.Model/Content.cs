using DapperExtensions.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miffy.Model
{
    public class Content
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string title { get; set; }

        public string Url { get; set; }

        public string Text { get; set; }

        public string Photos { get; set; }

        public int GroupID { get; set; }

        public int UserID { get; set; }

        public int Seq { get; set; }

        public int PV { get; set; }

        public DateTime CreateTime { get; set; }

        public string GroupTitle {get;set;}

    }


    public class ContentMapper : ClassMapper<Content>
    {
        public ContentMapper()
        {
            Table("Content");
            Map(m => m.GroupTitle).Ignore();
          
            AutoMap();
        }
    }
}
