using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Project.Models.Mapping
{
    public class RecordMap : EntityTypeConfiguration<Record>
    {
        public RecordMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ClientId)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.MasterId)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Record");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ClientId).HasColumnName("ClientId");
            this.Property(t => t.MasterId).HasColumnName("MasterId");
            this.Property(t => t.Hour).HasColumnName("Hour");
            this.Property(t => t.Duration).HasColumnName("Duration");

            // Relationships
            this.HasRequired(t => t.AspNetUser)
                .WithMany(t => t.Records)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.AspNetUser1)
                .WithMany(t => t.Records1)
                .HasForeignKey(d => d.MasterId);

        }
    }
}
