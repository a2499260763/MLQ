using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entity
{
    public class grant //薪酬发放登记表
    {
        public int GID { get; set; } //主键，自动增长列      
        public string GCode { get; set; } //薪酬发放编号         
        public string GStandard { get; set; } //薪酬标准单编号
        public string oneCode { get; set; } //一级机构编号
        public string oneCodeName { get; set; } //一级机构名称
        public string twoCode { get; set; } //二级机构编号
        public string twoCodeName { get; set; } //二级机构名称
        public string threeCode { get; set; } //三级机构编号
        public string threeCodeName { get; set; } //三级机构名称
        public int GCount { get; set; } //总人数
        public decimal GRemunerationCount { get; set; } //标准薪酬总金额
        public decimal GContext { get; set; } //实发总金额
        public string GRegistrant { get; set; } //登记人
        public DateTime GRegistrantDate { get; set; } //登记时间
        public string GReviewer { get; set; } //复核人
        public DateTime GReviewerDate { get; set; } //复核时间
        public string GState { get; set; } //复核状态
    }
}
