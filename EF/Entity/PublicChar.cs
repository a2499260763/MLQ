using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entity
{
   public class PublicChar//公共属性设置
    {
        public  int PID { get; set; }//主键标识列

        public string PName{ get; set; }//属性名称


        public string Ptype { get; set; }//属性总类
    }
}
