using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entity
{
    public class twoorganization
    {
        public int twoID { get; set; }//II机构标识列
        public string oneCodeName { get; set; }//I级机构名称
        public string twoCode { get; set; }//II级机构编号
        public string twoCodeName { get; set; }//II级机构名称
        public string twoCoderemuneration { get; set; }//薪酬发放责任人编号（多个编号之间请用"半角逗号"加"一个空格"隔开，如", "
        public string twoCodemarket { get; set; }//销售责任人编号（多个编号之间请用"半角逗号"加"一个空格"隔开，如", "）

    }
}
