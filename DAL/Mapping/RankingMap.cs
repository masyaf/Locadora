using Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
    public class RankingMap : EntityTypeConfiguration<Ranking>
    {
        public RankingMap()
        {
            // Primary Key
            this.HasKey(t => t.RankingCode);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Filme_Classificacao");
            this.Property(t => t.RankingCode).HasColumnName("CodigoClassificacao");
            this.Property(t => t.Name).HasColumnName("NomeClassificacao");
        }
    }
}
