using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DammioCodeFirstNewDatabase
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string Name { get; set;}
        public string Url { get; set; } // thêm thuộc tính mới --- dammio.com
        public virtual List<Post> Posts { get; set; }
    }
}
