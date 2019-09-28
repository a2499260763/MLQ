using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EF.Config
{
   public class MajorChenConfig:EntityTypeConfiguration<Entity.MajorChen>
    {
        public MajorChenConfig()
        {
            this.ToTable("MajorChen");
            this.Property(e => e.CID).HasMaxLength(2).IsRequired();
            this.Property(e => e.CName).HasMaxLength(50).IsRequired();
        }
    }
}
