using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class SalaryBiaoZhunModel
    {
        public int Id { get; set; }

        public string SBZBianHao { get; set; } //薪酬编号

        public double SBZZongE { get; set; } //薪酬总额
        public string SBZName { get; set; } //薪酬标准名称

        public string SBZZhiDingRen { get; set; } //制定人

        public string SBZDengJiRen { get; set; } //登记人

        public string SBZDengJiTime { get; set; } //登记时间

        public string SBZBeiZhu { get; set; } //备注

        public int SalaryChuCaiID { get; set; }  //出差补助ID

        public string SalaryChuCai { get; set; } //出差补助

        public double SBZChuCaiJinE { get; set; } //出差补助金额

        public int SalaryJiaoTongID { get; set; }  //交通补助ID

        public string SalaryJiaoTong { get; set; } //交通

        public double SBZJiaoTongJinE { get; set; } //交通金额

        public string SBZFuHeRen { get; set; } //复核人

        public string SBZFuHeTime { get; set; } //复核时间

        public string SBZFuHeYiJian { get; set; } //复核意见

        public string SBZBianGenTime { get; set; } //变更时间

        public string SBZBianGengRen { get; set; } //变更人

    }
}
