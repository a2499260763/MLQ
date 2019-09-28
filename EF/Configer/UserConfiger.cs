using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Configer
{
    class UserConfiger : EntityTypeConfiguration<User>
    {
        public UserConfiger()
        {
            this.ToTable(nameof(User));
            this.HasKey(e => e.user_id);
            this.Property(e=>e.user_name).HasMaxLength(60);
            this.Property(e => e.user_password).HasMaxLength(60);
            this.Property(e => e.user_true_name).HasMaxLength(60);
        }
    }
}
