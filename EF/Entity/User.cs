using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entity
{
    public class User
    {
        public int user_id { get; set; }
        public string user_name { get; set; }

        public string user_true_name { get; set; }
        public string user_password { get; set; }

        public int Role_id { get; set; }

        public string Role_Name { get; set; }
    }
}
