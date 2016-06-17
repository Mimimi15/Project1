using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Project.DB.Models.Mapping;
using System.Collections.Generic;

namespace Project.DB.Models
{
    public partial class DBforLogContext : DbContext
    {
        static DBforLogContext()
        {
            Database.SetInitializer<DBforLogContext>(null);
        }

        public DBforLogContext()
            : base("Name=DBforLogContext")
        {
        }

        public DbSet<Record> Records { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new RecordMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserInRoleMap());
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
    }
}
