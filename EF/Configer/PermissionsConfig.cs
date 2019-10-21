using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EF.Config
{
    public class PermissionsConfig:EntityTypeConfiguration<Permissions>
    {
        public PermissionsConfig()
        {
            this.ToTable("Permissions");
            this.HasKey(e => e.Qid);
        }
    }
}
