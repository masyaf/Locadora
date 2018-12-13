
using Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerCode);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DocumentRg)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DocumentCpf)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Number)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.Neighborhood)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Cliente");
            this.Property(t => t.CustomerCode).HasColumnName("CodigoCliente");
            this.Property(t => t.Name).HasColumnName("NomeCliente");
            this.Property(t => t.DocumentRg).HasColumnName("RgCliente");
            this.Property(t => t.DocumentCpf).HasColumnName("CpfCliente");
            this.Property(t => t.Address).HasColumnName("EnderecoCliente");
            this.Property(t => t.Number).HasColumnName("NumeroCliente");
            this.Property(t => t.Neighborhood).HasColumnName("BairroCliente");
            this.Property(t => t.CityCode).HasColumnName("CodigoCidade");
            this.Property(t => t.DateBirth).HasColumnName("DataNascimentoCliente");
            this.Property(t => t.Phone).HasColumnName("TelefoneCliente");

            // Relationships
            this.HasRequired(t => t.City)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.CityCode);

        }
    }
}
