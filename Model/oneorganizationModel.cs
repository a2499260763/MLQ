using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class oneorganizationModel
    {
        public int oneID { get; set; }//I级机构标识列
        [Required(ErrorMessage = "I级机构编号不能为空")]
        public string oneCode { get; set; }//I级机构编号
        [Required(ErrorMessage = "I级机构名称不能为空")]
        public string oneCodeName { get; set; }//I级机构名称
        [Required(ErrorMessage = "薪酬发放责任人编号不能为空")]
        public string oneCoderemuneration { get; set; }//薪酬发放责任人编号（多个编号之间请用"半角逗号"加"一个空格"隔开，如", "）
        [Required(ErrorMessage = "销售责任人编号不能为空")]
        public string oneCodemarket { get; set; }//销售责任人编号（多个编号之间请用"半角逗号"加"一个空格"隔开，如", "）
        
    
    }
}
