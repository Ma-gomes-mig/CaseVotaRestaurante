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
    public class PeopleConfiguration : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            builder.HasKey(k => k.Id).IsClustered();
            builder.Property(p => p.Name).HasMaxLength(70).IsRequired();

            //builder.HasData(
            //    new People(1, "Pessoa1"),
            //    new People(2, "Pessoa2"),
            //    new People(3, "Pessoa3"),
            //    new People(4, "Pessoa4"),
            //    new People(5, "Pessoa5"));
        }
    }
}
