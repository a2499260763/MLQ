using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EF.Entity;
namespace EF.Configer
{
   public class PublicCharConfiger : EntityTypeConfiguration<PublicChar>
    {
        public PublicCharConfiger()
        {
            this.ToTable(nameof(PublicChar));
            this.HasKey(e => e.PID);
            this.Property(e => e.PName).HasMaxLength(50).IsRequired();
            this.Property(e => e.PName).HasMaxLength(50).IsRequired();
        }
    }
}
