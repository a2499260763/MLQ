using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EF.Entity;

namespace EF.Configer
{
   public class MajorCondiger:EntityTypeConfiguration<MajorZW>
    {
        public MajorCondiger()
        {
            this.ToTable("Major");
            this.Property(e => e.MKID).HasMaxLength(50).IsRequired();
            this.Property(e => e.MKName).HasMaxLength(50).IsRequired();
            this.Property(e => e.MWID).HasMaxLength(50).IsRequired();
            this.Property(e => e.MWName).HasMaxLength(50).IsRequired();
        }
    }
}
