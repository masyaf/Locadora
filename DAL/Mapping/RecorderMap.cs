using Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class RecorderMap : EntityTypeConfiguration<Recorder>
    {
        public RecorderMap()
        {
            // Primary Key
            this.HasKey(t => t.RecorderCode);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Filme_Gravadora");
            this.Property(t => t.RecorderCode).HasColumnName("CodigoGravadora");
            this.Property(t => t.Name).HasColumnName("NomeGravadora");
        }
    }
}
