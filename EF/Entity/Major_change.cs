using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entity
{
   public class Major_change
    {
        public int mch_id { get; set; }//主键，自动增长列
        public int first_kind_id { get; set; }//一级机构编号
        public string first_kind_name { get; set; }//一级机构名称     
        public int second_kind_id { get; set; }//二级机构编号   
        public string second_kind_name { get; set; }//二级机构名称    
        public int third_kind_id { get; set; }//三级机构编号  

        public string third_kind_name { get; set; }//三级机构名称      
        public int major_kind_id { get; set; }//职位分类编号   
        public string major_kind_name { get; set; }//职位分类名称     

        public int major_id { get; set; }//职位编号    
        public string major_name { get; set; }//职位名称     
        public int new_first_kind_id { get; set; }//新一级机构编号     
        public string new_first_kind_name { get; set; }//新一级机构名称     
        public int new_second_kind_id { get; set; }//新二级机构编号     
        public string new_second_kind_name { get; set; }//新二级机构名称     
        public int new_third_kind_id { get; set; }//新三级机构编号     
        public string new_third_kind_name { get; set; }//新三级机构名称     
        public int new_major_kind_id { get; set; }//新职位分类编号     
        public string new_major_kind_name { get; set; }//新职位分类名称     

        public int new_major_id { get; set; }//新职位编号     
        public string new_major_name { get; set; }//新职位名称  

        public int human_id { get; set; }//人力资源档案编号     
        public string human_name { get; set; }//姓名  

        public int salary_standard_id { get; set; }//薪酬标准编号     
        public string salary_standard_name { get; set; }//薪酬标准名称  

        public decimal salary_sum { get; set; }//薪酬总额     
        public int new_salary_standard_id { get; set; }//新薪酬标准编号     
        public string new_salary_standard_name { get; set; }//新薪酬标准名称  

        public decimal new_salary_sum { get; set; }//新薪酬总额 

        public string change_reason { get; set; }//调动原因  

        public string check_reason { get; set; }//审核通过意见  

        public bool check_status { get; set; }//复核通过状态

        public string register { get; set; }//登记人  

        public string checker { get; set; }//复核人  

        public string regist_time { get; set; }//登记时间  

        public string check_time { get; set; }//复核时间   
    }
}
