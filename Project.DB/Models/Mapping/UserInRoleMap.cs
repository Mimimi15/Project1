using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Project.DB.Models.Mapping
{
    public class UserInRoleMap : EntityTypeConfiguration<UserInRole>
    {
        public UserInRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserInRole");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.RoleId).HasColumnName("RoleId");

            // Relationships
            this.HasRequired(t => t.Role)
                .WithMany(t => t.UserInRoles)
                .HasForeignKey(d => d.RoleId);
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserInRoles)
                .HasForeignKey(d => d.UserId);

        }
    }
}
