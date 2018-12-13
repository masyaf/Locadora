using Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace DAL.Mapping
{
    public class LoanMovieMap : EntityTypeConfiguration<LoanMovie>
    {
        public LoanMovieMap()
        {
            // Primary Key
            this.HasKey(t => t.LoanMovieCode);

            // Properties
            // Table & Column Mappings
            this.ToTable("Aluguel_Filme");
            this.Property(t => t.LoanMovieCode).HasColumnName("CodigoAluguelFilme");
            this.Property(t => t.LoanCode).HasColumnName("CodigoAluguel");
            this.Property(t => t.MovieCode).HasColumnName("CodigoFilme");
            this.Property(t => t.DateReturn).HasColumnName("DataDevolucao");
            this.Property(t => t.DeliveryDate).HasColumnName("DataEntrega");
            this.Property(t => t.FineValue).HasColumnName("ValorMulta");
            this.Property(t => t.Value).HasColumnName("Valor");
            this.Property(t => t.Returned).HasColumnName("Devolvido");

            // Relationships
            this.HasRequired(t => t.Loan)
                .WithMany(t => t.LoanMovies)
                .HasForeignKey(d => d.LoanCode);
            this.HasRequired(t => t.Movie)
                .WithMany(t => t.LoanMovies)
                .HasForeignKey(d => d.MovieCode);

        }
    }
}
