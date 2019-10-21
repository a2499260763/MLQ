using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
     public  class Access
    {
        public int id { get; set; }//权限对象id
        public string text { get; set; }//权限对象名称
        public int fuID { get; set; } //父ID
        public string Acurl { get; set; } //地址
        public string state { get; set; }//状态
    }
}
