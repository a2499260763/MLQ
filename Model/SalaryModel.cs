using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class SalaryModel
    {
        public int SID { get; set; }
        [Required(ErrorMessage = "薪酬项目名称不能为空")]
        public string SName { get; set; }
    }
}
