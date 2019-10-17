using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EF.Configer
{
  public  class EngageTypeConfig:EntityTypeConfiguration<Entity.EngageType>
    {
        public EngageTypeConfig()
        {
            this.ToTable("EngageType");
            this.Property(e => e.TName).HasMaxLength(50).IsRequired();
        }
    }
}
