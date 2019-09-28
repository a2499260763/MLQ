using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EF.Entity;
namespace EF.Configer
{
   public class SalaryConfiger : EntityTypeConfiguration<Salary>
    {
        public SalaryConfiger()
        {
            this.ToTable(nameof(Salary));
            this.HasKey(e => e.SID);
            this.Property(e => e.SName).HasMaxLength(50).IsRequired();
        }
    }
}
