using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EF.Entity;

namespace EF.Configer
{
   public class RoleConfiger : EntityTypeConfiguration<Role>
    {
        public RoleConfiger()
        {
            this.ToTable(nameof(Role));
            this.HasKey(e => e.Role_id);
            this.Property(e => e.Role_Name).HasMaxLength(60);
            this.Property(e => e.Role_shuo).HasMaxLength(60);
            this.Property(e => e.Role_bool).HasMaxLength(60);

        }
    }
}
