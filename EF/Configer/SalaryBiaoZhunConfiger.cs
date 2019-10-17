using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EF.Configer
{
   public class SalaryBiaoZhunConfiger:EntityTypeConfiguration<SalaryBiaoZhun>
    {
        public SalaryBiaoZhunConfiger()
        {
            this.ToTable("SalaryBiaoZhun");
        }
    }
}
