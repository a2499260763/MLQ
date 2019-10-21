using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entity
{
    public class MajorKind//职位分类设置表
    {
        public int Id { get; set; }//标识列主键

        public string MKID { get; set; }//职位分类编号

        public string MKName { get; set; }//职位分类名称
    }
}
