using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EF.Configer
{
  public class MajorReleaseConfiger: EntityTypeConfiguration<Entity.MajorRelease>
    {
        public MajorReleaseConfiger()
        {
            this.ToTable("MajorRelease");
            this.Property(e => e.MrType).HasMaxLength(60).IsRequired();
            this.Property(e => e.MrRegister).HasMaxLength(60).IsRequired();
            this.Property(e => e.MrChanger).HasMaxLength(60).IsRequired();
            this.Property(e => e.MrDescribe).HasMaxLength(100);
            this.Property(e => e.MrRequired).HasMaxLength(100);
            this.HasRequired(e => e.MajorChen).WithMany().HasForeignKey(e => e.MCID);
            this.HasRequired(e => e.MajorKind).WithMany().HasForeignKey(e => e.MKID);
            this.HasRequired(e => e.oneorganization).WithMany().HasForeignKey(e => e.oneID);
            this.HasRequired(e => e.twoorganization).WithMany().HasForeignKey(e => e.twoID);
            this.HasRequired(e => e.threeorganization).WithMany().HasForeignKey(e => e.threeID);
        }
    }
}
