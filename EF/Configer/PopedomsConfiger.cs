using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Entity;

namespace EF.Configer
{
     class PopedomsConfiger : EntityTypeConfiguration<Popedoms>
    {

        public PopedomsConfiger(){

        this.ToTable(nameof(Popedoms));
            this.HasKey(e => e.PopID);
            this.Property(e=>e.PopName).HasMaxLength(60);
    }
    }
}
