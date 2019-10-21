using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    public class Permissions
    {
        public int Qid
        {
            get; set;
        }//主键
        public int JSID
        {
            get; set;
        }//角色ID
        public int id
        {
            get; set;
        }//权限id
    }
}
