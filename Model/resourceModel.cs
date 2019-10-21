using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class resourceModel
    {
        public string RCode { get; set; }//档案编号
        public string oneCodeName { get; set; }//I级机构名称
        public string twoCodeName { get; set; }//II级机构名称
        public string threeCodeName { get; set; }//III级机构名称
        public string MKName { get; set; }//职位分类名称
        public string CName { get; set; }//职位名称
        public string MWei { get; set; }//职称名称
        public string RName { get; set; }//姓名
        public string RSex { get; set; }//性别
        public string REmail { get; set; }//邮箱
        public string RPhone { get; set; }//电话
        public string RQQ { get; set; }//QQ
        public string RCellphone { get; set; }//手机
        public string RAddress { get; set; }//住址
        public string RPostcode { get; set; }//邮编
        public string RNationality { get; set; }//国籍
        public string RBirthplace { get; set; }//出生地
        public string RBirthday { get; set; }//生日
        public string RNation { get; set; }//民族
        public string RFaith { get; set; }//宗教信仰
        public string RPolitics { get; set; }//政治面貌
        public string RIDKA { get; set; }//身份证号码
        public string RSecurity { get; set; }//社会保障号码	
        public int RAge { get; set; }//年龄
        public string RBackground { get; set; }//学历
        public int RYears { get; set; }//教育年限
        public string REducation { get; set; }//学历专业
        public string RSalary { get; set; }//薪酬标准
        public string RBank { get; set; }//开户行
        public string RAccounts { get; set; }//帐号
        public string RRegistrant { get; set; }//登记人
        public DateTime RInputting { get; set; }//建档时间
        public string Rstrong { get; set; }//特长
        public string RHobby { get; set; }//爱好
        public string Rcurriculum { get; set; }//个人履历
        public string RFamily { get; set; }//家庭关系信息
        public string RRemark { get; set; }//备注
        public string RRCode { get; set; }//薪酬标准编号
        public decimal RRBasicCount { get; set; }//基本薪酬总额
        public decimal RRShouldCount { get; set; }//应发薪酬总额
        public decimal RRActualCount { get; set; }//实发薪酬总额
        public string RRTransfer { get; set; }//调动次数
        public string RRMotivateCount { get; set; }//激励累计次数
        public string RRTrainCount { get; set; }//培训累计次数
        public string RRAlterationCount { get; set; }//档案变更累计次数
        public string RPhoto { get; set; }//相片
        public string RAccessory { get; set; }//附件名称
        public string RState { get; set; }//复核状态
        public string RRecombination { get; set; }//档案复核人
        public string RRecombinationDate { get; set; }//档案复核时间
        public string RAlteration { get; set; }//档案变更人
        public string RAlterationDate { get; set; }//档案变更时间
        public DateTime RChangeDate { get; set; }//档案最近更改时间
        public string RDelDate { get; set; }//档案删除时间
        public string RReplyDate { get; set; }//档案恢复时间
        public int RRState { get; set; }//档案状态
    }
}
