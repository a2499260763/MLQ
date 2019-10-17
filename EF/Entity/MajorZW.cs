using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entity
{
   public class MajorZW
    {
        public int Id { get; set; }

        public string MKID { get; set; }       //职位分类编号01

        public string MKName { get; set; }    //职位分类名称

        public string MWID { get; set; } //职位名称编号

        public string MWName { get; set; } //职位名称


    }
}
