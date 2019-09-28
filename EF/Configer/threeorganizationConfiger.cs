using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EF.Entity;
namespace EF.Configer
{
    class threeorganizationConfige:EntityTypeConfiguration<threeorganization>
    {
        public threeorganizationConfige()
        {
            this.ToTable(nameof(threeorganization));
            this.HasKey(e => e.threeID);
            this.Property(e => e.oneName).HasMaxLength(50).IsRequired();
            this.Property(e => e.twoCodeName).HasMaxLength(50).IsRequired();
            this.Property(e => e.threeCode).HasMaxLength(50).IsRequired();
            this.Property(e => e.threeCodeName).HasMaxLength(50).IsRequired();
            this.Property(e => e.threeCodemarket).HasMaxLength(50).IsRequired();
            this.Property(e => e.threeCodepd).IsRequired();


        }
    }
}
