using Cinemapedia.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemapedia.API.Map
{
    public class MovieMap : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("tb_movie");
            builder.HasKey(x => x.Id).HasName("id_movie");

            builder.Property(x => x.Title).HasColumnName("Title").HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Description).HasColumnName("description").HasColumnType("varchar(500)").IsRequired();
            builder.Property(x => x.ReleaseDate).HasColumnName("release").HasColumnType("DATE").IsRequired();
            builder.Property(x => x.Director).HasColumnName("director").HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Rating).HasColumnName("Rating").HasColumnType("float").IsRequired();
            builder.Property(x => x.Status).HasColumnName("status").HasColumnType("int").IsRequired();
        }
    }
}
