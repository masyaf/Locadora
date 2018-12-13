
using Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class GenderMap : EntityTypeConfiguration<Gender>
    {
        public GenderMap()
        {
            // Primary Key
            this.HasKey(t => t.GenderCode);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Filme_Genero");
            this.Property(t => t.GenderCode).HasColumnName("CodigoGenero");
            this.Property(t => t.Name).HasColumnName("NomeGenero");
        }
    }
}
