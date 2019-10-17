using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EF.Entity;
namespace EF.Configer
{
    class oneorganizationConfiger: EntityTypeConfiguration<oneorganization>
    {
        public oneorganizationConfiger()
        {
            this.ToTable(nameof(oneorganization));
            this.HasKey(e => e.oneID);
            //this.Property(e => e.oneCode).HasMaxLength(50).IsRequired();
            this.Property(e => e.oneCodeName).HasMaxLength(50).IsRequired();
            //this.Property(e => e.oneCoderemuneration).HasMaxLength(50).IsRequired();
            //this.Property(e => e.oneCodemarket).HasMaxLength(50).IsRequired();
        }
    }
}
