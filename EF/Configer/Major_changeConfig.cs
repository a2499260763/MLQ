using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EF.Entity;

namespace EF.Configer
{
   public class Major_changeConfig : EntityTypeConfiguration<Entity.Major_change>
    {
        public Major_changeConfig()
        {
            this.ToTable(nameof(Major_change));
            this.HasKey(e => e.major_id);
            this.Property(e => e.first_kind_id);
            this.Property(e => e.first_kind_name).HasMaxLength(60);

            this.Property(e => e.second_kind_id);
            this.Property(e => e.second_kind_name).HasMaxLength(60);

            this.Property(e => e.third_kind_id);
            this.Property(e => e.third_kind_name).HasMaxLength(60);

            this.Property(e => e.major_kind_id);
            this.Property(e => e.major_kind_name).HasMaxLength(60);

            this.Property(e => e.major_id);
            this.Property(e => e.major_name).HasMaxLength(60);

            this.Property(e => e.new_first_kind_id);
            this.Property(e => e.new_first_kind_name).HasMaxLength(60);

            this.Property(e => e.new_second_kind_id);
            this.Property(e => e.new_second_kind_name).HasMaxLength(60);

            this.Property(e => e.new_third_kind_id);
            this.Property(e => e.new_third_kind_name).HasMaxLength(60);

            this.Property(e => e.new_major_kind_id);
            this.Property(e => e.new_major_kind_name).HasMaxLength(60);

            this.Property(e => e.new_major_id);
            this.Property(e => e.new_major_name).HasMaxLength(60);

            this.Property(e => e.human_id);
            this.Property(e => e.human_name).HasMaxLength(60);

            this.Property(e => e.salary_standard_id);
            this.Property(e => e.salary_standard_name).HasMaxLength(60);


            this.Property(e => e.new_salary_sum);
            this.Property(e => e.change_reason).HasMaxLength(60);

            this.Property(e => e.check_reason).HasMaxLength(60);
            this.Property(e => e.check_status);

            this.Property(e => e.register).HasMaxLength(60);
            this.Property(e => e.checker).HasMaxLength(60);
            this.Property(e => e.regist_time).HasMaxLength(60);
            this.Property(e => e.check_time).HasMaxLength(60);


        }
    }
}
