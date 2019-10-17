using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class RoleModel
    {

        public int Role_id { get; set; }
        [Required(ErrorMessage = "角色名称不能为空")]
        public string Role_Name { get; set; }
        [Required(ErrorMessage = "角色说明不能为空")]
        public string Role_shuo { get; set; }
        public string Role_bool { get; set; }
    }
}
