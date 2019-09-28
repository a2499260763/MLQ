using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EF.Config
{
   public class MajorConfig:EntityTypeConfiguration<Entity.Major>
    {
        public MajorConfig()
        {
            this.ToTable("Major");
            this.Property(e => e.MKID).IsRequired();
            this.Property(e => e.MCID).IsRequired();
            this.HasRequired(e => e.MajorKind).WithMany().HasForeignKey(e => e.MKID);
            this.HasRequired(e => e.MajorChen).WithMany().HasForeignKey(e => e.MCID);
        }
    }
}
