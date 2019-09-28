using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EF.Config
{
    class MajorKindConfig:EntityTypeConfiguration<Entity.MajorKind>
    {
        public MajorKindConfig()
        {
            this.ToTable("MajorKind");
            this.Property(e => e.MKID).HasMaxLength(2).IsRequired();
            this.Property(e => e.MKName).HasMaxLength(60).IsRequired();
        }
    }
}
