using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestAPI.Models;

namespace TestAPI.Data
{
    public class MarcasAutosSeed : IEntityTypeConfiguration<MarcasAutos>
    {
        public void Configure(EntityTypeBuilder<MarcasAutos> builder)
        {
            builder.HasData(
                new MarcasAutos { Id = 1, Marca = "Toyota" },
                new MarcasAutos { Id = 2, Marca = "Hyundai" },
                new MarcasAutos { Id = 3, Marca = "Honda" }
            );
        }
    }
}
