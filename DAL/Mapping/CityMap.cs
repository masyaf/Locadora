using Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            // Primary Key
            this.HasKey(t => t.CityCode);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(70);

            this.Property(t => t.State)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("Cliente_Cidade");
            this.Property(t => t.CityCode).HasColumnName("CodigoCidade");
            this.Property(t => t.Name).HasColumnName("NomeCidade");
            this.Property(t => t.State).HasColumnName("UfCidade");
        }
    }
}
