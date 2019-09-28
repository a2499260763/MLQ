using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EF.Entity;
namespace EF.Configer
{
    class twoorganizationConfiger:EntityTypeConfiguration<twoorganization>
    {
        public twoorganizationConfiger()
        {
            this.ToTable(nameof(twoorganization));
            this.HasKey(e => e.twoID);
            this.Property(e => e.oneCodeName).HasMaxLength(50).IsRequired();
            this.Property(e => e.twoCode).HasMaxLength(50).IsRequired();
            this.Property(e => e.twoCodeName).HasMaxLength(50).IsRequired();
            this.Property(e => e.twoCoderemuneration).HasMaxLength(50).IsRequired();
            this.Property(e => e.twoCodemarket).HasMaxLength(50).IsRequired();
            
        }
    }
}
