﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entity
{
   public class Major//职位设置表
    {
        public int Id { get; set; }//标识列 主键

        public int MKID { get; set; }//

        public int MCID { get; set; }//
        public virtual MajorChen MajorChen { get; set; }//
        public virtual MajorKind MajorKind { get; set; }//
    }
}
