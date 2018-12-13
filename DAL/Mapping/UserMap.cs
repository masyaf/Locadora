
using Models.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<User>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.UserCode);

            this.Property(t => t.Login)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Usuario");
            this.Property(t => t.UserCode).HasColumnName("CodigoUsuario");
            this.Property(t => t.Login).HasColumnName("Login");
            this.Property(t => t.Password).HasColumnName("Senha");
        }
    }
}
