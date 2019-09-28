using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entity
{
    public class threeorganization
    {
        public int threeID { get; set; }//III级机构标识列
        public string oneName { get; set; }//I级机构名称
        public string twoCodeName { get; set; }//II级机构名称
        public string threeCode { get; set; }//III级机构编号
        public string threeCodeName { get; set; }//III级机构名称
        public string threeCodemarket { get; set; }//销售责任人编号（多个编号之间请用"半角逗号"加"一个空格"隔开，如", "）
        public string threeCodepd { get; set; }//是否为零售店（是/否）
    }
}
