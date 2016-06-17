using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Project.DB.Models.Mapping;
using Project.DB.Models;


namespace Project.DB.Configurations
{
    public partial class ProjectDbContext : DbContext, IProjectDbContext
    {
        static ProjectDbContext()
        {
            Database.SetInitializer<ProjectDbContext>(null);
        }

        public ProjectDbContext()
            : base("Name=DefaultConnection")
        {
        }

        public IDbSet<AspNetRole> AspNetRoles { get; set; }
        public IDbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public IDbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public IDbSet<AspNetUser> AspNetUsers { get; set; }
        public IDbSet<Record> Records { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AspNetRoleMap());
            modelBuilder.Configurations.Add(new AspNetUserClaimMap());
            modelBuilder.Configurations.Add(new AspNetUserLoginMap());
            modelBuilder.Configurations.Add(new AspNetUserMap());
            modelBuilder.Configurations.Add(new RecordMap());
        }

        public void Update<T>(T entity) where T : BaseEntity
        {
            Set<T>().Add(entity);
        }

        public void Update<T>(IEnumerable<T> entities) where T : BaseEntity
        {
            Set<T>().AddRange(entities);
        }

        private void SetStates()
        {
            foreach (var dbEntry in ChangeTracker.Entries<BaseEntity>())
            {
                dbEntry.State = dbEntry.Entity.State;
            }
        }
        private void RemoveStates()
        {
            foreach (var dbEntry in ChangeTracker.Entries<BaseEntity>())
            {
                dbEntry.Entity.State = EntityState.Unchanged;
            }
        }

        public override int SaveChanges()
        {
            SetStates();
            int result = base.SaveChanges();
            RemoveStates();
            return result;
        }


        public override async Task<int> SaveChangesAsync()
        {
            SetStates();
            int result = await base.SaveChangesAsync();
            RemoveStates();
            return result;
        }
    }
}
