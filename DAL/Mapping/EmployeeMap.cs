using Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class FuncionarioMap : EntityTypeConfiguration<Employee>
    {
        public FuncionarioMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeCode);

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
            this.ToTable("Funcionario");
            this.Property(t => t.EmployeeCode).HasColumnName("CodigoFuncionario");
            this.Property(t => t.Name).HasColumnName("NomeFuncionario");
            this.Property(t => t.DocumentRg).HasColumnName("RgFuncionario");
            this.Property(t => t.DocumentCpf).HasColumnName("CpfFuncionario");
            this.Property(t => t.Address).HasColumnName("EnderecoFuncionario");
            this.Property(t => t.Number).HasColumnName("NumeroFuncionario");
            this.Property(t => t.Neighborhood).HasColumnName("BairroFuncionario");
            this.Property(t => t.CityCode).HasColumnName("CodigoCidade");
            this.Property(t => t.DateBirth).HasColumnName("DataNascimentoFuncionario");
            this.Property(t => t.Phone).HasColumnName("TelefoneFuncionario");

            // Relationships
            this.HasRequired(t => t.City)
                .WithMany(t => t.Employees)
                .HasForeignKey(d => d.CityCode);

        }
    }
}
