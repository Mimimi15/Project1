using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Project.Models.Mapping;

namespace Project.Models
{
    public partial class aspnetProject20160617103407Context : DbContext
    {
        static aspnetProject20160617103407Context()
        {
            Database.SetInitializer<aspnetProject20160617103407Context>(null);
        }

        public aspnetProject20160617103407Context()
            : base("Name=aspnetProject20160617103407Context")
        {
        }

        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AspNetRoleMap());
            modelBuilder.Configurations.Add(new AspNetUserClaimMap());
            modelBuilder.Configurations.Add(new AspNetUserLoginMap());
            modelBuilder.Configurations.Add(new AspNetUserMap());
            modelBuilder.Configurations.Add(new RecordMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
