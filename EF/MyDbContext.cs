using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Configer;
using System.Reflection;
using EF.Entity;
namespace EF
{
   public class MyDbContext:DbContext
    {
        public MyDbContext():base("sql")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDbContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // modelBuilder.Configurations.Add(new StudentConfiger());
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Student> Student { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<PublicChar> PublicChar { get; set; }

        public DbSet<Salary> Salary { get; set; }
        public DbSet<Major> Major { get; set; }
        public DbSet<MajorChen> MajorChen { get; set; }
        public DbSet<MajorKind> MajorKind { get; set; }
        public DbSet<oneorganization> oneorganization { get; set; }
        public DbSet<twoorganization> twoorganization { get; set; }
        public DbSet<threeorganization> threeorganization { get; set; }
        public DbSet<resource> resource { get; set; }
        public DbSet<MajorWei> MajorWei { get; set; }

        public DbSet<Entity.MajorKind> MajorKind { get; set; }

        public DbSet<Entity.MajorChen> MajorChen { get; set; }

        public DbSet<MajorRelease> MajorRelease { get; set; }

        public DbSet<MajorZW> Major { get; set; }

        public DbSet<Jl> Jl { get; set; }

        public DbSet<MianShi> MianShi { get; set; }

        public DbSet<LuYong> LuYong { get; set; }

        public DbSet<SalaryBiaoZhun> SalaryBiaoZhun { get; set; }
        public DbSet<Role> Role { get; set; }

        public DbSet<Major_change> Major_change { get; set; }

        public DbSet<Access> Access { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
    }
}
