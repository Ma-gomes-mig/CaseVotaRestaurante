using CaseVotaRestaurante.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Infra.Data.EntitiesConfiguration
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasKey(k=>k.Id);
            builder.Property(p => p.Name).HasMaxLength(70).IsRequired();

            

            builder.HasData(
                new Restaurant(1, "Restaurante1"),
                new Restaurant(2, "Restaurante2"),
                new Restaurant(3, "Restaurante3"));
        }
    }
}
