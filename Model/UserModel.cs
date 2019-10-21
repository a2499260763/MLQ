using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class UserModel
    {

        public int user_id { get; set; }
        [Required(ErrorMessage = "用户名称不能为空")]
        public string user_name { get; set; }
        [Required(ErrorMessage = "真实姓名不能为空")]
        public string user_true_name { get; set; }
        [Required(ErrorMessage = "用户密码不能为空")]
        public string user_password { get; set; }
        public int Role_id { get; set; }

        public string Role_Name { get; set; }
    }
}
