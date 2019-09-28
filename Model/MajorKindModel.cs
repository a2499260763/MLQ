using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class MajorKindModel
    {
        public int Id { get; set; }

        public string MKID { get; set; }


        //[StringLength(4, ErrorMessage = "名字不能超过四个字")]
        [Required(ErrorMessage = "职位分类名称不能为空")]
        public string MKName { get; set; }
    }
}
