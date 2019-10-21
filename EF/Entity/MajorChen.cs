using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entity
{
   public class MajorChen//职称设置表
    {
        public int Id { get; set; }//标识列主键

        public string CID { get; set; }//职称编号

        public string CName { get; set; }//职称名称
    }
}
