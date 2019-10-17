using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EF.Configer
{
  public  class MianShiConfiger:EntityTypeConfiguration<MianShi>
    {
        public MianShiConfiger()
        {
            this.ToTable("MianShi");
            this.Property(e => e.JlAdds).HasMaxLength(50).IsRequired();
            this.Property(e => e.MCName).HasMaxLength(50).IsRequired();
            this.Property(e => e.MKName).HasMaxLength(50).IsRequired();
            this.Property(e => e.ZPName).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlName).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlSex).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlEmail).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlDianHua).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlJiaTingDianHua).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlShouJi).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlYouBian).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlGuoJi).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlBreathAdds).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlBreathDay).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlMingZu).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlZongJioaXingYang).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlZhengZhiMianMao).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlEntityCond).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlBiYanShooln).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlXueli).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlJiaoYvYean).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlXueLiZhuanYe).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlTeChang).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlAiHoa).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlGeRenLvLi).HasMaxLength(50).IsRequired();
            this.Property(e => e.JlBeiZhu).HasMaxLength(50).IsRequired();
        }
    }
}
