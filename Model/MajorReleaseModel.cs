using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public class MajorReleaseModel
    {
        public int Id { get; set; }

        public int oneID { get; set; }

        public int twoID { get; set; }

        public int threeID { get; set; }

        public int MCID { get; set; }

        public int MKID { get; set; }

        public int MrAmount { get; set; }

        public string MrType { get; set; }

        public DateTime MrOverTime { get; set; }

        public string MrRegister { get; set; }

        public string MrChanger { get; set; }

        public DateTime MrRegistTime { get; set; }

        public DateTime MrChangeTime { get; set; }

        public string MrDescribe { get; set; }

        public string MrRequired { get; set; }
    }
}
