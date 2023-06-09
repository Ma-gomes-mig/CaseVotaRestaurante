﻿// <auto-generated />
using System;
using CaseVotaRestaurante.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CaseVotaRestaurante.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230319020503_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CaseVotaRestaurante.Domain.Entities.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("Id"));

                    b.ToTable("Peoples");
                });

            modelBuilder.Entity("CaseVotaRestaurante.Domain.Entities.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Restaurante1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Restaurante2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Restaurante3"
                        });
                });

            modelBuilder.Entity("CaseVotaRestaurante.Domain.Entities.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PeopleId")
                        .HasColumnType("int");

                    b.Property<string>("PeopleName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<DateTime>("VoteDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PeopleId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("CaseVotaRestaurante.Domain.Entities.Vote", b =>
                {
                    b.HasOne("CaseVotaRestaurante.Domain.Entities.People", "People")
                        .WithMany("Votes")
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CaseVotaRestaurante.Domain.Entities.Restaurant", "Restaurant")
                        .WithMany("Votes")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("People");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("CaseVotaRestaurante.Domain.Entities.People", b =>
                {
                    b.Navigation("Votes");
                });

            modelBuilder.Entity("CaseVotaRestaurante.Domain.Entities.Restaurant", b =>
                {
                    b.Navigation("Votes");
                });
#pragma warning restore 612, 618
        }
    }
}
