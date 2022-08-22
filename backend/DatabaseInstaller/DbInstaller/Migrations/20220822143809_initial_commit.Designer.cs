﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TC.DatabaseContext;

#nullable disable

namespace DbInstaller.Migrations
{
    [DbContext(typeof(TemperatureConverterDbContext))]
    [Migration("20220822143809_initial_commit")]
    partial class initial_commit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TC.Models.TemperatureConversion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("TemperatureTypeFrom")
                        .HasColumnType("integer");

                    b.Property<int>("TemperatureTypeTo")
                        .HasColumnType("integer");

                    b.Property<decimal?>("TemperatureValueFrom")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("TemperatureValueTo")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("TemperatureConversions");
                });
#pragma warning restore 612, 618
        }
    }
}