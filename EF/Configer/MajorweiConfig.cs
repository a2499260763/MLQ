using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EF.Entity;
namespace EF.Configer
{
    public class MajorweiConfig:EntityTypeConfiguration<Entity.MajorWei>
    {
        public MajorweiConfig()
        {
            this.ToTable(nameof(MajorWei));
            this.HasKey(e => e.id);
            this.Property(e => e.MWei).HasMaxLength(50).IsRequired();
        }
    }
}
