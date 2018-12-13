using Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class MovieMap : EntityTypeConfiguration<Movie>
    {
        public MovieMap()
        {
            // Primary Key
            this.HasKey(t => t.MovieCode);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(70);

            // Table & Column Mappings
            this.ToTable("Filme");
            this.Property(t => t.MovieCode).HasColumnName("CodigoFilme");
            this.Property(t => t.Title).HasColumnName("TituloFilme");
            this.Property(t => t.GenderCode).HasColumnName("CodigoGenero");
            this.Property(t => t.RankingCode).HasColumnName("CodigoClassificacao");
            this.Property(t => t.RecorderCode).HasColumnName("CodigoGravadora");
            this.Property(t => t.Stock).HasColumnName("EstoqueFilme");
            this.Property(t => t.YearProduction).HasColumnName("AnoProducaoFilme");
            this.Property(t => t.Duration).HasColumnName("DuracaoFilme");
            this.Property(t => t.TypeMovieCode).HasColumnName("CodigoTipo");

            // Relationships
            this.HasRequired(t => t.Ranking)
                .WithMany(t => t.Movies)
                .HasForeignKey(d => d.RankingCode);
            this.HasRequired(t => t.Gender)
                .WithMany(t => t.Movies)
                .HasForeignKey(d => d.GenderCode);
            this.HasRequired(t => t.Recorder)
                .WithMany(t => t.Movies)
                .HasForeignKey(d => d.RecorderCode);
            this.HasRequired(t => t.TypeMovie)
                .WithMany(t => t.Movie)
                .HasForeignKey(d => d.TypeMovieCode);

        }
    }
}
