using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EF.Config
{
    public class AccessConfig:EntityTypeConfiguration<Access>
    {
        public AccessConfig()
        {
            this.ToTable("Access");
            this.Property(e => e.text).HasMaxLength(60);
            this.Property(e => e.Acurl).HasMaxLength(60);
            this.Property(e => e.state).HasMaxLength(60);
        }
    }
}
