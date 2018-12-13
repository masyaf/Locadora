using Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class LoanMap : EntityTypeConfiguration<Loan>
    {
        public LoanMap()
        {
            // Primary Key
            this.HasKey(t => t.LoanCode);

            // Properties
            // Table & Column Mappings
            this.ToTable("Aluguel");
            this.Property(t => t.LoanCode).HasColumnName("CodigoAluguel");
            this.Property(t => t.DateLoan).HasColumnName("DataAluguel");
            this.Property(t => t.CustomerCode).HasColumnName("CodigoCliente");
            this.Property(t => t.EmployeeCode).HasColumnName("CodigoFuncionario");
            this.Property(t => t.Amount).HasColumnName("TotalAluguel");
            this.Property(t => t.Completed).HasColumnName("Concluido");
            this.Property(t => t.AmountMuclt).HasColumnName("TotalMultaAluguel");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.Loans)
                .HasForeignKey(d => d.CustomerCode);
            this.HasRequired(t => t.Employee)
                .WithMany(t => t.Loans)
                .HasForeignKey(d => d.EmployeeCode);

        }
    }
}
