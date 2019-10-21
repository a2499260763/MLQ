using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entity
{
   public class Salary//薪酬项目设置
    {
        public int SID { get; set; }//主键标识列

        public string SName { get; set; }//薪酬项目名称
    }
}
