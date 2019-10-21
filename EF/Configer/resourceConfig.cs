using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EF.Entity;
namespace EF.Configer
{
    class resourceConfig:EntityTypeConfiguration<resource>
    {
        public resourceConfig()
        {
            this.ToTable(nameof(resource));
            this.HasKey(e => e.RCode);
            this.Property(e => e.oneCodeName).HasMaxLength(1000).IsRequired();
            this.Property(e => e.twoCodeName).HasMaxLength(1000).IsRequired();
            this.Property(e => e.threeCodeName).HasMaxLength(1000).IsRequired();
            this.Property(e => e.MKName).HasMaxLength(1000).IsRequired();
            this.Property(e => e.CName).HasMaxLength(1000).IsRequired();
            this.Property(e => e.MWei).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RName).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RSex).HasMaxLength(1000).IsRequired();
            this.Property(e => e.REmail).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RPhone).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RQQ).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RCellphone).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RAddress).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RPostcode).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RNationality).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RBirthplace).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RBirthday).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RNation).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RFaith).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RPolitics).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RIDKA).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RSecurity).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RAge).IsRequired();
            this.Property(e => e.RBackground).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RYears).IsRequired();
            this.Property(e => e.REducation).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RSalary).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RBank).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RAccounts).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RRegistrant).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RInputting).IsRequired();
            this.Property(e => e.Rstrong).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RHobby).HasMaxLength(1000).IsRequired();
            this.Property(e => e.Rcurriculum).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RFamily).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RRemark).HasMaxLength(1000).IsRequired();

            this.Property(e => e.RRCode).HasMaxLength(1000);
            this.Property(e => e.RRBasicCount);
            this.Property(e => e.RRShouldCount);
            this.Property(e => e.RRActualCount);
            this.Property(e => e.RRTransfer).HasMaxLength(1000);
            this.Property(e => e.RRMotivateCount).HasMaxLength(1000);
            this.Property(e => e.RRTrainCount).HasMaxLength(1000);
            this.Property(e => e.RRAlterationCount).HasMaxLength(1000);
            this.Property(e => e.RPhoto).HasMaxLength(1000);
            this.Property(e => e.RAccessory).HasMaxLength(1000);
            this.Property(e => e.RState).HasMaxLength(1000).IsRequired();
            this.Property(e => e.RRecombination).HasMaxLength(1000);
            this.Property(e => e.RRecombinationDate).HasMaxLength(1000);
            this.Property(e => e.RAlteration).HasMaxLength(1000);
            this.Property(e => e.RAlterationDate).HasMaxLength(1000);
            this.Property(e => e.RChangeDate);
            this.Property(e => e.RDelDate).HasMaxLength(1000);
            this.Property(e => e.RReplyDate).HasMaxLength(1000);
            this.Property(e => e.RRState).IsRequired();
        }
    }
}
