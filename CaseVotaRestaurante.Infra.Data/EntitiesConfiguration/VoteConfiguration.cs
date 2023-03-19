using CaseVotaRestaurante.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseVotaRestaurante.Infra.Data.EntitiesConfiguration
{
    public class VoteConfiguration : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> builder)
        {
            builder.HasKey(k => k.Id);
            //builder.Property(p=>p.PeopleName).HasMaxLength(70).IsRequired();
            builder.Property(p => p.VoteDate).IsRequired();
            //builder.Property(p=>p.RestaurantName).HasMaxLength(70).IsRequired();

            builder.HasOne(e => e.People).WithMany(e => e.Votes).HasForeignKey(f => f.PeopleId);
            builder.HasOne(e => e.Restaurant).WithMany(e => e.Votes).HasForeignKey(f => f.RestaurantId);

        }
    }
}
