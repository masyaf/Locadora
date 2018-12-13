using Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class TypeMovieMap : EntityTypeConfiguration<TypeMovie>
    {
        public TypeMovieMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeMovieCode);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Filme_Tipo");
            this.Property(t => t.TypeMovieCode).HasColumnName("CodigoTipo");
            this.Property(t => t.Name).HasColumnName("NomeTipo");
            this.Property(t => t.Value).HasColumnName("ValorTipo");
            this.Property(t => t.Day).HasColumnName("DiaTipo");
            this.Property(t => t.Fine).HasColumnName("MultaTipo");
        }
    }
}
